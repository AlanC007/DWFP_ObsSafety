using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Modif_ActivePreCautions : System.Web.UI.Page
{
    static int intRecordID;
    static bool bStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tb_SqlResults.Text = "";
            tb_SqlResults.Visible = false;
            pnlUpdate.Enabled = false;
            pnlUpdate.Visible = false;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;

        int intStatus = Convert.ToInt32(GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[3].Text);
        tbRecordID.Text = GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[1].Text;
        intRecordID = Convert.ToInt32(tbRecordID.Text);
        bool statusBool = Convert.ToBoolean(intStatus);
        if (statusBool)
        {
            cbDeActivate.Checked = false; 
            cbActivate.Checked = true;
            bStatus = true;
        }
        if (!statusBool)
        {
            cbDeActivate.Checked = true;
            cbActivate.Checked = false;
            bStatus = false;
        }
        pnlUpdate.Enabled = true;
        pnlUpdate.Visible = true;
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSSafetyConnectionString"].ConnectionString);

        /* Set up The Sql Command Construct */
        SqlCommand vobjADOvobjADOCmd = new SqlCommand();
        vobjADOvobjADOCmd.Connection = con;
        vobjADOvobjADOCmd.CommandText = "uspUpdatePrecauList";
        vobjADOvobjADOCmd.CommandType = System.Data.CommandType.StoredProcedure;

        /* Add Input Variables */
        SqlParameter RecordID = vobjADOvobjADOCmd.Parameters.AddWithValue("@RecordId", intRecordID);
        RecordID.SqlDbType = SqlDbType.Int;
        RecordID.Direction = ParameterDirection.Input;

        SqlParameter Status = vobjADOvobjADOCmd.Parameters.AddWithValue("@Status", bStatus);
        Status.SqlDbType = SqlDbType.Bit;
        Status.Direction = ParameterDirection.Input;

        /* Add Output Variables */
        SqlParameter IntResultCode = vobjADOvobjADOCmd.Parameters.AddWithValue("@IntResultCode", "");
        IntResultCode.SqlDbType = SqlDbType.Int;
        IntResultCode.Direction = ParameterDirection.Output;
        SqlParameter strResultText = vobjADOvobjADOCmd.Parameters.AddWithValue("@strResultText", "");
        strResultText.SqlDbType = SqlDbType.VarChar;
        strResultText.Size = 256;
        strResultText.Direction = ParameterDirection.Output;

        /* Execute The Method */
        try
        {
            con.Open();
        }
        catch (Exception ex)
        {
            tb_SqlResults.Text = ex.Message;
            tb_SqlResults.Visible = true;
            return;
        }
        try
        {
            vobjADOvobjADOCmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            tb_SqlResults.Text = ex.Message;
            tb_SqlResults.Visible = true;
            return;
        }


        /*Error and Information treatment */
        int retunvalue = Convert.ToInt32(vobjADOvobjADOCmd.Parameters["@IntResultCode"].Value);

        if (retunvalue != 1)
        {
            tb_SqlResults.Text = "Sql Failure result String Was " + "[" + IntResultCode.Value + "]" + "->" + strResultText.Value;
            tb_SqlResults.Visible = true;
            return;
        }
        if (retunvalue == 1)
        {
            tb_SqlResults.Text = "";
            tb_SqlResults.Visible = false;

        }
        /* Enable Execution Error Treatment and Parameter Closing Statements */
        con.Close();
        GridView1.DataBind();

    }
    protected void cbDeActivate_CheckedChanged(object sender, EventArgs e)
    {
        cbActivate.Checked = false;
        bStatus = false;
    }
    protected void cbActivate_CheckedChanged(object sender, EventArgs e)
    {
        cbDeActivate.Checked = false;
        bStatus = true;
    }
    protected void ddl_SelectPlant_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnlUpdate.Enabled = false;
        pnlUpdate.Visible = false;
        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;
    }
}
