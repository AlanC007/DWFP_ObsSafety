<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TemplatePanelObject.ascx.cs" Inherits="TemplatePanelObject" %>
<style type="text/css">


        .auto-style78 {
            width: 1280px;
            height: 129px;
            position: absolute;
            top: 167px;
            left: 10px;
            z-index: 1;
        }
        
        .auto-style17 {
            position: absolute;
            top: 0px;
            left: 3px;
            z-index: 1;
            width: 175px;
        }
        .pnlStyle_1 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 165px;
            left: 10px;
            z-index: 1;
        }

        .auto-style38 {
            position: absolute;
            top: 27px;
            left: 176px;
            z-index: 1;
            width: 168px;
            height: 33px;
        }

        .auto-style21 {
            position: absolute;
            top: 65px;
            left: 228px;
            z-index: 1;
        }

        .auto-style22 {
            position: absolute;
            top: 93px;
            left: 176px;
            z-index: 1;
            width: 165px;
            height: 21px;
        }

        .auto-style53 {
            position: absolute;
            top: 30px;
            left: 388px;
            z-index: 1;
        }

        .auto-style51 {
            position: absolute;
            top: 16px;
            left: 529px;
            z-index: 1;
            width: 734px;
            height: 34px;
        }

        .auto-style54 {
            position: absolute;
            top: 87px;
            left: 385px;
            z-index: 1;
        }

        .auto-style26 {
            position: absolute;
            top: 74px;
            left: 529px;
            z-index: 1;
            width: 733px;
            height: 34px;
        }

        .auto-style34 {
            position: absolute;
            top: 0px;
            left: 232px;
            z-index: 1;
            bottom: 132px;
        }

        </style>
            <asp:Panel ID="pnl1" runat="server" BackColor="Yellow" CssClass="auto-style78" BorderStyle="Solid" style="z-index: 1">
                <asp:Label ID="lblPanel" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                <asp:DropDownList ID="ddl_StatusQuery" runat="server" CssClass="auto-style38" DataSourceID="ddl_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="Label3" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_Condition" runat="server" CssClass="auto-style22" DataSourceID="ddl_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="lblFG_ObserverComment" runat="server" CssClass="auto-style53" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbFG_ObservComment" runat="server" CssClass="auto-style51" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFG_EmpComment" runat="server" CssClass="auto-style54" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbFG_EmpComment" runat="server" CssClass="auto-style26" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style34" Text="Status"></asp:Label>
            </asp:Panel>
            
