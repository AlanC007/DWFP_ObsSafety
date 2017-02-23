<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_EmpTypes.aspx.cs" Inherits="Modif_EmpTypes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Employee Types</title>
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
        <asp:Panel ID="pnlEmpTypesEdit" runat="server" Height="129px">
            Select an Employee type from Below and Choose Edit to Change the Values..<br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" DataKeyNames="UID" DataSourceID="EmpTypeQuery" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="UID" HeaderText="UID" InsertVisible="False" ReadOnly="True" SortExpression="UID" />
                    <asp:BoundField DataField="Value" HeaderText="Value" SortExpression="Value" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="EmpTypeQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblEmpType]"></asp:SqlDataSource>
        </asp:Panel>
        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hlStyle_GoHome" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
