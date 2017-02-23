<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modif_Precautions.aspx.cs" Inherits="Modif_Precautions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Precautions</title>
    <style type="text/css">
        .hlStyle_GoHome {
            position: absolute;
            top: 338px;
            left: 10px;
            z-index: 1;
        }
        .auto-style1 {
            position: absolute;
            top: 578px;
            left: 18px;
            z-index: 1;
        }
        .auto-style2 {
            width: 1493px;
            height: 155px;
            position: absolute;
            top: 350px;
            left: 13px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 57px;
            left: 4px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 57px;
            left: 227px;
            z-index: 1;
            width: 198px;
            right: 1058px;
        }
        .auto-style5 {
            position: absolute;
            top: 58px;
            left: 672px;
            z-index: 1;
            width: 203px;
            height: 20px;
        }
        .auto-style6 {
            position: absolute;
            top: 121px;
            left: 9px;
            z-index: 1;
            width: 129px;
        }
        .auto-style7 {
            position: absolute;
            top: 541px;
            left: 17px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 57px;
            left: 448px;
            z-index: 1;
            width: 198px;
            right: 837px;
        }
        .auto-style9 {
            position: absolute;
            top: 32px;
            left: 89px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 35px;
            left: 308px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 32px;
            left: 496px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 32px;
            left: 713px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 121px;
            left: 153px;
            z-index: 1;
            width: 129px;
        }
        .auto-style14 {
            position: absolute;
            top: 121px;
            left: 297px;
            z-index: 1;
            width: 129px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Select a Precaution Group from Below and Choose Edit to Change the Values..
        <br />
    </div>

        <asp:Panel ID="Panel1" runat="server" Height="275px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="RecordID" DataSourceID="PrecautionsQuery" Width="853px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="RecordID" HeaderText="RecordID" ReadOnly="True" SortExpression="RecordID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Abbrev" HeaderText="Abbrev" SortExpression="Abbrev" />
                    <asp:BoundField DataField="PrecautionGroup" HeaderText="PrecautionGroup" SortExpression="PrecautionGroup" />
                </Columns>
                <SelectedRowStyle BackColor="Yellow" />
            </asp:GridView>
            <asp:SqlDataSource ID="PrecautionsQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="Select * from  vUtilPrecautionGroupQuery"></asp:SqlDataSource>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="155px" BackColor="Yellow" BorderStyle="Solid" CssClass="auto-style2">
            Use these Fields to Edit the Data From the Grid Above After Selecting a Row..<br />
            <br />
            <asp:TextBox ID="tbPrecauName" runat="server" CssClass="auto-style3" Height="20px" Width="200px"></asp:TextBox>
            <asp:TextBox ID="tbAbbreviation" runat="server" CssClass="auto-style4" height="20px" Width="200px"></asp:TextBox>
            <asp:DropDownList ID="ddl_PreCauGroup" runat="server" AutoPostBack="True" CssClass="auto-style5" DataSourceID="PreCauGroupQuery" DataTextField="Value" DataValueField="UID" Height="20px" Width="200px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="PreCauGroupQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT [UID], [Value] FROM [tblPrecautionGroup]"></asp:SqlDataSource>
            <asp:Button ID="btnClearData" runat="server" CssClass="auto-style14" OnClick="btnClearData_Click" Text="Clear Data" />
            <asp:Label ID="Label4" runat="server" CssClass="auto-style11" Text="PreCaution Group"></asp:Label>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style10" Text="Abbrev"></asp:Label>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text="Name"></asp:Label>
            <asp:TextBox ID="tbCurrPreCauGroup" runat="server" CssClass="auto-style8" height="20px" Width="200px"></asp:TextBox>
            <asp:Button ID="btnSubmitUpdate" runat="server" CssClass="auto-style6" OnClick="btnSubmitUpdate_Click" Text="Update Record" />
            <asp:Label ID="Label2" runat="server" CssClass="auto-style12" Text="New PreCaution Group"></asp:Label>
            <asp:Button ID="btnSubmitCreateNew" runat="server" CssClass="auto-style13" OnClick="btnSubmitCreateNew_Click" Text="Create New" />


        </asp:Panel>
        <br />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style1" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </p>
        <p>
            <asp:TextBox ID="tb_SqlResults" runat="server" BackColor="Red" BorderStyle="Outset" ForeColor="White" Width="1032px" CssClass="auto-style7"></asp:TextBox>
            </p>
    </form>
</body>
</html>
