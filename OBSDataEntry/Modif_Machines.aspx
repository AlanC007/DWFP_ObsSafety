<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_Machines.aspx.cs" Inherits="Modif_Machines" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Machines</title>
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
    
            Select an Machine from Below and Choose Edit to Change the Values..</div>
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="188px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" DataKeyNames="UID" DataSourceID="MachineQuery" Width="1059px">
                <Columns>
                    <asp:BoundField DataField="UID" HeaderText="UID" ReadOnly="True" SortExpression="UID" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Abbrev" HeaderText="Abbrev" SortExpression="Abbrev" />
                    <asp:BoundField DataField="Dept Assigned" HeaderText="Dept Assigned" SortExpression="Dept Assigned" />
                    <asp:BoundField DataField="PlantLoc" HeaderText="PlantLoc" SortExpression="PlantLoc" />
                    <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" SortExpression="Manufacturer" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="MachineQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT UID, Description, Abbrev, [Dept Assigned], PlantLoc, Manufacturer FROM vUtilMachineDeptQuery"></asp:SqlDataSource>
        </asp:Panel>
        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hlStyle_GoHome" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
