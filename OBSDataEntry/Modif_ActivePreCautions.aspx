<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_ActivePreCautions.aspx.cs" Inherits="Modif_ActivePreCautions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 31px;
            left: 24px;
            z-index: 1;
            height: 36px;
        }
        .auto-style2 {
            position: absolute;
            top: 1px;
            left: 38px;
            z-index: 1;
        }
        .auto-style3 {
            width: 358px;
            height: 281px;
            position: absolute;
            top: 159px;
            left: 10px;
            z-index: 1;
        }
        .auto-style4 {
            width: 285px;
            height: 87px;
            position: absolute;
            top: 72px;
            left: 10px;
        }
        .auto-style5 {
            position: absolute;
            top: 9px;
            left: 29px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 9px;
            left: 251px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 38px;
            left: 7px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 38px;
            left: 171px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 38px;
            left: 302px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 82px;
            left: 8px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 590px;
            left: 9px;
            z-index: 1;
        }
        .auto-style12 {
            width: 466px;
            height: 125px;
            position: absolute;
            top: 462px;
            left: 7px;
            z-index: 1;
        }
        .auto-style103 {
            position: absolute;
            top: 638px;
            left: 15px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Selecte a Plant From the Drop Down To Begin.<br />
        Use the Grid Below to Select a Precaution for the Selected Plant, Then Edit The Values in the Below Container.<br />
    
    </div>
        <asp:Panel ID="pnlSelectPlant" runat="server" BorderStyle="Solid" CssClass="auto-style4" Height="79px" style="z-index: 1" Width="277px">
            <asp:DropDownList ID="ddl_SelectPlant" runat="server" AutoPostBack="True" CssClass="auto-style1" DataSourceID="PlantQuery" DataTextField="Name" DataValueField="UID" Width="209px" OnSelectedIndexChanged="ddl_SelectPlant_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="PlantQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT [UID], [Name] FROM [tblPlant]"></asp:SqlDataSource>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Choose Your Plant Below:"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlActivePrecau" runat="server" Height="386px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RecordID" DataSourceID="PreCautionQuery" AllowPaging="True" AllowSorting="True" CssClass="auto-style3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="RecordID" HeaderText="RecordID" ReadOnly="True" SortExpression="RecordID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" ReadOnly="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="PreCautionQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT RecordID, Name, Status, PlantID FROM vUtilPreCauPlantQuery Where PlantID = @PlantID" UpdateCommand="UPDATE vUtilPreCauPlantQuery SET Name = @Name, Status = @Status WHERE (RecordID = @RecordID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddl_SelectPlant" Name="PlantID" PropertyName="SelectedValue" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" />
                    <asp:Parameter Name="Status" />
                    <asp:Parameter Name="RecordID" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </asp:Panel>
        <asp:Panel ID="pnlUpdate" runat="server" BackColor="Yellow" BorderStyle="Solid" Height="117px" Width="458px" CssClass="auto-style12">
            <asp:Label ID="RecordID" runat="server" CssClass="auto-style5" Text="RecordID"></asp:Label>
            <asp:TextBox ID="tbRecordID" runat="server" CssClass="auto-style7"></asp:TextBox>
            <asp:CheckBox ID="cbDeActivate" runat="server" AutoPostBack="True" CssClass="auto-style8" Text="De-Activate" OnCheckedChanged="cbDeActivate_CheckedChanged" />
            <asp:CheckBox ID="cbActivate" runat="server" AutoPostBack="True" CssClass="auto-style9" Text="Activate" OnCheckedChanged="cbActivate_CheckedChanged" />
            <asp:Button ID="btnUpdate" runat="server" CssClass="auto-style10" Height="25px" OnClick="btnUpdate_Click" style="z-index: 1" Text="Update" Width="60px" />
            <asp:Label ID="Status" runat="server" CssClass="auto-style6" Text="Status"></asp:Label>
        </asp:Panel>
        <asp:TextBox ID="tb_SqlResults" runat="server" BackColor="Red" BorderStyle="Outset" CssClass="auto-style11" ForeColor="White" Width="1032px"></asp:TextBox>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style103" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
