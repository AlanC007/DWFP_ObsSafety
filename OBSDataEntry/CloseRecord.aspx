<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CloseRecord.aspx.cs" Inherits="CloseRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        Obs data Close record-&gt;</div>
<asp:Panel ID="pnlMain" runat="server" Height="500px">
    <label> Choose a Department :</label>
    <asp:DropDownList ID="ddl_Department" runat="server" DataSourceID="DepartmentQuery" DataTextField="Desc" DataValueField="UID" Height="34px" Width="254px" OnSelectedIndexChanged="ddl_DepartmentQuery_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="DepartmentQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="Select * from tblDepartments Where [UID] in (Select [DeptId] from vUtil_ObsSafetyData)"></asp:SqlDataSource>
    <br />
    <br />
    <br />
    <asp:GridView ID="gvObsCloseRecord" runat="server" DataSourceID="ObsDataClose" OnSelectedIndexChanged="gvObsCloseRecord_SelectedIndexChanged" AutoGenerateSelectButton="True" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="RecordID" HeaderText="RecordID" SortExpression="RecordID" />
            <asp:BoundField DataField="When" HeaderText="When" SortExpression="When" />
            <asp:BoundField DataField="DeptID" HeaderText="DeptID" SortExpression="DeptID" />
            <asp:BoundField DataField="Dept_Desc" HeaderText="Dept_Desc" SortExpression="Dept_Desc" />
            <asp:BoundField DataField="MachID" HeaderText="MachID" SortExpression="MachID" />
            <asp:BoundField DataField="Mach_Desc" HeaderText="Mach_Desc" SortExpression="Mach_Desc" />
            <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
            <asp:BoundField DataField="FG Safe Status" HeaderText="FG Safe Status" ReadOnly="True" SortExpression="FG Safe Status" />
            <asp:BoundField DataField="FG Habit Status" HeaderText="FG Habit Status" SortExpression="FG Habit Status" ReadOnly="True" />
            <asp:BoundField DataField="PC Safe Status" HeaderText="PC Safe Status" ReadOnly="True" SortExpression="PC Safe Status" />
            <asp:BoundField DataField="PC Habit Status" HeaderText="PC Habit Status" ReadOnly="True" SortExpression="PC Habit Status" />
            <asp:BoundField DataField="LF Safe Status" HeaderText="LF Safe Status" SortExpression="LF Safe Status" ReadOnly="True" />
            <asp:BoundField DataField="LF Habit Status" HeaderText="LF Habit Status" SortExpression="LF Habit Status" ReadOnly="True" />
            <asp:BoundField DataField="EPT Safe Status" HeaderText="EPT Safe Status" SortExpression="EPT Safe Status" ReadOnly="True" />
            <asp:BoundField DataField="EPT Habit Status" HeaderText="EPT Habit Status" ReadOnly="True" SortExpression="EPT Habit Status" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:BoundField DataField="CorrectiveAction" HeaderText="CorrectiveAction" SortExpression="CorrectiveAction" />
            <asp:BoundField DataField="UpdateBy" HeaderText="UpdateBy" SortExpression="UpdateBy" />
            <asp:BoundField DataField="Closedby" HeaderText="Closedby" SortExpression="Closedby" />
            <asp:BoundField DataField="ClosedTimestamp" HeaderText="ClosedTimestamp" SortExpression="ClosedTimestamp" />
            <asp:BoundField DataField="PlantID" HeaderText="PlantID" SortExpression="PlantID" />
            <asp:BoundField DataField="Emp_Shift" HeaderText="Emp_Shift" SortExpression="Emp_Shift" />
            <asp:BoundField DataField="Emp_Type" HeaderText="Emp_Type" SortExpression="Emp_Type" />
            <asp:BoundField DataField="OrgLvl" HeaderText="OrgLvl" SortExpression="OrgLvl" />
        </Columns>
        <SelectedRowStyle BackColor="Yellow" />
    </asp:GridView>
    <asp:SqlDataSource ID="ObsDataClose" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="Select * from vUtil_ObsSafetyData Where [Status]=2"></asp:SqlDataSource>

    <br />
    <br />
    Who Are you?:
    <asp:DropDownList ID="ddl_Users" runat="server" AutoPostBack="True" DataSourceID="UserNameQuery" DataTextField="Name" DataValueField="UID" Height="33px" Width="214px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="UserNameQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT UID, LastName + ',' + FirstName AS 'Name' FROM Users WHERE (ORG_LVL &gt;= 3)
order by LastName"></asp:SqlDataSource>
            <asp:TextBox ID="tb_SqlResults" runat="server" BackColor="Red" BorderStyle="Outset" ForeColor="White" Width="1032px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />

</asp:Panel>

        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="GoHome" runat="server" NavigateUrl="http://devautosql01:7357/homescreen.aspx">Go Home</asp:HyperLink>
        </p>

    </form>
</body>
</html>
