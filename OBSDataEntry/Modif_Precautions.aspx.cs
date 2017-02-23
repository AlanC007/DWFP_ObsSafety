using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modif_Precautions : System.Web.UI.Page
{
    static int SelectedRecordID;
    static string SelectedPreCauGroupName;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tbPrecauName.Text = "";
            tbAbbreviation.Text = "";
            tbCurrPreCauGroup.Text = "";
            tb_SqlResults.Text = "";
            tb_SqlResults.Visible = false;
            tbCurrPreCauGroup.Enabled = false;
        }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string lblname = GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[1].Text;
        SelectedRecordID = Convert.ToInt32(lblname);
        tbPrecauName.Text = GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[2].Text;
        tbAbbreviation.Text = GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[3].Text;
        SelectedPreCauGroupName = GridView1.Rows[Convert.ToInt32(GridView1.SelectedRow.RowIndex)].Cells[4].Text;
        tbCurrPreCauGroup.Text = SelectedPreCauGroupName;
    }

    protected void btnSubmitUpdate_Click(object sender, EventArgs e)
    {
        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;
        string vStrSqlUpdate = "";
        // Test to See if the PreCauGroupName if Diff
        if (SelectedPreCauGroupName == tbCurrPreCauGroup.Text)
        {

        }
    }
    protected void btnSubmitCreateNew_Click(object sender, EventArgs e)
    {

    }

    protected void btnClearData_Click(object sender, EventArgs e)
    {
        GridView1.SelectedIndex = -1;
        GridView1.DataBind();
        tbPrecauName.Text = "";
        tbAbbreviation.Text = "";
        tbCurrPreCauGroup.Text = "";
        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;
        tbCurrPreCauGroup.Enabled = false;
    }
}