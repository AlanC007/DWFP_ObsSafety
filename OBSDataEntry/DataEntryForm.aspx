<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataEntryForm.aspx.cs" Inherits="DataEntryForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="pnlStyles.css" rel="stylesheet" />
    <title></title>    
    <style type="text/css">
        <!-- Named Styles Start > .Headerstyle {
            height: 103px;
        }

        .StyleLogo {
            position: relative;
            width: 230px;
            height: 158px;
            left: 932px;
            top: -25px;
        }

        .Div-styleObsWhen {
            height: 77px;
            width: 1507px;
            position: absolute;
            top: 119px;
            left: 18px;
            z-index: 1;
        }
        <!-- Labels .lblstyleDateTime {
            position: absolute;
            top: -138px;
            left: 6px;
            z-index: 1;
            width: 81px;
        }

        .lblstyleDateTime {
            position: absolute;
            top: 147px;
            left: 14px;
            z-index: 1;
            right: 1442px;
        }

        .lblStyleObserver {
            position: absolute;
            top: 155px;
            left: 22px;
            z-index: 1;
        }
        <!-- text Boxes .tbStyleDateTime {
            position: absolute;
            top: -19px;
            left: 102px;
            z-index: 1;
        }

        .ddlstyleUsername {
            position: absolute;
            top: 153px;
            left: 101px;
            z-index: 1;
            width: 230px;
            height: 23px;
        }

        <!-- Panel Styles Start
        .pnlStyle_ObsCoreData {
            width: 1280px;
            height: 85px;
            position: absolute;
            top: 155px;
            left: 10px;
            z-index: 1;
        }             
             
       .pnlStyle_FG {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 250px;
            left: 10px;
            z-index: 1;
        }

        .pnlStyle_Pace {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 395px;
            left: 10px;
            z-index: 1;
        }

        .pnlStyle_LOF {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 540px;
            left: 10px;
            z-index: 1;
        }

        .pnlStyle_EOPT {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 685px;
            left: 10px;
            z-index: 1;
        }

        .pnlStyle_Ali {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 830px;
            left: 10px;
            z-index: 1;
        }

        .pnlStyle_Ext {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_Rep {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_PP {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_Foo {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_ConfA {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_Comp {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_Coor {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_ID {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_Clean {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_5S {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_TC {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_TU {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_TI {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_FKL {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_PPE_S {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_PPE_U {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }

        .pnlStyle_PPE_C {
            width: 1280px;
            height: 140px;
            position: absolute;
            top: 490px;
            left: 4px;
            z-index: 1;
        }
        .pnlStyle1{}
        <!-- Named Styles End > .auto-style3 {
            position: absolute;
            top: -19px;
            left: 102px;
            z-index: 1;
        }

        .auto-style9 {
            position: absolute;
            top: 40px;
            left: 92px;
            z-index: 1;
            width: 230px;
            height: 23px;
        }

        .auto-style10 {
            position: absolute;
            width: 132px;
            height: 90px;
            left: 1173px;
            top: 21px;
            z-index: 2;
        }

        .auto-style12 {
            position: absolute;
            top: 11px;
            left: 437px;
            z-index: 1;
            width: 230px;
            height: 25px;
            bottom: 45px;
        }

        .auto-style13 {
            position: absolute;
            top: 12px;
            left: 354px;
            z-index: 1;
            right: 849px;
        }

        .auto-style14 {
            position: absolute;
            top: 41px;
            left: 372px;
            z-index: 1;
        }

        .auto-style15 {
            position: absolute;
            top: 40px;
            left: 437px;
            z-index: 1;
            width: 230px;
            height: 25px;
        }

        .auto-style17 {
            position: absolute;
            top: 0px;
            left: 3px;
            z-index: 1;
            width: 175px;
        }

        .auto-style20 {
            position: absolute;
            top: -3px;
            left: 234px;
            z-index: 1;
            bottom: 135px;
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

        .auto-style23 {
            position: absolute;
            top: 12px;
            left: 8px;
            z-index: 1;
        }

        .auto-style24 {
            position: absolute;
            top: 11px;
            left: 92px;
            z-index: 1;
            width: 222px;
        }

        .auto-style26 {
            position: absolute;
            top: 74px;
            left: 529px;
            z-index: 1;
            width: 733px;
            height: 34px;
        }

        .auto-style33 {
            position: absolute;
            top: 1px;
            left: 242px;
            z-index: 1;
            bottom: 133px;
        }

        .auto-style34 {
            position: absolute;
            top: 0px;
            left: 232px;
            z-index: 1;
            bottom: 132px;
        }

        .auto-style37 {
            position: absolute;
            top: 906px;
            left: 1191px;
            z-index: 1;
            width: 105px;
            height: 29px;
        }

        .auto-style38 {
            position: absolute;
            top: 27px;
            left: 176px;
            z-index: 1;
            width: 168px;
            height: 33px;
        }

        .auto-style39 {
            position: absolute;
            top: 21px;
            left: 176px;
            z-index: 1;
            width: 168px;
            height: 33px;
        }

        .auto-style40 {
            position: absolute;
            top: 2px;
            left: 242px;
            z-index: 1;
            bottom: 130px;
        }

        .auto-style41 {
            position: absolute;
            top: 25px;
            left: 176px;
            z-index: 1;
            width: 168px;
            height: 33px;
        }

        .auto-style42 {
            position: absolute;
            top: 16px;
            left: 528px;
            z-index: 1;
            width: 728px;
            height: 34px;
        }

        .auto-style43 {
            position: absolute;
            top: 74px;
            left: 528px;
            z-index: 1;
            width: 732px;
            height: 34px;
        }

        .auto-style44 {
            position: absolute;
            top: 82px;
            left: 384px;
            z-index: 1;
        }

        .auto-style45 {
            position: absolute;
            top: 25px;
            left: 387px;
            z-index: 1;
        }

        .auto-style47 {
            position: absolute;
            top: 74px;
            left: 529px;
            z-index: 1;
            width: 734px;
            height: 34px;
        }

        .auto-style48 {
            position: absolute;
            top: 15px;
            left: 529px;
            z-index: 1;
            width: 734px;
            height: 34px;
        }

        .auto-style51 {
            position: absolute;
            top: 16px;
            left: 529px;
            z-index: 1;
            width: 734px;
            height: 34px;
        }

        .auto-style52 {
            position: absolute;
            top: 74px;
            left: 529px;
            z-index: 1;
            width: 732px;
            height: 34px;
        }

        .auto-style53 {
            position: absolute;
            top: 30px;
            left: 388px;
            z-index: 1;
        }

        .auto-style54 {
            position: absolute;
            top: 87px;
            left: 385px;
            z-index: 1;
        }

        .auto-style55 {
            position: absolute;
            top: 25px;
            left: 388px;
            z-index: 1;
        }

        .auto-style56 {
            position: absolute;
            top: 82px;
            left: 385px;
            z-index: 1;
        }

        .auto-style58 {
            width: 1280px;
            height: 20px;
            position: absolute;
            top: 871px;
            left: 9px;
            z-index: 1;
        }

        .auto-style59 {
            position: absolute;
            top: 906px;
            left: 1076px;
            z-index: 1;
            width: 105px;
            height: 29px;
        }

        .auto-style60 {
            position: absolute;
            top: 13px;
            left: 678px;
            z-index: 1;
            width: 112px;
            height: 18px;
        }

        .auto-style61 {
            position: absolute;
            top: 12px;
            left: 846px;
            z-index: 1;
        }

        .auto-style62 {
            position: absolute;
            top: 11px;
            left: 783px;
            z-index: 1;
            width: 54px;
            height: 13px;
        }

        .auto-style65 {
            position: absolute;
            top: 11px;
            left: 961px;
            z-index: 1;
        }

        .auto-style67 {
            position: absolute;
            top: 41px;
            left: 679px;
            z-index: 1;
        }

        .auto-style68 {
            position: absolute;
            top: 40px;
            left: 805px;
            z-index: 1;
            width: 113px;
            height: 12px;
            right: 365px;
        }

        .auto-style76 {
            position: absolute;
            top: 32px;
            left: 213px;
            z-index: 1;
            width: 215px;
            height: 13px;
            right: 1002px;
        }

        .auto-style77 {
            width: 1141px;
            height: 85px;
            position: absolute;
            top: 72px;
            left: 10px;
            z-index: 1;
        }

        .auto-style78 {
            width: 1280px;
            height: 129px;
            position: absolute;
            top: 167px;
            left: 10px;
            z-index: 1;
        }
        .auto-style79 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 174px;
            left: 200px;
            z-index: 1;
        }
        .auto-style80 {
            width: 1280px;
            height: 131px;
            position: absolute;
            top: 176px;
            left: 430px;
            z-index: 1;
        }
        .auto-style81 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 321px;
            left: 7px;
            z-index: 1;
        }
        .auto-style82 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 169px;
            left: 53px;
            z-index: 1;
        }

        .auto-style83 {
            position: absolute;
            top: 0px;
            left: 3px;
            z-index: 1;
            width: 175px;
            bottom: 94px;
        }

        .auto-style84 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 321px;
            left: 43px;
            z-index: 1;
        }
        .auto-style85 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 322px;
            left: 119px;
            z-index: 1;
        }
        .auto-style86 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 324px;
            left: 209px;
            z-index: 1;
        }

        .auto-style87 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 474px;
            left: 8px;
            z-index: 1;
        }

        .auto-style88 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 325px;
            left: 325px;
            z-index: 1;
        }
        .auto-style89 {
            position: absolute;
            top: 1px;
            left: 242px;
            z-index: 1;
            bottom: 120px;
        }
        .auto-style90 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 321px;
            left: 454px;
            z-index: 1;
        }
        .auto-style91 {
            position: absolute;
            top: 0px;
            left: 3px;
            z-index: 1;
            width: 175px;
            height: 36px;
        }

        .auto-style92 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 475px;
            left: 94px;
            z-index: 1;
        }

        .auto-style93 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 474px;
            left: 179px;
            z-index: 1;
        }

        .auto-style94 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 477px;
            left: 277px;
            z-index: 1;
        }

        .auto-style95 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 622px;
            left: 9px;
            z-index: 1;
        }

        .auto-style96 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 474px;
            left: 399px;
            z-index: 1;
        }

        .auto-style97 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 621px;
            left: 101px;
            z-index: 1;
        }

        .auto-style98 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 624px;
            left: 180px;
            z-index: 1;
        }

        .auto-style99 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 625px;
            left: 273px;
            z-index: 1;
        }

        .auto-style100 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 627px;
            left: 356px;
            z-index: 1;
        }

        .auto-style101 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 777px;
            left: 46px;
            z-index: 1;
        }

        .auto-style102 {
            width: 1280px;
            height: 130px;
            position: absolute;
            top: 976px;
            left: 63px;
            z-index: 1;
        }

        .hlStyle_GoHome {
            position: absolute;
            top: 338px;
            left: 10px;
            z-index: 1;
        }
        .auto-style103 {
            position: absolute;
            top: 923px;
            left: 21px;
            z-index: 1;
        }

        </style>
</head>
<body style="width: 1303px; height: 937px;">
    <form id="form1" runat="server">
        <div class="Headerstyle" style="width: 1301px; height: 97px;">
            <img alt="" class="auto-style10" src="DynamicData/Content/Images/CompanyLogo.jpg" />
            <asp:Label ID="lblHeadertext" runat="server" CssClass="styleHeaderText" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" Style="z-index: 1; position: absolute; top: 27px; left: 471px; width: 445px" Text="SRT Observation Check List"></asp:Label>
            <asp:Label ID="lblheaderPlantChoice" runat="server" CssClass="lblStyle_PlantChoice" Text="Choose Your Plant to begin:-&gt; " Style="z-index: 1; position: absolute; top: 31px; left: 20px"></asp:Label>
            </div>
            <br />
            <asp:Panel ID="pnlForceGrip" runat="server" BackColor="Yellow" CssClass="auto-style78" BorderStyle="Solid">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Force / Grip"></asp:Label>
                <asp:DropDownList ID="ddl_FGStatus" runat="server" CssClass="auto-style38" DataSourceID="FG_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="Label3" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_FGCondition" runat="server" CssClass="auto-style22" DataSourceID="FG_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="lblFG_ObserverComment" runat="server" CssClass="auto-style53" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbFG_ObservComment" runat="server" CssClass="auto-style51" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFG_EmpComment" runat="server" CssClass="auto-style54" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbFG_EmpComment" runat="server" CssClass="auto-style26" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style34" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlPace" runat="server" BackColor="#FFCC00" CssClass="auto-style79" BorderStyle="Solid">
                <asp:Label ID="lblPaceheader" runat="server" CssClass="auto-style83" Font-Bold="True" Font-Size="XX-Large" Text="Pace"></asp:Label>
                <asp:DropDownList ID="ddl_PaceStatus" runat="server" CssClass="auto-style39" DataSourceID="PaceStatus" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="lblPaceCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PaceCondition" runat="server" CssClass="auto-style22" DataSourceID="PaceCondition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="lblPace_ObserverComment" runat="server" CssClass="auto-style55" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbPace_ObservComment" runat="server" CssClass="auto-style48" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPace_EmpComment" runat="server" CssClass="auto-style56" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbPace_EmpComment" runat="server" CssClass="auto-style47" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPaceStatus" runat="server" CssClass="auto-style20" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlLineOfFire" runat="server" BackColor="#FF9933" CssClass="auto-style80" BorderStyle="Solid">
                <asp:Label ID="lblLOFHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Line Of Fire"></asp:Label>
                <asp:DropDownList ID="ddl_LOFStatus" runat="server" CssClass="auto-style41" DataSourceID="Lof_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:Label ID="lblLOFCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_LOFCondition" runat="server" CssClass="auto-style22" DataSourceID="LOF_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:Label ID="lblLOF_ObserverComment" runat="server" CssClass="auto-style55" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbLOF_ObservComment" runat="server" CssClass="auto-style51" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblLOF_EmpComment" runat="server" CssClass="auto-style56" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbLOF_EmpComment" runat="server" CssClass="auto-style52" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblLOFStatus" runat="server" CssClass="auto-style40" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlEopT" runat="server" BackColor="#FF6600" CssClass="auto-style81" BorderStyle="Solid">
                <asp:Label ID="lblEOPHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Eyes On Path/Task"></asp:Label>
                <asp:DropDownList ID="ddl_EOPStatus" runat="server" CssClass="auto-style41" DataSourceID="EOP_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:Label ID="lblEOPCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_EOPCondition" runat="server" CssClass="auto-style22" DataSourceID="EOP_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:Label ID="lblEOP_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbEOP_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOP_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbEOP_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOPStatus" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:TextBox ID="tb_SqlResults" runat="server" BackColor="Red" BorderStyle="Outset" CssClass="auto-style58" ForeColor="White"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style59" Text="Submit" OnClick="btnSaveForm_Click" />
            <asp:Button ID="btnClearForm" runat="server" CssClass="auto-style37" Text="Clear Form" OnClick="btnClearForm_Click" />

            <asp:Panel ID="pnlAlignment" runat="server" BackColor="#FF5050" CssClass="auto-style82" BorderStyle="Solid">
                <asp:Label ID="lblAlignmentheader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Alignment"></asp:Label>
                <asp:DropDownList ID="ddl_AlignStatus" runat="server" CssClass="auto-style41" DataSourceID="Align_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Align_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>
                <asp:Label ID="lblEOPCondition0" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_AlignCondition" runat="server" CssClass="auto-style22" DataSourceID="Align_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Align_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>
                <asp:Label ID="lblEOP_ObserverComment0" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbAlign_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOP_EmpComment0" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbAlign_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOPStatus0" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>

            <br />
            <br />

            <asp:DropDownList ID="ddl_PlantQuery" runat="server" AutoPostBack="True" CssClass="auto-style76" DataSourceID="PlantQuery" DataTextField="Name" DataValueField="UID" Height="25px" OnSelectedIndexChanged="ddl_PlantQuery_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="PlantQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT UID, Name FROM tblPlant WHERE (Active = @Active)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="True" Name="Active" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Panel ID="pnlObsCoreData" runat="server" BackColor="#FFFFCC" BorderStyle="Solid" CssClass="auto-style77">
                <asp:Label ID="Label4" runat="server" CssClass="auto-style23" Text="Date / Time :"></asp:Label>
                <asp:TextBox ID="tbDateTime" runat="server" CssClass="auto-style24"></asp:TextBox>
                <asp:Label ID="lblObserver" runat="server" CssClass="lblObserver" Style="z-index: 1; position: absolute; top: 41px; left: 22px; right: 1192px;" Text="Observer :"></asp:Label>
                <asp:DropDownList ID="ddlUser" runat="server" AutoPostBack="True" CssClass="auto-style9" DataSourceID="ObsSafety_Users" DataTextField="Name" DataValueField="UID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ObsSafety_Users" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT UID, LastName + ',' + FirstName AS 'Name' FROM Users WHERE (Plant = @intPlantID) ORDER BY LastName">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddl_PlantQuery" Name="intPlantID" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label5" runat="server" CssClass="auto-style60" Text="Employee Shift :"></asp:Label>
                <asp:Label ID="Label8" runat="server" CssClass="auto-style67" Text="Employee Position :"></asp:Label>
                <asp:DropDownList ID="ddlMachine" runat="server" AutoPostBack="True" CssClass="auto-style15" DataSourceID="ObsSafety_MachineQuery" DataTextField="Description" DataValueField="UID">
                </asp:DropDownList>
                <asp:Label ID="Label6" runat="server" CssClass="auto-style61" Text="Employee Type :"></asp:Label>
                <asp:DropDownList ID="ddl_EmpType" runat="server" AutoPostBack="True" CssClass="auto-style65" DataSourceID="EmpType_Query" DataTextField="Value" DataValueField="UID" Height="20px">
                </asp:DropDownList>
                <asp:DropDownList ID="ddl_EmpPosition" runat="server" AutoPostBack="True" CssClass="auto-style68" DataSourceID="OrgLvlQuery" DataTextField="DESC" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlDepartment" runat="server" AutoPostBack="True" CssClass="auto-style12" DataSourceID="OBSSafetyData" DataTextField="Desc" DataValueField="UID" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Label ID="lblDepartment" runat="server" CssClass="auto-style13" Text="Department :"></asp:Label>
                <asp:DropDownList ID="ddl_EmpShift" runat="server" AutoPostBack="True" CssClass="auto-style62" Height="25px" DataSourceID="ShiftQuery" DataTextField="Value" DataValueField="UID">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="ShiftQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblShifts]"></asp:SqlDataSource>
                <asp:Label ID="lblMachine" runat="server" CssClass="auto-style14" Text="Machine :"></asp:Label>
            </asp:Panel>
        <div>
            <asp:SqlDataSource ID="FG_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="FG_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="PaceStatus" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="PaceCondition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="Lof_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="LOF_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="EOP_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="EOP_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="OBSSafetyData" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblDepartments]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="ObsSafety_MachineQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblMachine] WHERE ([DeptID] = @DeptID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlDepartment" Name="DeptID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="EmpType_Query" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [dbo].[tblEmpType]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="OrgLvlQuery" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT *  FROM [dbo].[tblORG_LVL]"></asp:SqlDataSource>
            <asp:Panel ID="pnlComp" runat="server" BackColor="#FF6600" CssClass="auto-style87" BorderStyle="Solid">
                <asp:Label ID="lblCompHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Comprehension"></asp:Label>
                <asp:DropDownList ID="ddl_CompStatus" runat="server" CssClass="auto-style41" DataSourceID="Comp_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Comp_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblCompCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_CompCondition" runat="server" CssClass="auto-style22" DataSourceID="Comp_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Comp_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblComp_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbComp_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblComp_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbComp_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblCompStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlConfA" runat="server" BackColor="#FF6600" CssClass="auto-style90" BorderStyle="Solid">
                <asp:Label ID="lblConfAHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Confined Area"></asp:Label>
                <asp:DropDownList ID="ddl_ConfAStatus" runat="server" CssClass="auto-style41" DataSourceID="ConfA_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ConfA_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblConfACondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_ConfACondition" runat="server" CssClass="auto-style22" DataSourceID="ConfA_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ConfA_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblConfA_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbConfA_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblConfA_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbConfA_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblConfAStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlExt" runat="server" BackColor="#FF6600" CssClass="auto-style84" BorderStyle="Solid">
                <asp:Label ID="lblEOPHeader0" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Extension "></asp:Label>
                <asp:DropDownList ID="ddl_ExtStatus" runat="server" CssClass="auto-style41" DataSourceID="Ext_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="Ext_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblEOPCondition1" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_ExtCondition" runat="server" CssClass="auto-style22" DataSourceID="Ext_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="Ext_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblEOP_ObserverComment1" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbExt_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOP_EmpComment1" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbExt_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOPStatus1" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlRep" runat="server" BackColor="#FF6600" CssClass="auto-style85" BorderStyle="Solid">
                <asp:Label ID="lblRepHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Repetition"></asp:Label>
                <asp:DropDownList ID="ddl_RepStatus" runat="server" CssClass="auto-style41" DataSourceID="Rep_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="Rep_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblEOPCondition2" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_RepCondition" runat="server" CssClass="auto-style22" DataSourceID="Rep_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="Rep_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblEOP_ObserverComment2" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbRep_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOP_EmpComment2" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbRep_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblEOPStatus2" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlPP" runat="server" BackColor="#FF6600" CssClass="auto-style86" BorderStyle="Solid">
                <asp:Label ID="lblppHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Pinch Points"></asp:Label>
                <asp:DropDownList ID="ddl_PPStatus" runat="server" CssClass="auto-style41" DataSourceID="PP_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="PP_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblPPCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PPCondition" runat="server" CssClass="auto-style22" DataSourceID="PP_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>

                <asp:SqlDataSource ID="PP_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblpp_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbPP_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPP_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbPP_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPStatus" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlFoo" runat="server" BackColor="#FF6600" CssClass="auto-style88" BorderStyle="Solid">
                <asp:Label ID="lblFooHeader" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Footing"></asp:Label>
                <asp:DropDownList ID="ddl_FooStatus" runat="server" CssClass="auto-style41" DataSourceID="Foo_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Foo_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblFooCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_FooCondition" runat="server" CssClass="auto-style22" DataSourceID="Foo_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Foo_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblFoo_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbFoo_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFoo_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbFoo_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFooStatus" runat="server" CssClass="auto-style33" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlCoor" runat="server" BackColor="#FF6600" CssClass="auto-style92" BorderStyle="Solid">
                <asp:Label ID="lblCoorHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Coordination"></asp:Label>
                <asp:DropDownList ID="ddl_CoorStatus" runat="server" CssClass="auto-style41" DataSourceID="Coor_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Coor_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblCoorCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_CoorCondition" runat="server" CssClass="auto-style22" DataSourceID="Coor_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Coor_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblCoor_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbCoor_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblCoor_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbCoor_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblCoorStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlID" runat="server" BackColor="#FF6600" CssClass="auto-style93" BorderStyle="Solid">
                <asp:Label ID="lblIDHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Identification"></asp:Label>
                <asp:DropDownList ID="ddl_IDStatus" runat="server" CssClass="auto-style41" DataSourceID="ID_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ID_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblIDCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_IDCondition" runat="server" CssClass="auto-style22" DataSourceID="ID_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ID_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblID_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbID_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblID_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbID_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblIDStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlClean" runat="server" BackColor="#FF6600" CssClass="auto-style94" BorderStyle="Solid">
                <asp:Label ID="lblCleanHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Cleanlieness"></asp:Label>
                <asp:DropDownList ID="ddl_CleanStatus" runat="server" CssClass="auto-style41" DataSourceID="Clean_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Clean_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblCleanCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_CleanCondition" runat="server" CssClass="auto-style22" DataSourceID="Clean_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Clean_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblClean_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbClean_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblClean_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbClean_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblCleanStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl5S" runat="server" BackColor="#FF6600" CssClass="auto-style96" BorderStyle="Solid">
                <asp:Label ID="lbl5SHeader0" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="5S"></asp:Label>
                <asp:DropDownList ID="ddl_5SStatus" runat="server" CssClass="auto-style41" DataSourceID="s5S_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="s5S_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lbl5SCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_5SCondition" runat="server" CssClass="auto-style22" DataSourceID="s5S_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="s5S_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lbl5S_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tb5S_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lbl5S_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tb5S_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lbl5SStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlTC" runat="server" BackColor="#FF6600" CssClass="auto-style95" BorderStyle="Solid">
                <asp:Label ID="lblTCHeader1" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Tools Condition"></asp:Label>
                <asp:DropDownList ID="ddl_TCStatus" runat="server" CssClass="auto-style41" DataSourceID="TC_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TC_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblTCCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_TCCondition" runat="server" CssClass="auto-style22" DataSourceID="TC_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TC_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblTC_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbTC_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTC_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbTC_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTCStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlTU" runat="server" BackColor="#FF6600" CssClass="auto-style97" BorderStyle="Solid">
                <asp:Label ID="lblTUHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Tools Use"></asp:Label>
                <asp:DropDownList ID="ddl_TUStatus" runat="server" CssClass="auto-style41" DataSourceID="TU_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TU_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblTUCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_TUCondition" runat="server" CssClass="auto-style22" DataSourceID="TU_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TU_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblTU_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbTU_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTU_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbTU_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTUStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlTI" runat="server" BackColor="#FF6600" CssClass="auto-style98" BorderStyle="Solid">
                <asp:Label ID="lblTIHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Tools Inspection"></asp:Label>
                <asp:DropDownList ID="ddl_TIStatus" runat="server" CssClass="auto-style41" DataSourceID="TI_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TI_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblTICondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_TICondition" runat="server" CssClass="auto-style22" DataSourceID="TI_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="TI_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblTI_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbTI_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTI_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbTI_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblTIStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlFKL" runat="server" BackColor="#FF6600" CssClass="auto-style99" BorderStyle="Solid">
                <asp:Label ID="lblFKLHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="Fork Lifts"></asp:Label>
                <asp:DropDownList ID="ddl_FKLStatus" runat="server" CssClass="auto-style41" DataSourceID="FKL_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="FKL_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblFKLCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_FKLCondition" runat="server" CssClass="auto-style22" DataSourceID="FKL_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="FKL_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblFKL_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbFKL_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFKL_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbFKL_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblFKLStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlPPE_S" runat="server" BackColor="#FF6600" CssClass="auto-style100" BorderStyle="Solid">
                <asp:Label ID="lblPPE_SHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="PPE Selections"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_SStatus" runat="server" CssClass="auto-style41" DataSourceID="PPE_S_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_S_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_SCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_SCondition" runat="server" CssClass="auto-style22" DataSourceID="PPE_S_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_S_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_S_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_S_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_S_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_S_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_SStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlPPE_U" runat="server" BackColor="#FF6600" CssClass="auto-style101" BorderStyle="Solid">
                <asp:Label ID="lblPPE_UHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="PPE Usage"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_UStatus" runat="server" CssClass="auto-style41" DataSourceID="PPE_U_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_U_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_UCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_UCondition" runat="server" CssClass="auto-style22" DataSourceID="PPE_U_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_U_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_U_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_U_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_U_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_U_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_UStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlPPE_C" runat="server" BackColor="#FF6600" CssClass="auto-style102" BorderStyle="Solid">
                <asp:Label ID="lblPPE_CHeader" runat="server" CssClass="auto-style91" Font-Bold="True" Font-Size="XX-Large" Text="PPE Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_CStatus" runat="server" CssClass="auto-style41" DataSourceID="PPE_C_Status" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_C_Status" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox1_SafeConcern]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_CCondition" runat="server" CssClass="auto-style21" Text="Condition"></asp:Label>
                <asp:DropDownList ID="ddl_PPE_CCondition" runat="server" CssClass="auto-style22" DataSourceID="PPE_C_Condition" DataTextField="Value" DataValueField="UID" Height="25px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="PPE_C_Condition" runat="server" ConnectionString="<%$ ConnectionStrings:OBSSafetyConnectionString %>" SelectCommand="SELECT * FROM [tblListBox2_HabitBarrier]"></asp:SqlDataSource>

                <asp:Label ID="lblPPE_C_ObserverComment" runat="server" CssClass="auto-style45" Text="Observer Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_C_ObservComment" runat="server" CssClass="auto-style42" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_C_EmpComment" runat="server" CssClass="auto-style44" Text="Employee Comment :"></asp:Label>
                <asp:TextBox ID="tbPPE_C_EmpComment" runat="server" CssClass="auto-style43" Height="40px" Width="740px"></asp:TextBox>
                <asp:Label ID="lblPPE_CStatus" runat="server" CssClass="auto-style89" Text="Status"></asp:Label>
            </asp:Panel>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style103" NavigateUrl="~/DataManagement.aspx">Go Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
