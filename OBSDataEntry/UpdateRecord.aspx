<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateRecord.aspx.cs" Inherits="UpdateRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 708px;
            left: 16px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        OBS Record Update. 
        <br />
        <br />
        Select a Department to filter the records :<asp:DropDownList ID="ddl_Department" runat="server" AutoPostBack="True" DataSourceID="tblDepartmentQuery" DataTextField="Desc" DataValueField="UID" Height="33px" OnSelectedIndexChanged="ddl_Department_SelectedIndexChanged" Width="271px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="tblDepartmentQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="Select [UID],[Desc] from tblDepartments where [UID] in
(Select [DeptID] from tblCollectedData)"></asp:SqlDataSource>
        <br />
        Choose the Record and Provide the Corrective Action.</div>
        <asp:Panel ID="Panel1" runat="server" Height="474px">
            <asp:GridView ID="gvObsData" runat="server" AutoGenerateColumns="False" DataKeyNames="RecordID,DeptID,MachID" DataSourceID="OBSDataUpdate" AllowSorting="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvObsData_SelectedIndexChanged" AllowPaging="True">
                <Columns>
                    <asp:BoundField DataField="RecordID" HeaderText="RecordID" SortExpression="RecordID" ReadOnly="True" />
                    <asp:BoundField DataField="When" HeaderText="When" SortExpression="When" />
                    <asp:BoundField DataField="DeptID" HeaderText="DeptID" SortExpression="DeptID" ReadOnly="True" />
                    <asp:BoundField DataField="Dept_Desc" HeaderText="Dept_Desc" SortExpression="Dept_Desc" />
                    <asp:BoundField DataField="MachID" HeaderText="MachID" ReadOnly="True" SortExpression="MachID" />
                    <asp:BoundField DataField="Mach_Desc" HeaderText="Mach_Desc" SortExpression="Mach_Desc" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                    <asp:BoundField DataField="FG Safe Status" HeaderText="FG Safe Status" ReadOnly="True" SortExpression="FG Safe Status" />
                    <asp:BoundField DataField="FG Habit Status" HeaderText="FG Habit Status" SortExpression="FG Habit Status" ReadOnly="True" />
                    <asp:BoundField DataField="PC Safe Status" HeaderText="PC Safe Status" SortExpression="PC Safe Status" ReadOnly="True" />
                    <asp:BoundField DataField="PC Habit Status" HeaderText="PC Habit Status" ReadOnly="True" SortExpression="PC Habit Status" />
                    <asp:BoundField DataField="LF Safe Status" HeaderText="LF Safe Status" ReadOnly="True" SortExpression="LF Safe Status" />
                    <asp:BoundField DataField="LF Habit Status" HeaderText="LF Habit Status" SortExpression="LF Habit Status" ReadOnly="True" />
                    <asp:BoundField DataField="EPT Safe Status" HeaderText="EPT Safe Status" SortExpression="EPT Safe Status" ReadOnly="True" />
                    <asp:BoundField DataField="EPT Habit Status" HeaderText="EPT Habit Status" ReadOnly="True" SortExpression="EPT Habit Status" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="OBSDataUpdate" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [vUtil_ObsSafetyData]"></asp:SqlDataSource>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label">Corractive action taken: </asp:Label>
            <asp:TextBox ID="tbCorrectiveAction" runat="server" TextMode="MultiLine" Width="1024px"></asp:TextBox>
            <br />
            <br />
            Who Are You? :
            <asp:DropDownList ID="ddl_Users" runat="server" AutoPostBack="True" DataSourceID="UserNameQuery" DataTextField="Name" DataValueField="UID" Height="33px" Width="214px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="UserNameQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT UID, LastName + ',' + FirstName AS 'Name' FROM Users WHERE (ORG_LVL &gt;= 3)
order by LastName"></asp:SqlDataSource>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <br />
            <br />
            <asp:TextBox ID="tb_SqlResults" runat="server" BackColor="Red" BorderStyle="Outset" ForeColor="White" Width="1032px"></asp:TextBox>
            <br />
            <br />
            <br />
        </asp:Panel>
        <p>
            <asp:HyperLink ID="GoHome" runat="server" NavigateUrl="http://devautosql01:7357/homescreen.aspx" CssClass="auto-style1">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
