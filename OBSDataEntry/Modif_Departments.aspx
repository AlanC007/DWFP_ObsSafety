<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_Departments.aspx.cs" Inherits="Modif_Departments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Departments</title>
    <style type="text/css">
        .hlStyle_GoHome {
            position: absolute;
            top: 338px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="pnlDepartmentsQry" runat="server" Height="225px">
            Select a Department from Below and Choose Edit to Change the Values..<br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" DataKeyNames="UID" DataSourceID="DeptQuery" Height="97px" PageSize="5" Width="935px">
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="DeptQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblDepartments]"></asp:SqlDataSource>

        </asp:Panel>
        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hlStyle_GoHome" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
