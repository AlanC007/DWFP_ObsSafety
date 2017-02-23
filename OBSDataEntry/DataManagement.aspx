<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataManagement.aspx.cs" Inherits="DataManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Choose From the Elements Below:<br />
        <br />
    
    </div>
        <asp:Panel ID="pnlDataManagement" runat="server" BackColor="Yellow" BorderStyle="Solid" BorderWidth="4px" CssClass="auto-style5" Height="201px" Width="266px">
            <strong>System Data Management</strong>:<br />
            <asp:HyperLink ID="hlModifUsers" runat="server" NavigateUrl="">Users</asp:HyperLink>
            <br />
               <asp:HyperLink ID="hlModifMachines" runat="server" NavigateUrl="">Machines</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hlModifDepartments" runat="server" NavigateUrl="">Departments</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hlModifEmpTypes" runat="server" NavigateUrl="">Employee Types</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hlModifPrecauGroups" runat="server" NavigateUrl="">Precaution Groups</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hlModifPrecautions" runat="server" NavigateUrl="">Precautions</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hlModifActivEPrecau" runat="server" NavigateUrl="~/Modif_ActivePreCautions.aspx">Active Precautions</asp:HyperLink>
        </asp:Panel>
    </form>
</body>
</html>
