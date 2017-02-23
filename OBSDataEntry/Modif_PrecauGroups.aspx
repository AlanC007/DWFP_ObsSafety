<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_PrecauGroups.aspx.cs" Inherits="Modif_PrecauGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Precaution Groups</title>
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
        <div>Select a Precaution Group from Below and Choose Edit to Change the Values..</div>
        <br />
        <asp:Panel ID="pnlPreCauGroups" runat="server" Height="242px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" DataKeyNames="UID" DataSourceID="PreCauGroupQuery" PageSize="5" Width="554px">
                <Columns>
                    <asp:BoundField DataField="UID" HeaderText="UID" InsertVisible="False" ReadOnly="True" SortExpression="UID" />
                    <asp:BoundField DataField="Value" HeaderText="Value" SortExpression="Value" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="PreCauGroupQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT [UID], [Value] FROM [tblPrecautionGroup]"></asp:SqlDataSource>
        </asp:Panel>

        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hlStyle_GoHome" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
