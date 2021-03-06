﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class CloseRecord : System.Web.UI.Page
{
    static int intSelectedRecord;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ObsDataClose.SelectCommand = "SELECT * FROM [vUtil_ObsSafetyData] Where [Status]=2";
            tb_SqlResults.Text = "";
            tb_SqlResults.Visible = false;
        }
        //Check if we have returned records into the Grid. If we have a Record Count of 0 then Hide the Div
        if (gvObsCloseRecord.Rows.Count == 0)
        {
            pnlMain.Enabled = false;
        }
        if (gvObsCloseRecord.Rows.Count != 0)
        {
            pnlMain.Enabled = true;
        }
    }

    protected void ddl_DepartmentQuery_SelectedIndexChanged(object sender, EventArgs e)
    {
        ObsDataClose.SelectCommand = "SELECT * FROM [vUtil_ObsSafetyData] Where [DeptId]=" + ddl_Department.SelectedItem.Value + " And [Status]=2";
        gvObsCloseRecord.DataBind();
    }

    protected void gvObsCloseRecord_SelectedIndexChanged(object sender, EventArgs e)
    {
        intSelectedRecord = Convert.ToInt32(gvObsCloseRecord.Rows[Convert.ToInt32(gvObsCloseRecord.SelectedRow.RowIndex)].Cells[1].Text);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        tb_SqlResults.Visible = false;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSSafetyConnectionString"].ConnectionString);
        /* Set up The Sql Command Construct */
        SqlCommand vobjADOvobjADOCmd = new SqlCommand();
        vobjADOvobjADOCmd.Connection = con;
        vobjADOvobjADOCmd.CommandText = "uspCloseOBS_Data";
        vobjADOvobjADOCmd.CommandType = System.Data.CommandType.StoredProcedure;

        /* Add Input Variables */
        SqlParameter RecordId = vobjADOvobjADOCmd.Parameters.AddWithValue("@intRecordID", intSelectedRecord);
        RecordId.Direction = ParameterDirection.Input;
        RecordId.SqlDbType = SqlDbType.Int;

        SqlParameter intUserID = vobjADOvobjADOCmd.Parameters.AddWithValue("@intUserID", ddl_Users.SelectedValue);
        intUserID.Direction = ParameterDirection.Input;
        intUserID.SqlDbType = SqlDbType.Int;

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

        }
        /* Enable Execution Error Treatment and Parameter Closing Statements */
        con.Close();
        //Refresh the ListBoxes / Grid Objects
        ddl_Users.DataBind();
        ObsDataClose.SelectCommand = "SELECT * FROM [vUtil_ObsSafetyData] Where [DeptId]=" + ddl_Department.SelectedItem.Value + " And [Status]=2";
        gvObsCloseRecord.DataBind();

        //Check if we have returned records into the Grid. If we have a Record Count of 0 then Hide the Div
        if (gvObsCloseRecord.Rows.Count == 0)
        {
            pnlMain.Enabled = false;
        }
        if (gvObsCloseRecord.Rows.Count != 0)
        {
            pnlMain.Enabled = true;
        }
    }
}
