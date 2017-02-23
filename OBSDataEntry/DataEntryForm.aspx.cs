using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class DataEntryForm : System.Web.UI.Page
{
    // Based on Current Standards There are Approx 20 Precaution Elements. Max Selected Per Plant at one time = 5
    // So we have to Format the 5 objects to be on the SCreen at the Appropriate Slots
    // First we need to Understand What objects are Choosen to report on to be able to Format / Display the 5 Panels on the Screen Correctly
    // See Comments on Side For Abbreviation Description
    static int intPlant;
    static int pnlCount;
    static bool FG;     // Force Grip
    static bool ALI;    // Alignment
    static bool Ext;    // Extension
    static bool Rep;    // Repetition
    static bool PC;     // Pace
    static bool LOF;    // Line of Fire
    static bool PP;     // Pinch Points
    static bool Eop;    // Eyes on Path Task
    static bool Foo;    // Footing
    static bool ConfA;  // Confined Area
    static bool Comp;   // Comprehension
    static bool Coor;   //Coordination
    static bool ID;     // identification
    static bool Clean;  // Cleanlieness
    static bool s5S;    // 5S
    static bool TC;     // Tool Choice
    static bool TU;     // Tool Usage
    static bool TI;     // Tool Inspection
    static bool FKL;    // Forklifts
    static bool PPE_S;  // Proper Protective Equipment Selection
    static bool PPE_U;  // Proper Protective Equipment Usage
    static bool PPE_C;  // Proper Protective Equipment Condition
    public static string[] Activepanel = new string[5];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //public string[] Activepanel = new string[5];
            //Clear Text boxes
            tbFG_ObservComment.Text = "";
            tbFG_EmpComment.Text = "";
            tbAlign_ObservComment.Text = "";
            tbAlign_EmpComment.Text = "";
            tbExt_ObservComment.Text = "";
            tbExt_EmpComment.Text = "";
            tbRep_ObservComment.Text = "";
            tbRep_EmpComment.Text = "";
            tbPace_ObservComment.Text = "";
            tbPace_EmpComment.Text = "";
            tbLOF_ObservComment.Text = "";
            tbLOF_EmpComment.Text = "";
            tbPP_ObservComment.Text = "";
            tbPP_EmpComment.Text = "";
            tbEOP_ObservComment.Text = "";
            tbEOP_EmpComment.Text = "";
            tbFoo_ObservComment.Text = "";
            tbFoo_EmpComment.Text = "";
            tbConfA_ObservComment.Text = "";
            tbConfA_EmpComment.Text = "";
            tbComp_ObservComment.Text = "";
            tbComp_EmpComment.Text = "";
            tbCoor_ObservComment.Text = "";
            tbCoor_EmpComment.Text = "";
            tbID_ObservComment.Text = "";
            tbID_EmpComment.Text = "";
            tbClean_ObservComment.Text = "";
            tbClean_EmpComment.Text = "";
            tb5S_ObservComment.Text = "";
            tb5S_EmpComment.Text = "";
            tbTC_ObservComment.Text = "";
            tbTC_EmpComment.Text = "";
            tbTU_ObservComment.Text = "";
            tbTU_EmpComment.Text = "";
            tbTI_ObservComment.Text = "";
            tbTI_EmpComment.Text = "";
            tbFKL_ObservComment.Text = "";
            tbFKL_EmpComment.Text = "";
            tbPPE_S_ObservComment.Text = "";
            tbPPE_S_EmpComment.Text = "";
            tbPPE_U_ObservComment.Text = "";
            tbPPE_U_EmpComment.Text = "";
            tbPPE_C_ObservComment.Text = "";
            tbPPE_C_EmpComment.Text = "";

            //Fill out the Timestamp on the Page
            DateTime todayDate = DateTime.Now;
            tbDateTime.Text = Convert.ToString(todayDate);
            tbDateTime.Enabled = false;
            tb_SqlResults.Text = "";
            tb_SqlResults.Visible = false;

            // On First Pass Set the Item on the Screen to Disabled and Not Visable to be sure
            pnlObsCoreData.Enabled = false;
            pnlForceGrip.Visible = false;
            pnlAlignment.Visible = false;
            pnlExt.Visible = false;
            pnlRep.Visible = false;
            pnlPace.Visible = false;
            pnlLineOfFire.Visible = false;
            pnlPP.Visible = false;
            pnlEopT.Visible = false;
            pnlFoo.Visible = false;
            pnlConfA.Visible = false;
            pnlComp.Visible = false;
            pnlCoor.Visible = false;
            pnlID.Visible = false;
            pnlClean.Visible = false;
            pnl5S.Visible = false;
            pnlTC.Visible = false;
            pnlTU.Visible = false;
            pnlTI.Visible = false;
            pnlFKL.Visible = false;
            pnlPPE_S.Visible = false;
            pnlPPE_U.Visible = false;
            pnlPPE_C.Visible = false;

        }
    }
    protected void btnClearForm_Click(object sender, EventArgs e)
    {
        //Clear Text boxes
        tbFG_ObservComment.Text = "";
        tbFG_EmpComment.Text = "";
        tbAlign_ObservComment.Text = "";
        tbAlign_EmpComment.Text = "";
        tbExt_ObservComment.Text = "";
        tbExt_EmpComment.Text = "";
        tbRep_ObservComment.Text = "";
        tbRep_EmpComment.Text = "";
        tbPace_ObservComment.Text = "";
        tbPace_EmpComment.Text = "";
        tbLOF_ObservComment.Text = "";
        tbLOF_EmpComment.Text = "";
        tbPP_ObservComment.Text = "";
        tbPP_EmpComment.Text = "";
        tbEOP_ObservComment.Text = "";
        tbEOP_EmpComment.Text = "";
        tbFoo_ObservComment.Text = "";
        tbFoo_EmpComment.Text = "";
        tbConfA_ObservComment.Text = "";
        tbConfA_EmpComment.Text = "";
        tbComp_ObservComment.Text = "";
        tbComp_EmpComment.Text = "";
        tbCoor_ObservComment.Text = "";
        tbCoor_EmpComment.Text = "";
        tbID_ObservComment.Text = "";
        tbID_EmpComment.Text = "";
        tbClean_ObservComment.Text = "";
        tbClean_EmpComment.Text = "";
        tb5S_ObservComment.Text = "";
        tb5S_EmpComment.Text = "";
        tbTC_ObservComment.Text = "";
        tbTC_EmpComment.Text = "";
        tbTU_ObservComment.Text = "";
        tbTU_EmpComment.Text = "";
        tbTI_ObservComment.Text = "";
        tbTI_EmpComment.Text = "";
        tbFKL_ObservComment.Text = "";
        tbFKL_EmpComment.Text = "";
        tbPPE_S_ObservComment.Text = "";
        tbPPE_S_EmpComment.Text = "";
        tbPPE_U_ObservComment.Text = "";
        tbPPE_U_EmpComment.Text = "";
        tbPPE_C_ObservComment.Text = "";
        tbPPE_C_EmpComment.Text = "";

        //Set the Plant Query back to initial
        ddl_PlantQuery.SelectedIndex = 0;
        ddl_PlantQuery.DataBind();

        //Clear the Screen Objects As Requested
        pnlObsCoreData.Enabled = false;
        pnlForceGrip.Visible = false;
        pnlAlignment.Visible = false;
        pnlExt.Visible = false;
        pnlRep.Visible = false;
        pnlPace.Visible = false;
        pnlLineOfFire.Visible = false;
        pnlPP.Visible = false;
        pnlEopT.Visible = false;
        pnlFoo.Visible = false;
        pnlConfA.Visible = false;
        pnlComp.Visible = false;
        pnlCoor.Visible = false;
        pnlID.Visible = false;
        pnlClean.Visible = false;
        pnl5S.Visible = false;
        pnlTC.Visible = false;
        pnlTU.Visible = false;
        pnlTI.Visible = false;
        pnlFKL.Visible = false;
        pnlPPE_S.Visible = false;
        pnlPPE_U.Visible = false;
        pnlPPE_C.Visible = false;

        // Refresh Drop down list boxes
        ddlUser.DataBind();
        ddlDepartment.DataBind();
        ddlMachine.DataBind();
        ddl_EmpShift.DataBind();
        ddl_EmpPosition.DataBind();
        ddl_FGStatus.DataBind();
        ddl_FGCondition.DataBind();
        ddl_AlignStatus.DataBind();
        ddl_AlignCondition.DataBind();
        ddl_ExtStatus.DataBind();
        ddl_ExtCondition.DataBind();
        ddl_RepStatus.DataBind();
        ddl_RepCondition.DataBind();
        ddl_PaceStatus.DataBind();
        ddl_PaceCondition.DataBind();
        ddl_LOFStatus.DataBind();
        ddl_LOFCondition.DataBind();
        ddl_PPStatus.DataBind();
        ddl_PPCondition.DataBind();
        ddl_EOPStatus.DataBind();
        ddl_EOPCondition.DataBind();
        ddl_FooStatus.DataBind();
        ddl_FooCondition.DataBind();
        ddl_ConfAStatus.DataBind();
        ddl_ConfACondition.DataBind();
        ddl_CompStatus.DataBind();
        ddl_CompCondition.DataBind();
        ddl_CoorStatus.DataBind();
        ddl_CoorCondition.DataBind();
        ddl_IDStatus.DataBind();
        ddl_IDCondition.DataBind();
        ddl_CleanStatus.DataBind();
        ddl_CleanCondition.DataBind();
        ddl_5SStatus.DataBind();
        ddl_5SCondition.DataBind();
        ddl_TCStatus.DataBind();
        ddl_TCCondition.DataBind();
        ddl_TUStatus.DataBind();
        ddl_TUCondition.DataBind();
        ddl_TIStatus.DataBind();
        ddl_TICondition.DataBind();
        ddl_FKLStatus.DataBind();
        ddl_FKLCondition.DataBind();
        ddl_PPE_SStatus.DataBind();
        ddl_PPE_SCondition.DataBind();
        ddl_PPE_UStatus.DataBind();
        ddl_PPE_UCondition.DataBind();
        ddl_PPE_CStatus.DataBind();
        ddl_PPE_CCondition.DataBind();

        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;
    }
    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlMachine.DataBind();
    }
    protected void btnSaveForm_Click(object sender, EventArgs e)
    {
        // Evaluate the Inputs to Insure the user has selected all Necessary data points
        bool sum = false;
        bool userValid = false;
        bool machValid = false;
        bool fgStat = false;
        bool fgCon = false;
        bool fgObsComm = false;
        bool fgEmpComm = false;
        bool fgConcern = false;
        bool AliStat = false;
        bool AliCon = false;
        bool AliObsComm = false;
        bool ALiEmpComm = false;
        bool AliConcern = false;
        bool ExtStat = false;
        bool ExtCon = false;
        bool ExtObsComm = false;
        bool ExtEmpComm = false;
        bool ExtConcern = false;
        bool RepStat = false;
        bool RepCon = false;
        bool RepObsComm = false;
        bool RepEmpComm = false;
        bool RepConcern = false;
        bool PaceStat = false;
        bool PaceCon = false;
        bool PaceObsComm = false;
        bool PaceEmpComm = false;
        bool PaceConcern = false;
        bool LofStat = false;
        bool LofCon = false;
        bool LofObsComm = false;
        bool LofEmpComm = false;
        bool LofConcern = false;
        bool PPStat = false;
        bool PPCon = false;
        bool PPObsComm = false;
        bool PPEmpComm = false;
        bool PPConcern = false;
        bool EopStat = false;
        bool EopCon = false;
        bool EopObsComm = false;
        bool EopEmpComm = false;
        bool EopConcern = false;
        bool FooStat = false;
        bool FooCon = false;
        bool FooObsComm = false;
        bool FooEmpComm = false;
        bool FooConcern = false;
        bool ConfAStat = false;
        bool ConfACon = false;
        bool ConfAObsComm = false;
        bool ConfAEmpComm = false;
        bool ConfAConcern = false;
        bool CompStat = false;
        bool CompCon = false;
        bool CompObsComm = false;
        bool CompEmpComm = false;
        bool CompConcern = false;
        bool CoorStat = false;
        bool CoorCon = false;
        bool CoorObsComm = false;
        bool CoorEmpComm = false;
        bool CoorConcern = false;
        bool IDStat = false;
        bool IDCon = false;
        bool IDObsComm = false;
        bool IDEmpComm = false;
        bool IDConcern = false;
        bool CleanStat = false;
        bool CleanCon = false;
        bool CleanObsComm = false;
        bool CleanEmpComm = false;
        bool CleanConcern = false;
        bool s5SStat = false;
        bool s5SCon = false;
        bool s5SObsComm = false;
        bool s5SEmpComm = false;
        bool s5SConcern = false;
        bool TCStat = false;
        bool TCCon = false;
        bool TCObsComm = false;
        bool TCEmpComm = false;
        bool TCConcern = false;
        bool TUStat = false;
        bool TUCon = false;
        bool TUObsComm = false;
        bool TUEmpComm = false;
        bool TUConcern = false;
        bool TIStat = false;
        bool TICon = false;
        bool TIObsComm = false;
        bool TIEmpComm = false;
        bool TIConcern = false;
        bool FKLStat = false;
        bool FKLCon = false;
        bool FKLObsComm = false;
        bool FKLEmpComm = false;
        bool FKLConcern = false;
        bool PPE_SStat = false;
        bool PPE_SCon = false;
        bool PPE_SObsComm = false;
        bool PPE_SEmpComm = false;
        bool PPE_SConcern = false;
        bool PPE_UStat = false;
        bool PPE_UCon = false;
        bool PPE_UObsComm = false;
        bool PPE_UEmpComm = false;
        bool PPE_UConcern = false;
        bool PPE_CStat = false;
        bool PPE_CCon = false;
        bool PPE_CObsComm = false;
        bool PPE_CEmpComm = false;
        bool PPE_CConcern = false;

        string missingmessage = "";
        string PreCauName = "";
        tb_SqlResults.Text = missingmessage;
        tb_SqlResults.Visible = true;

        userValid = (Convert.ToInt32(ddlUser.SelectedValue) > 0);
        machValid = (Convert.ToInt32(ddlMachine.SelectedValue) > 0);
        sum = (userValid & machValid);

        // Query through ActivePanel Object to determine which Panels Are Active on This Screen to Determine Validation
        for (int i = 0; i < pnlCount; i++)
        {
            switch (Activepanel[i])
            {
                case "FG":
                    fgStat = (Convert.ToInt32(ddl_FGStatus.SelectedValue) > 1);
                    fgCon = (Convert.ToInt32(ddl_FGCondition.SelectedValue) > 1);
                    fgObsComm = ((tbFG_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_FGStatus.SelectedValue) == 2);
                    fgEmpComm = ((tbFG_EmpComment.Text).Length > 0);
                    fgConcern = (Convert.ToInt32(ddl_FGStatus.SelectedValue) == 3 & fgObsComm & fgEmpComm)|((Convert.ToInt32(ddl_FGStatus.SelectedValue) < 3));
                    sum = sum & (fgStat & fgCon & fgObsComm & fgConcern);
                    break;
                case "ALI":
                    AliStat = (Convert.ToInt32(ddl_AlignStatus.SelectedValue) > 1);
                    AliCon = (Convert.ToInt32(ddl_AlignCondition.SelectedValue) > 1);
                    AliObsComm = ((tbAlign_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_AlignStatus.SelectedValue) == 2);
                    ALiEmpComm = ((tbAlign_EmpComment.Text).Length > 0);
                    AliConcern = (Convert.ToInt32(ddl_AlignStatus.SelectedValue) == 3 & AliObsComm & ALiEmpComm) | ((Convert.ToInt32(ddl_AlignStatus.SelectedValue) < 3));
                    sum = sum & (AliStat & AliCon & AliObsComm & AliConcern);
                    break;
                case "Ext":
                    ExtStat = (Convert.ToInt32(ddl_ExtStatus.SelectedValue) > 1);
                    ExtCon = (Convert.ToInt32(ddl_ExtCondition.SelectedValue) > 1);
                    ExtObsComm = ((tbExt_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_ExtStatus.SelectedValue) == 2);
                    ExtEmpComm = ((tbExt_EmpComment.Text).Length > 0);
                    ExtConcern = (Convert.ToInt32(ddl_ExtStatus.SelectedValue) == 3 & ExtObsComm & ExtEmpComm) | ((Convert.ToInt32(ddl_ExtStatus.SelectedValue) < 3));
                    sum = sum & (ExtStat & ExtCon & ExtObsComm & ExtConcern);
                    break;
                case "Rep":
                    RepStat = (Convert.ToInt32(ddl_RepStatus.SelectedValue) > 1);
                    RepCon = (Convert.ToInt32(ddl_RepCondition.SelectedValue) > 1);
                    RepObsComm = ((tbRep_ObservComment.Text).Length > 0);| (Convert.ToInt32(ddl_RepStatus.SelectedValue) == 2);
                    RepEmpComm = ((tbRep_EmpComment.Text).Length > 0);
                    RepConcern = (Convert.ToInt32(ddl_RepStatus.SelectedValue) == 3 & RepObsComm & RepEmpComm) | ((Convert.ToInt32(ddl_RepStatus.SelectedValue) < 3));
                    sum = sum & (RepStat & RepCon & RepObsComm & RepConcern);
                    break;
                case "PC":
                    PaceStat = (Convert.ToInt32(ddl_PaceStatus.SelectedValue) > 1);
                    PaceCon = (Convert.ToInt32(ddl_PaceCondition.SelectedValue) > 1);
                    PaceObsComm = ((tbPace_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_PaceStatus.SelectedValue) == 2);
                    PaceEmpComm = ((tbPace_EmpComment.Text).Length > 0);
                    RepConcern = (Convert.ToInt32(ddl_PaceStatus.SelectedValue) == 3 & PaceObsComm & PaceEmpComm) | ((Convert.ToInt32(ddl_PaceStatus.SelectedValue) < 3));
                    sum = sum & (PaceStat & PaceCon & PaceObsComm & RepConcern);
                    break;
                case "LOF":
                    LofStat = (Convert.ToInt32(ddl_LOFStatus.SelectedValue) > 1);
                    LofCon = (Convert.ToInt32(ddl_LOFCondition.SelectedValue) > 1);
                    LofObsComm = ((tbLOF_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_LOFStatus.SelectedValue) == 2);
                    LofEmpComm = ((tbLOF_EmpComment.Text).Length > 0);
                    LofConcern = (Convert.ToInt32(ddl_LOFStatus.SelectedValue) == 3 & LofObsComm & LofEmpComm) | ((Convert.ToInt32(ddl_LOFStatus.SelectedValue) < 3));
                    sum = sum & (LofStat & LofCon & LofObsComm & LofConcern);
                    break;
                case "PP":
                    PPStat = (Convert.ToInt32(ddl_PPStatus.SelectedValue) > 1);
                    PPCon = (Convert.ToInt32(ddl_PPCondition.SelectedValue) > 1);
                    PPObsComm = ((tbPP_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_PPStatus.SelectedValue) == 2);
                    PPEmpComm = ((tbPP_EmpComment.Text).Length > 0);
                    PPConcern = (Convert.ToInt32(ddl_PPStatus.SelectedValue) == 3 & PPObsComm & PPEmpComm) | ((Convert.ToInt32(ddl_PPStatus.SelectedValue) < 3));
                    sum = sum & (PPStat & PPCon & PPObsComm);
                    break;
                case "Eop":
                    EopStat = (Convert.ToInt32(ddl_EOPStatus.SelectedValue) > 1);
                    EopCon = (Convert.ToInt32(ddl_EOPCondition.SelectedValue) > 1);
                    EopObsComm = ((tbEOP_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_EOPStatus.SelectedValue) == 2);
                    EopEmpComm = ((tbEOP_EmpComment.Text).Length > 0);
                    EopConcern = (Convert.ToInt32(ddl_EOPStatus.SelectedValue) == 3 & EopObsComm & EopEmpComm) | ((Convert.ToInt32(ddl_EOPStatus.SelectedValue) < 3));
                    sum = sum & (EopStat & EopCon & EopObsComm & EopConcern);
                    break;
                case "Foo":
                    FooStat = (Convert.ToInt32(ddl_FooStatus.SelectedValue) > 1);
                    FooCon = (Convert.ToInt32(ddl_FooCondition.SelectedValue) > 1);
                    FooObsComm = ((tbFoo_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_FooStatus.SelectedValue) == 2);
                    FooEmpComm = ((tbFoo_EmpComment.Text).Length > 0);
                    FooConcern = (Convert.ToInt32(ddl_FooStatus.SelectedValue) == 3 & FooObsComm & FooEmpComm) | ((Convert.ToInt32(ddl_FooStatus.SelectedValue) < 3));
                    sum = sum & (FooStat & FooCon & FooObsComm & FooConcern);
                    break;
                case "ConfA":
                    ConfAStat = (Convert.ToInt32(ddl_ConfAStatus.SelectedValue) > 1);
                    ConfACon = (Convert.ToInt32(ddl_ConfACondition.SelectedValue) > 1);
                    ConfAObsComm = ((tbConfA_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_ConfAStatus.SelectedValue) == 2);
                    ConfAEmpComm = ((tbConfA_EmpComment.Text).Length > 0);
                    ConfAConcern = (Convert.ToInt32(ddl_ConfAStatus.SelectedValue) == 3 & ConfAObsComm & ConfAEmpComm) | ((Convert.ToInt32(ddl_ConfAStatus.SelectedValue) < 3));
                    sum = sum & (ConfAStat & ConfACon & ConfAObsComm & ConfAConcern);
                    break;
                case "Comp":
                    CompStat = (Convert.ToInt32(ddl_CompStatus.SelectedValue) > 1);
                    CompCon = (Convert.ToInt32(ddl_CompCondition.SelectedValue) > 1);
                    CompObsComm = ((tbComp_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_CompStatus.SelectedValue) == 2);
                    CompEmpComm = ((tbComp_EmpComment.Text).Length > 0);
                    CompConcern = (Convert.ToInt32(ddl_CompStatus.SelectedValue) == 3 & CompObsComm & CompEmpComm) | ((Convert.ToInt32(ddl_CompStatus.SelectedValue) < 3));
                    sum = sum & (CompStat & CompCon & CompObsComm & CompConcern);
                    break;
                case "Coor":
                    CoorStat = (Convert.ToInt32(ddl_CoorStatus.SelectedValue) > 1);
                    CoorCon = (Convert.ToInt32(ddl_CoorCondition.SelectedValue) > 1);
                    CoorObsComm = ((tbCoor_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_CoorStatus.SelectedValue) == 2);
                    CoorEmpComm = ((tbCoor_EmpComment.Text).Length > 0);
                    CoorConcern = (Convert.ToInt32(ddl_CoorStatus.SelectedValue) == 3 & CoorObsComm & CoorEmpComm) | ((Convert.ToInt32(ddl_CoorStatus.SelectedValue) < 3));
                    sum = sum & (CoorStat & CoorCon & CoorObsComm & CoorConcern);
                    break;
                case "ID":
                    IDStat = (Convert.ToInt32(ddl_IDStatus.SelectedValue) > 1);
                    IDCon = (Convert.ToInt32(ddl_IDCondition.SelectedValue) > 1);
                    IDObsComm = ((tbID_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_IDStatus.SelectedValue) == 2);
                    IDEmpComm = ((tbID_EmpComment.Text).Length > 0);
                    IDConcern = (Convert.ToInt32(ddl_IDStatus.SelectedValue) == 3 & IDObsComm & IDEmpComm) | ((Convert.ToInt32(ddl_IDStatus.SelectedValue) < 3));
                    sum = sum & (IDStat & IDCon & IDObsComm & IDConcern);
                    break;
                case "Clean":
                    CleanStat = (Convert.ToInt32(ddl_CleanStatus.SelectedValue) > 1);
                    CleanCon = (Convert.ToInt32(ddl_CleanCondition.SelectedValue) > 1);
                    CleanObsComm = ((tbClean_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_CleanStatus.SelectedValue) == 2);
                    CleanEmpComm = ((tbClean_EmpComment.Text).Length > 0);
                    CleanConcern = (Convert.ToInt32(ddl_CleanStatus.SelectedValue) == 3 & CleanObsComm & CleanEmpComm) | ((Convert.ToInt32(ddl_CleanStatus.SelectedValue) < 3));
                    sum = sum & (CleanStat & CleanCon & CleanObsComm & CleanConcern);
                    break;
                case "s5S":
                    s5SStat = (Convert.ToInt32(ddl_5SStatus.SelectedValue) > 1);
                    s5SCon = (Convert.ToInt32(ddl_5SCondition.SelectedValue) > 1);
                    s5SObsComm = ((tb5S_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_5SStatus.SelectedValue) == 2);
                    s5SEmpComm = ((tb5S_EmpComment.Text).Length > 0);
                    s5SConcern = (Convert.ToInt32(ddl_5SStatus.SelectedValue) == 3 & s5SObsComm & s5SEmpComm) | ((Convert.ToInt32(ddl_5SStatus.SelectedValue) < 3));
                    sum = sum & (s5SStat & s5SCon & s5SObsComm & s5SConcern);
                    break;
                case "TC":
                    TCStat = (Convert.ToInt32(ddl_TCStatus.SelectedValue) > 1);
                    TCCon = (Convert.ToInt32(ddl_TCCondition.SelectedValue) > 1);
                    TCObsComm = ((tbTC_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_TCStatus.SelectedValue) == 2);
                    TCEmpComm = ((tbTC_EmpComment.Text).Length > 0);
                    TCConcern = (Convert.ToInt32(ddl_TCStatus.SelectedValue) == 3 & TCObsComm & TCEmpComm) | ((Convert.ToInt32(ddl_TCStatus.SelectedValue) < 3));
                    sum = sum & (TCStat & TCCon & TCObsComm & TCConcern);
                    break;
                case "TU":
                    TUStat = (Convert.ToInt32(ddl_TUStatus.SelectedValue) > 1);
                    TUCon = (Convert.ToInt32(ddl_TUCondition.SelectedValue) > 1);
                    TUObsComm = ((tbTU_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_TUStatus.SelectedValue) == 2);
                    TUEmpComm = ((tbTU_EmpComment.Text).Length > 0);
                    TUConcern = (Convert.ToInt32(ddl_TUStatus.SelectedValue) == 3 & TUObsComm & TUEmpComm) | ((Convert.ToInt32(ddl_TUStatus.SelectedValue) < 3));
                    sum = sum & (TUStat & TUCon & TUObsComm & TUConcern);
                    break;
                case "TI":
                    TIStat = (Convert.ToInt32(ddl_TIStatus.SelectedValue) > 1);
                    TICon = (Convert.ToInt32(ddl_TICondition.SelectedValue) > 1);
                    TIObsComm = ((tbTI_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_TIStatus.SelectedValue) == 2);
                    TIEmpComm = ((tbTI_EmpComment.Text).Length > 0);
                    TIConcern = (Convert.ToInt32(ddl_TIStatus.SelectedValue) == 3 & TIObsComm & TIEmpComm) | ((Convert.ToInt32(ddl_TIStatus.SelectedValue) < 3));
                    sum = sum & (TIStat & TICon & TIObsComm & TIConcern);
                    break;
                case "FKL":
                    FKLStat = (Convert.ToInt32(ddl_FKLStatus.SelectedValue) > 1);
                    FKLCon = (Convert.ToInt32(ddl_FKLCondition.SelectedValue) > 1);
                    FKLObsComm = ((tbFKL_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_FKLStatus.SelectedValue) == 2);
                    FKLEmpComm = ((tbFKL_EmpComment.Text).Length > 0);
                    FKLConcern = (Convert.ToInt32(ddl_FKLStatus.SelectedValue) == 3 & FKLObsComm & FKLEmpComm) | ((Convert.ToInt32(ddl_FKLStatus.SelectedValue) < 3));
                    sum = sum & (FKLStat & FKLCon & FKLObsComm & FKLConcern);
                    break;
                case "PPE_S":
                    PPE_SStat = (Convert.ToInt32(ddl_PPE_SStatus.SelectedValue) > 1);
                    PPE_SCon = (Convert.ToInt32(ddl_PPE_SCondition.SelectedValue) > 1);
                    PPE_SObsComm = ((tbPPE_S_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_PPE_SStatus.SelectedValue) == 2);
                    PPE_SEmpComm = ((tbPPE_S_EmpComment.Text).Length > 0);
                    PPE_SConcern = (Convert.ToInt32(ddl_PPE_SStatus.SelectedValue) == 3 & PPE_SObsComm & PPE_SEmpComm) | ((Convert.ToInt32(ddl_PPE_SStatus.SelectedValue) < 3));
                    sum = sum & (PPE_SStat & PPE_SCon & PPE_SObsComm & PPE_SConcern);
                    break;
                case "PPE_U":
                    PPE_UStat = (Convert.ToInt32(ddl_PPE_UStatus.SelectedValue) > 1);
                    PPE_UCon = (Convert.ToInt32(ddl_PPE_UCondition.SelectedValue) > 1);
                    PPE_UObsComm = ((tbPPE_U_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_PPE_UStatus.SelectedValue) == 2);
                    PPE_UEmpComm = ((tbPPE_U_EmpComment.Text).Length > 0);
                    PPE_UConcern = (Convert.ToInt32(ddl_PPE_UStatus.SelectedValue) == 3 & PPE_UObsComm & PPE_UEmpComm) | ((Convert.ToInt32(ddl_PPE_UStatus.SelectedValue) < 3));
                    sum = sum & (PPE_UStat & PPE_UCon & PPE_UObsComm & PPE_UConcern);
                    break;
                case "PPE_C":
                    PPE_CStat = (Convert.ToInt32(ddl_PPE_CStatus.SelectedValue) > 1);
                    PPE_CCon = (Convert.ToInt32(ddl_PPE_CCondition.SelectedValue) > 1);
                    PPE_CObsComm = ((tbPPE_C_ObservComment.Text).Length > 0) | (Convert.ToInt32(ddl_PPE_CStatus.SelectedValue) == 2);
                    PPE_CEmpComm = ((tbPPE_C_EmpComment.Text).Length > 0);
                    PPE_CConcern = (Convert.ToInt32(ddl_PPE_CStatus.SelectedValue) == 3 & PPE_CObsComm & PPE_CEmpComm) | ((Convert.ToInt32(ddl_PPE_CStatus.SelectedValue) < 3));
                    sum = sum & (PPE_CStat & PPE_CCon & PPE_CObsComm & PPE_CConcern);
                    break;
                default:
                    break;
            }
        }
        #region FailureMessages
        // If Sum is False Create the Specific Message
        if (!sum)
        {
            if (!userValid)
            {
                missingmessage = "Must Select A Valid User.";
                tb_SqlResults.Text = missingmessage;
                tb_SqlResults.Visible = true;
                return;
            }
            if (!machValid)
            {
                missingmessage = "Must Select A Valid Machine.";
                tb_SqlResults.Text = missingmessage;
                tb_SqlResults.Visible = true;
                return;
            }
            for (int i = 0; i < pnlCount; i++)
            {
                switch (Activepanel[i])
                {
                    case "FG":
                        PreCauName = "Force / Grip";
                        if (!fgStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!fgCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!fgObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!fgConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "ALI":
                        PreCauName = "Alignment";
                        if (!AliStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!AliCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!AliObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!AliConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Ext":
                        PreCauName = "Extension";
                        if (!ExtStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ExtCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ExtObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ExtConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Rep":
                        PreCauName = "Repetition";
                        if (!RepStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!RepCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!RepObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!RepConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "PC":
                        PreCauName = "Pace";
                        if (!PaceStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PaceCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PaceObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PaceConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "LOF":
                        PreCauName = "Line Of Fire";
                        if (!LofStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!LofCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!LofObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!LofConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "PP":
                        PreCauName = "Line Of Fire";
                        if (!PPStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Eop":
                        PreCauName = "Eyes on path/work";
                        if (!EopStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!EopCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!EopObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!EopConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Foo":
                        PreCauName = "Footing";
                        if (!FooStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FooCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FooObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FooConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "ConfA":
                        PreCauName = "Confined Area";
                        if (!ConfAStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ConfACon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ConfAObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!ConfAConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Comp":
                        PreCauName = "Comprehension";
                        if (!CompStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CompCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CompObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CompConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Coor":
                        PreCauName = "Coordination";
                        if (!CoorStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CoorCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CoorObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CoorConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "ID":
                        PreCauName = "Identification";
                        if (!IDStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!IDCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!IDObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!IDConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "Clean":
                        PreCauName = "Cleanliness";
                        if (!CleanStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CleanCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CleanObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!CleanConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "s5S":
                        PreCauName = "5S";
                        if (!s5SStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!s5SCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!s5SObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!s5SConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "TC":
                        PreCauName = "Tool Choice";
                        if (!TCStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TCCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TCObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TCConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "TU":
                        PreCauName = "Tool Usage";
                        if (!TUStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TUCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TUObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TUConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "TI":
                        PreCauName = "Tool Inspection";
                        if (!TIStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TICon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TIObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!TIConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "FKL":
                        PreCauName = "Fork Lift";
                        if (!FKLStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FKLCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FKLObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!FKLConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "PPE_S":
                        PreCauName = "PPE Selection";
                        if (!PPE_SStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_SCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_SObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_SConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "PPE_U":
                        PreCauName = "PPE Usage";
                        if (!PPE_UStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_UCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_UObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_UConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    case "PPE_C":
                        PreCauName = "PPE Condition";
                        if (!PPE_CStat)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Status.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_CCon)
                        {
                            missingmessage = "Must Select A Valid " + PreCauName + " Condition.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_CObsComm)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        if (!PPE_CConcern)
                        {
                            missingmessage = "Must provide some " + PreCauName + " Observer & Employee comments.";
                            tb_SqlResults.Text = missingmessage;
                            tb_SqlResults.Visible = true;
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion FailureMessages

        // Eval sum if True
        if (sum)
        {
            // Create The SqlCommand Structure
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSSafetyConnectionString"].ConnectionString);
            SqlCommand vobjADOCmd = new SqlCommand("uspAddOBS_Data", con);
            vobjADOCmd.CommandType = CommandType.StoredProcedure;
            // Create all the Inputs to the Stored Procedure with non Null Values, Then Run through pnlCount to Find the Actual Values
            /* Add Core Input Variables */
            SqlParameter Plant = vobjADOCmd.Parameters.AddWithValue("@PlantID", intPlant);
            Plant.SqlDbType = SqlDbType.Int;
            Plant.Direction = ParameterDirection.Input;

            SqlParameter IntUser = vobjADOCmd.Parameters.AddWithValue("@IntUser", Convert.ToInt32(ddlUser.SelectedValue));
            IntUser.SqlDbType = SqlDbType.Int;
            IntUser.Direction = ParameterDirection.Input;

            SqlParameter intMachine = vobjADOCmd.Parameters.AddWithValue("@intMachine", ddlMachine.SelectedValue);
            intMachine.SqlDbType = SqlDbType.Int;
            intMachine.Direction = ParameterDirection.Input;

            SqlParameter EmpShift = vobjADOCmd.Parameters.AddWithValue("@EmpShift", ddl_EmpShift.SelectedItem.Text);
            EmpShift.SqlDbType = SqlDbType.VarChar;
            EmpShift.Direction = ParameterDirection.Input;

            SqlParameter EmpType = vobjADOCmd.Parameters.AddWithValue("@EmpType", ddl_EmpType.SelectedValue);
            EmpType.SqlDbType = SqlDbType.Int;
            EmpType.Direction = ParameterDirection.Input;

            SqlParameter EmpOrgLvl = vobjADOCmd.Parameters.AddWithValue("@EmpOrglvl", ddl_EmpPosition.SelectedValue);
            EmpOrgLvl.SqlDbType = SqlDbType.Int;
            EmpOrgLvl.Direction = ParameterDirection.Input;

            //Force Grip Inputs
            SqlParameter FGStatus = vobjADOCmd.Parameters.AddWithValue("@FGStatus", 0);
            FGStatus.SqlDbType = SqlDbType.Int;
            FGStatus.Direction = ParameterDirection.Input;
            SqlParameter FGCondition = vobjADOCmd.Parameters.AddWithValue("@FGCondition", 0);
            FGCondition.SqlDbType = SqlDbType.Int;
            FGCondition.Direction = ParameterDirection.Input;
            SqlParameter FGObsComments = vobjADOCmd.Parameters.AddWithValue("@FGObsComments", "");
            FGObsComments.SqlDbType = SqlDbType.VarChar;
            FGObsComments.Direction = ParameterDirection.Input;
            SqlParameter FGEmpComments = vobjADOCmd.Parameters.AddWithValue("@FGEmpComments", ""); 
            FGEmpComments.SqlDbType = SqlDbType.VarChar;
            FGEmpComments.Direction = ParameterDirection.Input;

            // Alignment Inputs
            SqlParameter AliStatus = vobjADOCmd.Parameters.AddWithValue("@ALIStatus", 0);
            AliStatus.SqlDbType = SqlDbType.Int;
            AliStatus.Direction = ParameterDirection.Input;
            SqlParameter ALICondition = vobjADOCmd.Parameters.AddWithValue("@ALICondition", 0); 
            ALICondition.SqlDbType = SqlDbType.Int;
            ALICondition.Direction = ParameterDirection.Input;
            SqlParameter AliObsComments = vobjADOCmd.Parameters.AddWithValue("@AliObsComments", ""); 
            AliObsComments.SqlDbType = SqlDbType.VarChar;
            AliObsComments.Direction = ParameterDirection.Input;
            SqlParameter AliEmpComments = vobjADOCmd.Parameters.AddWithValue("@AliEmpComments", ""); 
            AliEmpComments.SqlDbType = SqlDbType.VarChar;
            AliEmpComments.Direction = ParameterDirection.Input;

            // Extension Inputs
            SqlParameter ExtStatus = vobjADOCmd.Parameters.AddWithValue("@ExtStatus", 0);
            ExtStatus.SqlDbType = SqlDbType.Int;
            ExtStatus.Direction = ParameterDirection.Input;
            SqlParameter ExtCondition = vobjADOCmd.Parameters.AddWithValue("@ExtCondition", 0);
            ExtCondition.SqlDbType = SqlDbType.Int;
            ExtCondition.Direction = ParameterDirection.Input;
            SqlParameter ExtObsComments = vobjADOCmd.Parameters.AddWithValue("@ExtObsComments", "");
            ExtObsComments.SqlDbType = SqlDbType.VarChar;
            ExtObsComments.Direction = ParameterDirection.Input;
            SqlParameter ExtEmpComments = vobjADOCmd.Parameters.AddWithValue("@ExtEmpComments", ""); 
            ExtEmpComments.SqlDbType = SqlDbType.VarChar;
            ExtEmpComments.Direction = ParameterDirection.Input;

            // Repetition Inputs
            SqlParameter RepStatus = vobjADOCmd.Parameters.AddWithValue("@RepStatus", 0); 
            RepStatus.SqlDbType = SqlDbType.Int;
            RepStatus.Direction = ParameterDirection.Input;
            SqlParameter RepCondition = vobjADOCmd.Parameters.AddWithValue("@RepCondition", 0); 
            RepCondition.SqlDbType = SqlDbType.Int;
            RepCondition.Direction = ParameterDirection.Input;
            SqlParameter RepObsComments = vobjADOCmd.Parameters.AddWithValue("@RepObsComments", ""); 
            RepObsComments.SqlDbType = SqlDbType.VarChar;
            RepObsComments.Direction = ParameterDirection.Input;
            SqlParameter RepEmpComments = vobjADOCmd.Parameters.AddWithValue("@RepEmpComments", ""); 
            RepEmpComments.SqlDbType = SqlDbType.VarChar;
            RepEmpComments.Direction = ParameterDirection.Input;

            //Pace Inputs
            SqlParameter PaceStatus = vobjADOCmd.Parameters.AddWithValue("@PaceStatus", 0);
            PaceStatus.SqlDbType = SqlDbType.Int;
            PaceStatus.Direction = ParameterDirection.Input;
            SqlParameter PaceCondition = vobjADOCmd.Parameters.AddWithValue("@PaceCondition", 0);
            PaceCondition.SqlDbType = SqlDbType.Int;
            PaceCondition.Direction = ParameterDirection.Input;
            SqlParameter PaceObsComments = vobjADOCmd.Parameters.AddWithValue("@PaceObsComments", "");
            PaceObsComments.SqlDbType = SqlDbType.VarChar;
            PaceObsComments.Direction = ParameterDirection.Input;
            SqlParameter PaceEmpComments = vobjADOCmd.Parameters.AddWithValue("@PaceEmpComments", "");
            PaceEmpComments.SqlDbType = SqlDbType.VarChar;
            PaceEmpComments.Direction = ParameterDirection.Input;

            //Line of Fire Inputs
            SqlParameter LOFStatus = vobjADOCmd.Parameters.AddWithValue("@LOFStatus", 0);
            LOFStatus.SqlDbType = SqlDbType.Int;
            LOFStatus.Direction = ParameterDirection.Input;
            SqlParameter LOFCondition = vobjADOCmd.Parameters.AddWithValue("@LOFCondition", 0);
            LOFCondition.SqlDbType = SqlDbType.Int;
            LOFCondition.Direction = ParameterDirection.Input;
            SqlParameter LOFObsComments = vobjADOCmd.Parameters.AddWithValue("@LOFObsComments", "");
            LOFObsComments.SqlDbType = SqlDbType.VarChar;
            LOFObsComments.Direction = ParameterDirection.Input;
            SqlParameter LOFEmpComments = vobjADOCmd.Parameters.AddWithValue("@LOFEmpComments", "");
            LOFEmpComments.SqlDbType = SqlDbType.VarChar;
            LOFEmpComments.Direction = ParameterDirection.Input;

            //Pinch points Inputs
            SqlParameter PPStatus = vobjADOCmd.Parameters.AddWithValue("@PPStatus", 0);
            PPStatus.SqlDbType = SqlDbType.Int;
            PPStatus.Direction = ParameterDirection.Input;
            SqlParameter PPCondition = vobjADOCmd.Parameters.AddWithValue("@PPCondition", 0);
            PPCondition.SqlDbType = SqlDbType.Int;
            PPCondition.Direction = ParameterDirection.Input;
            SqlParameter PPObsComments = vobjADOCmd.Parameters.AddWithValue("@PPObsComments", "");
            PPObsComments.SqlDbType = SqlDbType.VarChar;
            PPObsComments.Direction = ParameterDirection.Input;
            SqlParameter PPEmpComments = vobjADOCmd.Parameters.AddWithValue("@PPEmpComments", ""); 
            PPEmpComments.SqlDbType = SqlDbType.VarChar;
            PPEmpComments.Direction = ParameterDirection.Input;

            //Eyes on Path/Task Inputs
            SqlParameter EOPStatus = vobjADOCmd.Parameters.AddWithValue("@EOPStatus", 0);
            EOPStatus.SqlDbType = SqlDbType.Int;
            EOPStatus.Direction = ParameterDirection.Input;
            SqlParameter EOPCondition = vobjADOCmd.Parameters.AddWithValue("@EOPCondition", 0);
            EOPCondition.SqlDbType = SqlDbType.Int;
            EOPCondition.Direction = ParameterDirection.Input;
            SqlParameter EOPObsComments = vobjADOCmd.Parameters.AddWithValue("@EOPObsComments", "");
            EOPObsComments.SqlDbType = SqlDbType.VarChar;
            EOPObsComments.Direction = ParameterDirection.Input;
            SqlParameter EOPEmpComments = vobjADOCmd.Parameters.AddWithValue("@EOPEmpComments", "");
            EOPEmpComments.SqlDbType = SqlDbType.VarChar;
            EOPEmpComments.Direction = ParameterDirection.Input;

            //Footing Inputs
            SqlParameter FooStatus = vobjADOCmd.Parameters.AddWithValue("@FooStatus", 0);
            FooStatus.SqlDbType = SqlDbType.Int;
            FooStatus.Direction = ParameterDirection.Input;
            SqlParameter FooCondition = vobjADOCmd.Parameters.AddWithValue("@FooCondition", 0);
            FooCondition.SqlDbType = SqlDbType.Int;
            FooCondition.Direction = ParameterDirection.Input;
            SqlParameter FooObsComments = vobjADOCmd.Parameters.AddWithValue("@FooObsComments", "");
            FooObsComments.SqlDbType = SqlDbType.VarChar;
            FooObsComments.Direction = ParameterDirection.Input;
            SqlParameter FooEmpComments = vobjADOCmd.Parameters.AddWithValue("@FooEmpComments", "");
            FooEmpComments.SqlDbType = SqlDbType.VarChar;
            FooEmpComments.Direction = ParameterDirection.Input;

            //Confined Area Inputs
            SqlParameter ConfAStatus = vobjADOCmd.Parameters.AddWithValue("@ConfAStatus", 0); 
            ConfAStatus.SqlDbType = SqlDbType.Int;
            ConfAStatus.Direction = ParameterDirection.Input;
            SqlParameter ConfACondition = vobjADOCmd.Parameters.AddWithValue("@ConfACondition", 0);
            ConfACondition.SqlDbType = SqlDbType.Int;
            ConfACondition.Direction = ParameterDirection.Input;
            SqlParameter ConfAObsComments = vobjADOCmd.Parameters.AddWithValue("@ConfAObsComments", "");
            ConfAObsComments.SqlDbType = SqlDbType.VarChar;
            ConfAObsComments.Direction = ParameterDirection.Input;
            SqlParameter ConfAEmpComments = vobjADOCmd.Parameters.AddWithValue("@ConfAEmpComments", "");
            ConfAEmpComments.SqlDbType = SqlDbType.VarChar;
            ConfAEmpComments.Direction = ParameterDirection.Input;

            //Comprehension Area Inputs
            SqlParameter CompStatus = vobjADOCmd.Parameters.AddWithValue("@CompStatus", 0); 
            CompStatus.SqlDbType = SqlDbType.Int;
            CompStatus.Direction = ParameterDirection.Input;
            SqlParameter CompCondition = vobjADOCmd.Parameters.AddWithValue("@CompCondition", 0);
            CompCondition.SqlDbType = SqlDbType.Int;
            CompCondition.Direction = ParameterDirection.Input;
            SqlParameter CompObsComments = vobjADOCmd.Parameters.AddWithValue("@CompObsComments", "");
            CompObsComments.SqlDbType = SqlDbType.VarChar;
            CompObsComments.Direction = ParameterDirection.Input;
            SqlParameter CompEmpComments = vobjADOCmd.Parameters.AddWithValue("@CompEmpComments", "");
            CompEmpComments.SqlDbType = SqlDbType.VarChar;
            CompEmpComments.Direction = ParameterDirection.Input;

            //Coordination Area Inputs
            SqlParameter CoorStatus = vobjADOCmd.Parameters.AddWithValue("@CoorStatus", 0);
            CoorStatus.SqlDbType = SqlDbType.Int;
            CoorStatus.Direction = ParameterDirection.Input;
            SqlParameter CoorCondition = vobjADOCmd.Parameters.AddWithValue("@CoorCondition", 0);
            CoorCondition.SqlDbType = SqlDbType.Int;
            CoorCondition.Direction = ParameterDirection.Input;
            SqlParameter CoorObsComments = vobjADOCmd.Parameters.AddWithValue("@CoorObsComments", "");
            CoorObsComments.SqlDbType = SqlDbType.VarChar;
            CoorObsComments.Direction = ParameterDirection.Input;
            SqlParameter CoorEmpComments = vobjADOCmd.Parameters.AddWithValue("@CoorEmpComments", "");
            CoorEmpComments.SqlDbType = SqlDbType.VarChar;
            CoorEmpComments.Direction = ParameterDirection.Input;

            //Identification Area Inputs
            SqlParameter IDStatus = vobjADOCmd.Parameters.AddWithValue("@IDStatus", 0); 
            IDStatus.SqlDbType = SqlDbType.Int;
            IDStatus.Direction = ParameterDirection.Input;
            SqlParameter IDCondition = vobjADOCmd.Parameters.AddWithValue("@IDCondition", 0);
            IDCondition.SqlDbType = SqlDbType.Int;
            IDCondition.Direction = ParameterDirection.Input;
            SqlParameter IDObsComments = vobjADOCmd.Parameters.AddWithValue("@IDObsComments", "");
            IDObsComments.SqlDbType = SqlDbType.VarChar;
            IDObsComments.Direction = ParameterDirection.Input;
            SqlParameter IDEmpComments = vobjADOCmd.Parameters.AddWithValue("@IDEmpComments", "");
            IDEmpComments.SqlDbType = SqlDbType.VarChar;
            IDEmpComments.Direction = ParameterDirection.Input;

            //Cleanlieness Area Inputs
            SqlParameter CleanStatus = vobjADOCmd.Parameters.AddWithValue("@CleanStatus", 0);
            CleanStatus.SqlDbType = SqlDbType.Int;
            CleanStatus.Direction = ParameterDirection.Input;
            SqlParameter CleanCondition = vobjADOCmd.Parameters.AddWithValue("@CleanCondition", 0);
            CleanCondition.SqlDbType = SqlDbType.Int;
            CleanCondition.Direction = ParameterDirection.Input;
            SqlParameter CleanObsComments = vobjADOCmd.Parameters.AddWithValue("@CleanObsComments", "");
            CleanObsComments.SqlDbType = SqlDbType.VarChar;
            CleanObsComments.Direction = ParameterDirection.Input;
            SqlParameter CleanEmpComments = vobjADOCmd.Parameters.AddWithValue("@CleanEmpComments", "");
            CleanEmpComments.SqlDbType = SqlDbType.VarChar;
            CleanEmpComments.Direction = ParameterDirection.Input;

            //5S Area Inputs
            SqlParameter s5sStatus = vobjADOCmd.Parameters.AddWithValue("@5SStatus", 0);
            s5sStatus.SqlDbType = SqlDbType.Int;
            s5sStatus.Direction = ParameterDirection.Input;
            SqlParameter s5SCondition = vobjADOCmd.Parameters.AddWithValue("@5SCondition", 0);
            s5SCondition.SqlDbType = SqlDbType.Int;
            s5SCondition.Direction = ParameterDirection.Input;
            SqlParameter s5SObsComments = vobjADOCmd.Parameters.AddWithValue("@5SObsComments", "");
            s5SObsComments.SqlDbType = SqlDbType.VarChar;
            s5SObsComments.Direction = ParameterDirection.Input;
            SqlParameter s5SEmpComments = vobjADOCmd.Parameters.AddWithValue("@5SEmpComments", "");
            s5SEmpComments.SqlDbType = SqlDbType.VarChar;
            s5SEmpComments.Direction = ParameterDirection.Input;

            //Tool Choice Area Inputs
            SqlParameter TCStatus = vobjADOCmd.Parameters.AddWithValue("@TCStatus", 0);
            TCStatus.SqlDbType = SqlDbType.Int;
            TCStatus.Direction = ParameterDirection.Input;
            SqlParameter TCCondition = vobjADOCmd.Parameters.AddWithValue("@TCCondition", 0);
            TCCondition.SqlDbType = SqlDbType.Int;
            TCCondition.Direction = ParameterDirection.Input;
            SqlParameter TCObsComments = vobjADOCmd.Parameters.AddWithValue("@TCObsComments", "");
            TCObsComments.SqlDbType = SqlDbType.VarChar;
            TCObsComments.Direction = ParameterDirection.Input;
            SqlParameter TCEmpComments = vobjADOCmd.Parameters.AddWithValue("@TCEmpComments", "");
            TCEmpComments.SqlDbType = SqlDbType.VarChar;
            TCEmpComments.Direction = ParameterDirection.Input;

            //Tool Usage Area Inputs
            SqlParameter TUStatus = vobjADOCmd.Parameters.AddWithValue("@TUStatus", 0);
            TUStatus.SqlDbType = SqlDbType.Int;
            TUStatus.Direction = ParameterDirection.Input;
            SqlParameter TUCondition = vobjADOCmd.Parameters.AddWithValue("@TUCondition", 0);
            TUCondition.SqlDbType = SqlDbType.Int;
            TUCondition.Direction = ParameterDirection.Input;
            SqlParameter TUObsComments = vobjADOCmd.Parameters.AddWithValue("@TUObsComments", "");
            TUObsComments.SqlDbType = SqlDbType.VarChar;
            TUObsComments.Direction = ParameterDirection.Input;
            SqlParameter TUEmpComments = vobjADOCmd.Parameters.AddWithValue("@TUEmpComments", "");
            TUEmpComments.SqlDbType = SqlDbType.VarChar;
            TUEmpComments.Direction = ParameterDirection.Input;

            //Tool Inspection Area Inputs
            SqlParameter TIStatus = vobjADOCmd.Parameters.AddWithValue("@TIStatus", 0);
            TIStatus.SqlDbType = SqlDbType.Int;
            TIStatus.Direction = ParameterDirection.Input;
            SqlParameter TICondition = vobjADOCmd.Parameters.AddWithValue("@TICondition", 0);
            TICondition.SqlDbType = SqlDbType.Int;
            TICondition.Direction = ParameterDirection.Input;
            SqlParameter TIObsComments = vobjADOCmd.Parameters.AddWithValue("@TIObsComments", "");
            TIObsComments.SqlDbType = SqlDbType.VarChar;
            TIObsComments.Direction = ParameterDirection.Input;
            SqlParameter TIEmpComments = vobjADOCmd.Parameters.AddWithValue("@TIEmpComments", "");
            TIEmpComments.SqlDbType = SqlDbType.VarChar;
            TIEmpComments.Direction = ParameterDirection.Input;

            //Fork Lift Area Inputs
            SqlParameter FKLStatus = vobjADOCmd.Parameters.AddWithValue("@FKLStatus",0); 
            FKLStatus.SqlDbType = SqlDbType.Int;
            FKLStatus.Direction = ParameterDirection.Input;
            SqlParameter FKLCondition = vobjADOCmd.Parameters.AddWithValue("@FKLCondition", 0);
            FKLCondition.SqlDbType = SqlDbType.Int;
            FKLCondition.Direction = ParameterDirection.Input;
            SqlParameter FKLObsComments = vobjADOCmd.Parameters.AddWithValue("@FKLObsComments", "");
            FKLObsComments.SqlDbType = SqlDbType.VarChar;
            FKLObsComments.Direction = ParameterDirection.Input;
            SqlParameter FKLEmpComments = vobjADOCmd.Parameters.AddWithValue("@FKLEmpComments", "");
            FKLEmpComments.SqlDbType = SqlDbType.VarChar;
            FKLEmpComments.Direction = ParameterDirection.Input;

            //PPE_S Area Inputs
            SqlParameter PPES_Status = vobjADOCmd.Parameters.AddWithValue("@PPE_SStatus", 0); 
            PPES_Status.SqlDbType = SqlDbType.Int;
            PPES_Status.Direction = ParameterDirection.Input;
            SqlParameter PPES_Condition = vobjADOCmd.Parameters.AddWithValue("@PPE_SCondition", 0);
            PPES_Condition.SqlDbType = SqlDbType.Int;
            PPES_Condition.Direction = ParameterDirection.Input;
            SqlParameter PPES_ObsComments = vobjADOCmd.Parameters.AddWithValue("@PPE_SObsComments", "");
            PPES_ObsComments.SqlDbType = SqlDbType.VarChar;
            PPES_ObsComments.Direction = ParameterDirection.Input;
            SqlParameter PPES_EmpComments = vobjADOCmd.Parameters.AddWithValue("@PPE_SEmpComments", "");
            PPES_EmpComments.SqlDbType = SqlDbType.VarChar;
            PPES_EmpComments.Direction = ParameterDirection.Input;

            //PPE_U Area Inputs
            SqlParameter PPEU_Status = vobjADOCmd.Parameters.AddWithValue("@PPE_UStatus", 0);
            PPEU_Status.SqlDbType = SqlDbType.Int;
            PPEU_Status.Direction = ParameterDirection.Input;
            SqlParameter PPEU_Condition = vobjADOCmd.Parameters.AddWithValue("@PPE_UCondition", 0);
            PPEU_Condition.SqlDbType = SqlDbType.Int;
            PPEU_Condition.Direction = ParameterDirection.Input;
            SqlParameter PPEU_ObsComments = vobjADOCmd.Parameters.AddWithValue("@PPE_UObsComments", "");
            PPEU_ObsComments.SqlDbType = SqlDbType.VarChar;
            PPEU_ObsComments.Direction = ParameterDirection.Input;
            SqlParameter PPEU_EmpComments = vobjADOCmd.Parameters.AddWithValue("@PPE_UEmpComments", "");
            PPEU_EmpComments.SqlDbType = SqlDbType.VarChar;
            PPEU_EmpComments.Direction = ParameterDirection.Input;

            //PPE_C Area Inputs
            SqlParameter PPEC_Status = vobjADOCmd.Parameters.AddWithValue("@PPE_CStatus", 0);
            PPEC_Status.SqlDbType = SqlDbType.Int;
            PPEC_Status.Direction = ParameterDirection.Input;
            SqlParameter PPEC_Condition = vobjADOCmd.Parameters.AddWithValue("@PPE_CCondition", 0);
            PPEC_Condition.SqlDbType = SqlDbType.Int;
            PPEC_Condition.Direction = ParameterDirection.Input;
            SqlParameter PPEC_ObsComments = vobjADOCmd.Parameters.AddWithValue("@PPE_CObsComments", "");
            PPEC_ObsComments.SqlDbType = SqlDbType.VarChar;
            PPEC_ObsComments.Direction = ParameterDirection.Input;
            SqlParameter PPEC_EmpComments = vobjADOCmd.Parameters.AddWithValue("@PPE_CEmpComments", "");
            PPEC_EmpComments.SqlDbType = SqlDbType.VarChar;
            PPEC_EmpComments.Direction = ParameterDirection.Input;


            // Query through ActivePanel Object to determine which Panels Are Active on This Screen and Fill in the Values 
            for (int i = 0; i < pnlCount; i++)
            {
                switch (Activepanel[i])
                {
                    case "FG":
                        FGStatus.Value = ddl_FGStatus.SelectedValue;
                        FGCondition.Value = ddl_FGCondition.SelectedValue;
                        FGObsComments.Value = tbFG_ObservComment.Text;
                        FGEmpComments.Value = tbFG_EmpComment.Text;
                        break;
                    case "ALI":
                        AliStatus.Value = ddl_AlignStatus.SelectedValue;
                        ALICondition.Value = ddl_AlignCondition.SelectedValue;
                        AliObsComments.Value = tbAlign_ObservComment.Text;
                        AliEmpComments.Value = tbAlign_EmpComment.Text;
                        break;
                    case "Ext":
                        ExtStatus.Value = ddl_ExtStatus.SelectedValue;
                        ExtCondition.Value = ddl_ExtCondition.SelectedValue;
                        ExtObsComments.Value = tbExt_ObservComment.Text;
                        ExtEmpComments.Value = tbExt_EmpComment.Text;
                        break;
                    case "Rep":
                        RepStatus.Value = ddl_RepStatus.SelectedValue;
                        RepCondition.Value = ddl_RepCondition.SelectedValue;
                        RepObsComments.Value = tbRep_ObservComment.Text;
                        RepEmpComments.Value = tbRep_EmpComment.Text;
                        break;
                    case "PC":
                        PaceStatus.Value = ddl_PaceStatus.SelectedValue;
                        PaceCondition.Value = ddl_PaceCondition.SelectedValue;
                        PaceObsComments.Value = tbPace_ObservComment.Text;
                        PaceEmpComments.Value = tbPace_EmpComment.Text;
                        break;
                    case "LOF":
                        LOFStatus.Value = ddl_LOFStatus.SelectedValue;
                        LOFCondition.Value = ddl_LOFCondition.SelectedValue;
                        LOFObsComments.Value = tbLOF_ObservComment.Text;
                        LOFEmpComments.Value = tbLOF_EmpComment.Text;
                        break;
                    case "PP":
                        PPStatus.Value = ddl_PPStatus.SelectedValue;
                        PPCondition.Value = ddl_PPCondition.SelectedValue;
                        PPObsComments.Value = tbPP_ObservComment.Text;
                        PPEmpComments.Value = tbPP_EmpComment.Text;
                        break;
                    case "Eop":
                        EOPStatus.Value = ddl_EOPStatus.SelectedValue;
                        EOPCondition.Value = ddl_EOPCondition.SelectedValue;
                        EOPObsComments.Value = tbEOP_ObservComment.Text;
                        EOPEmpComments.Value = tbEOP_EmpComment.Text;
                        break;
                    case "Foo":
                        FooStatus.Value = ddl_FooStatus.SelectedValue;
                        FooCondition.Value = ddl_FooCondition.SelectedValue;
                        FooObsComments.Value = tbFoo_ObservComment.Text;
                        FooEmpComments.Value = tbFoo_EmpComment.Text;
                        break;
                    case "ConfA":
                        ConfAStatus.Value = ddl_ConfAStatus.SelectedValue;
                        ConfACondition.Value = ddl_ConfACondition.SelectedValue;
                        ConfAObsComments.Value = tbConfA_ObservComment.Text;
                        ConfAEmpComments.Value = tbConfA_EmpComment.Text;
                        break;
                    case "Comp":
                        CompStatus.Value = ddl_CompStatus.SelectedValue;
                        CompCondition.Value = ddl_CompCondition.SelectedValue;
                        CompObsComments.Value = tbComp_ObservComment.Text;
                        CompEmpComments.Value = tbComp_EmpComment.Text;
                        break;
                    case "Coor":
                        CoorStatus.Value = ddl_CoorStatus.SelectedValue;
                        CoorCondition.Value = ddl_CoorCondition.SelectedValue;
                        CoorObsComments.Value = tbCoor_ObservComment.Text;
                        CoorEmpComments.Value = tbCoor_EmpComment.Text;
                        break;
                    case "ID":
                        IDStatus.Value = ddl_IDStatus.SelectedValue;
                        IDCondition.Value = ddl_IDCondition.SelectedValue;
                        IDObsComments.Value = tbID_ObservComment.Text;
                        IDEmpComments.Value = tbID_EmpComment.Text;
                        break;
                    case "Clean":
                        CleanStatus.Value = ddl_CleanStatus.SelectedValue;
                        CleanCondition.Value = ddl_CleanCondition.SelectedValue;
                        CleanObsComments.Value = tbClean_ObservComment.Text;
                        CleanEmpComments.Value = tbClean_EmpComment.Text;
                        break;
                    case "s5S":
                        s5sStatus.Value = ddl_5SStatus.SelectedValue;
                        s5SCondition.Value = ddl_5SCondition.SelectedValue;
                        s5SObsComments.Value = tb5S_ObservComment.Text;
                        s5SEmpComments.Value = tb5S_EmpComment.Text;
                        break;
                    case "TC":
                        TCStatus.Value = ddl_TCStatus.SelectedValue;
                        TCCondition.Value = ddl_TCCondition.SelectedValue;
                        TCObsComments.Value = tbTC_ObservComment.Text;
                        TCEmpComments.Value = tbTC_EmpComment.Text;
                        break;
                    case "TU":
                        TUStatus.Value = ddl_TUStatus.SelectedValue;
                        TUCondition.Value = ddl_TUCondition.SelectedValue;
                        TUObsComments.Value = tbTU_ObservComment.Text;
                        TUEmpComments.Value = tbTU_EmpComment.Text;
                        break;
                    case "TI":
                        TIStatus.Value = ddl_TIStatus.SelectedValue;
                        TICondition.Value = ddl_TICondition.SelectedValue;
                        TIObsComments.Value = tbTI_ObservComment.Text;
                        TIEmpComments.Value = tbTI_EmpComment.Text;
                        break;
                    case "FKL":
                        FKLStatus.Value = ddl_FKLStatus.SelectedValue;
                        FKLCondition.Value = ddl_FKLCondition.SelectedValue;
                        FKLObsComments.Value = tbFKL_ObservComment.Text;
                        FKLEmpComments.Value = tbFKL_EmpComment.Text;
                        break;
                    case "PPE_S":
                        PPES_Status.Value = ddl_PPE_SStatus.SelectedValue;
                        PPES_Condition.Value = ddl_PPE_SCondition.SelectedValue;
                        PPES_ObsComments.Value = tbPPE_S_ObservComment.Text;
                        PPES_EmpComments.Value = tbPPE_S_EmpComment.Text;
                        break;
                    case "PPE_U":
                        PPEU_Status.Value = ddl_PPE_UStatus.SelectedValue;
                        PPEU_Condition.Value = ddl_PPE_UCondition.SelectedValue;
                        PPEU_ObsComments.Value = tbPPE_U_ObservComment.Text;
                        PPEU_EmpComments.Value = tbPPE_U_EmpComment.Text;
                        break;
                    case "PPE_C":
                        PPEC_Status.Value = ddl_PPE_CStatus.SelectedValue;
                        PPEC_Condition.Value = ddl_PPE_CCondition.SelectedValue;
                        PPEC_ObsComments.Value = tbPPE_C_ObservComment.Text;
                        PPEC_EmpComments.Value = tbPPE_C_EmpComment.Text;
                        break;
                    default:
                        break;
                }
            }
            /* Add Output Variables */
            SqlParameter IntResultCode = vobjADOCmd.Parameters.AddWithValue("@IntResultCode", "");
            IntResultCode.SqlDbType = SqlDbType.Int;
            IntResultCode.Direction = ParameterDirection.Output;
            SqlParameter strResultText = vobjADOCmd.Parameters.AddWithValue("@strResultText", "");
            strResultText.SqlDbType = SqlDbType.VarChar;
            strResultText.Size = 256;
            strResultText.Direction = ParameterDirection.Output;
            //Execute The Method */
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                tb_SqlResults.Text = (ex.Message);
                tb_SqlResults.Visible = true;
                return;
            }
            try
            {
                vobjADOCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                tb_SqlResults.Text = (ex.Message);
                tb_SqlResults.Visible = true;
                return;
            }
            /*Error and Information treatment */
            int retunvalue = Convert.ToInt32(vobjADOCmd.Parameters["@IntResultCode"].Value);

            if ((retunvalue != 1) & (retunvalue != 33))
            {
                tb_SqlResults.Text = "Sql Failure result String Was " + "[" + IntResultCode.Value + "]" + "->" + strResultText.Value;
                tb_SqlResults.Visible = true;
                return;
            }
            if (retunvalue == 1)
            {   //Clear Text boxes
                tbFG_ObservComment.Text = "";
                tbFG_EmpComment.Text = "";
                tbAlign_ObservComment.Text = "";
                tbAlign_EmpComment.Text = "";
                tbExt_ObservComment.Text = "";
                tbExt_EmpComment.Text = "";
                tbRep_ObservComment.Text = "";
                tbRep_EmpComment.Text = "";
                tbPace_ObservComment.Text = "";
                tbPace_EmpComment.Text = "";
                tbLOF_ObservComment.Text = "";
                tbLOF_EmpComment.Text = "";
                tbPP_ObservComment.Text = "";
                tbPP_EmpComment.Text = "";
                tbEOP_ObservComment.Text = "";
                tbEOP_EmpComment.Text = "";
                tbFoo_ObservComment.Text = "";
                tbFoo_EmpComment.Text = "";
                tbConfA_ObservComment.Text = "";
                tbConfA_EmpComment.Text = "";
                tbComp_ObservComment.Text = "";
                tbComp_EmpComment.Text = "";
                tbCoor_ObservComment.Text = "";
                tbCoor_EmpComment.Text = "";
                tbID_ObservComment.Text = "";
                tbID_EmpComment.Text = "";
                tbClean_ObservComment.Text = "";
                tbClean_EmpComment.Text = "";
                tb5S_ObservComment.Text = "";
                tb5S_EmpComment.Text = "";
                tbTC_ObservComment.Text = "";
                tbTC_EmpComment.Text = "";
                tbTU_ObservComment.Text = "";
                tbTU_EmpComment.Text = "";
                tbTI_ObservComment.Text = "";
                tbTI_EmpComment.Text = "";
                tbFKL_ObservComment.Text = "";
                tbFKL_EmpComment.Text = "";
                tbPPE_S_ObservComment.Text = "";
                tbPPE_S_EmpComment.Text = "";
                tbPPE_U_ObservComment.Text = "";
                tbPPE_U_EmpComment.Text = "";
                tbPPE_C_ObservComment.Text = "";
                tbPPE_C_EmpComment.Text = "";
                string homeScreenPath = "http://devautosql01:7357/homescreen.aspx";
                Response.Redirect(homeScreenPath);

            }
            /* Enable Execution Error Treatment and Parameter Closing Statements */
            con.Close();

        }
    }
    protected void ddl_PlantQuery_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = 0;
        //Clear Past Screen Objects if we are changing plants and Not on first pass
        tb_SqlResults.Text = "";
        tb_SqlResults.Visible = false;
        //Panel Object Clearing
        pnlForceGrip.Visible = false;
        pnlAlignment.Visible = false;
        pnlExt.Visible = false;
        pnlRep.Visible = false;
        pnlPace.Visible = false;
        pnlLineOfFire.Visible = false;
        pnlPP.Visible = false;
        pnlEopT.Visible = false;
        pnlFoo.Visible = false;
        pnlConfA.Visible = false;
        pnlComp.Visible = false;
        pnlCoor.Visible = false;
        pnlID.Visible = false;
        pnlClean.Visible = false;
        pnl5S.Visible = false;
        pnlTC.Visible = false;
        pnlTU.Visible = false;
        pnlTI.Visible = false;
        pnlFKL.Visible = false;
        pnlPPE_S.Visible = false;
        pnlPPE_U.Visible = false;
        pnlPPE_C.Visible = false;
        //string[] Activepanel = new string[5];
        #region QueryActivePrecautions
        if (ddl_PlantQuery.SelectedIndex != 0)
        {
            intPlant = Convert.ToInt32(ddl_PlantQuery.SelectedValue);
            // Validate Whick Precaution is Valid for the Session
            // Select the Status from tblPrecautions to Perform Reformatting & visability options based on the Selection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSSafetyConnectionString"].ConnectionString);
            SqlCommand vobjADOCmd = new SqlCommand("uspObsObjectsQuery", con);
            vobjADOCmd.CommandType = CommandType.StoredProcedure;

            /* Add Input Variables */
            SqlParameter Plant = vobjADOCmd.Parameters.AddWithValue("@intPlantID", intPlant);
            Plant.SqlDbType = SqlDbType.Int;
            Plant.Direction = ParameterDirection.Input;

            /* Add Output Variables */
            SqlParameter ObsCount = vobjADOCmd.Parameters.AddWithValue("@intOBSCount", "");
            ObsCount.SqlDbType = SqlDbType.Int;
            ObsCount.Direction = ParameterDirection.Output;

            SqlParameter bFG = vobjADOCmd.Parameters.AddWithValue("@FG", "");
            bFG.SqlDbType = SqlDbType.Bit;
            bFG.Direction = ParameterDirection.Output;

            SqlParameter bALI = vobjADOCmd.Parameters.AddWithValue("@ALI", "");
            bALI.SqlDbType = SqlDbType.Bit;
            bALI.Direction = ParameterDirection.Output;

            SqlParameter bExt = vobjADOCmd.Parameters.AddWithValue("@Ext", "");
            bExt.SqlDbType = SqlDbType.Bit;
            bExt.Direction = ParameterDirection.Output;

            SqlParameter bRep = vobjADOCmd.Parameters.AddWithValue("@Rep", "");
            bRep.SqlDbType = SqlDbType.Bit;
            bRep.Direction = ParameterDirection.Output;

            SqlParameter bPC = vobjADOCmd.Parameters.AddWithValue("@PC", "");
            bPC.SqlDbType = SqlDbType.Bit;
            bPC.Direction = ParameterDirection.Output;

            SqlParameter bLof = vobjADOCmd.Parameters.AddWithValue("@Lof", "");
            bLof.SqlDbType = SqlDbType.Bit;
            bLof.Direction = ParameterDirection.Output;

            SqlParameter bPP = vobjADOCmd.Parameters.AddWithValue("@PP", "");
            bPP.SqlDbType = SqlDbType.Bit;
            bPP.Direction = ParameterDirection.Output;

            SqlParameter bEop = vobjADOCmd.Parameters.AddWithValue("@Eop", "");
            bEop.SqlDbType = SqlDbType.Bit;
            bEop.Direction = ParameterDirection.Output;

            SqlParameter bFoo = vobjADOCmd.Parameters.AddWithValue("@Foo", "");
            bFoo.SqlDbType = SqlDbType.Bit;
            bFoo.Direction = ParameterDirection.Output;

            SqlParameter bConfA = vobjADOCmd.Parameters.AddWithValue("@ConfA", "");
            bConfA.SqlDbType = SqlDbType.Bit;
            bConfA.Direction = ParameterDirection.Output;

            SqlParameter bComp = vobjADOCmd.Parameters.AddWithValue("@Comp", "");
            bComp.SqlDbType = SqlDbType.Bit;
            bComp.Direction = ParameterDirection.Output;

            SqlParameter bCoor = vobjADOCmd.Parameters.AddWithValue("@Coor", "");
            bCoor.SqlDbType = SqlDbType.Bit;
            bCoor.Direction = ParameterDirection.Output;

            SqlParameter bID = vobjADOCmd.Parameters.AddWithValue("@ID", "");
            bID.SqlDbType = SqlDbType.Bit;
            bID.Direction = ParameterDirection.Output;

            SqlParameter bClean = vobjADOCmd.Parameters.AddWithValue("@Clean", "");
            bClean.SqlDbType = SqlDbType.Bit;
            bClean.Direction = ParameterDirection.Output;

            SqlParameter bs5S = vobjADOCmd.Parameters.AddWithValue("@5S", "");
            bs5S.SqlDbType = SqlDbType.Bit;
            bs5S.Direction = ParameterDirection.Output;

            SqlParameter bTC = vobjADOCmd.Parameters.AddWithValue("@TC", "");
            bTC.SqlDbType = SqlDbType.Bit;
            bTC.Direction = ParameterDirection.Output;

            SqlParameter bTU = vobjADOCmd.Parameters.AddWithValue("@TU", "");
            bTU.SqlDbType = SqlDbType.Bit;
            bTU.Direction = ParameterDirection.Output;

            SqlParameter bTI = vobjADOCmd.Parameters.AddWithValue("@TI", "");
            bTI.SqlDbType = SqlDbType.Bit;
            bTI.Direction = ParameterDirection.Output;

            SqlParameter bFKL = vobjADOCmd.Parameters.AddWithValue("@FKL", "");
            bFKL.SqlDbType = SqlDbType.Bit;
            bFKL.Direction = ParameterDirection.Output;

            SqlParameter bPPE_S = vobjADOCmd.Parameters.AddWithValue("@PPE_S", "");
            bPPE_S.SqlDbType = SqlDbType.Bit;
            bPPE_S.Direction = ParameterDirection.Output;

            SqlParameter bPPE_U = vobjADOCmd.Parameters.AddWithValue("@PPE_U", "");
            bPPE_U.SqlDbType = SqlDbType.Bit;
            bPPE_U.Direction = ParameterDirection.Output;

            SqlParameter bPPE_C = vobjADOCmd.Parameters.AddWithValue("@PPE_C", "");
            bPPE_C.SqlDbType = SqlDbType.Bit;
            bPPE_C.Direction = ParameterDirection.Output;

            SqlParameter IntResultCode = vobjADOCmd.Parameters.AddWithValue("@IntResultCode", "");
            IntResultCode.SqlDbType = SqlDbType.Int;
            IntResultCode.Direction = ParameterDirection.Output;

            SqlParameter strResultText = vobjADOCmd.Parameters.AddWithValue("@strResultText", "");
            strResultText.SqlDbType = SqlDbType.VarChar;
            strResultText.Size = 256;
            strResultText.Direction = ParameterDirection.Output;

            //Execute The Method */
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                tb_SqlResults.Text = (ex.Message);
                tb_SqlResults.Visible = true;
                return;
            }
            try
            {
                vobjADOCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                tb_SqlResults.Text = (ex.Message);
                tb_SqlResults.Visible = true;
                return;
            }
            /*Error and Information treatment */
            int retunvalue = Convert.ToInt32(vobjADOCmd.Parameters["@IntResultCode"].Value);

            if ((retunvalue != 1) & (retunvalue != 33))
            {
                tb_SqlResults.Text = "Sql Failure result String Was " + "[" + IntResultCode.Value + "]" + "->" + strResultText.Value;
                tb_SqlResults.Visible = true;
                return;
            }
            if (retunvalue == 1)
            {
                //Clear Text boxes
                pnlObsCoreData.Enabled = true;
                tbFG_ObservComment.Text = "";
                tbFG_EmpComment.Text = "";
                tbAlign_ObservComment.Text = "";
                tbAlign_EmpComment.Text = "";
                tbExt_ObservComment.Text = "";
                tbExt_EmpComment.Text = "";
                tbRep_ObservComment.Text = "";
                tbRep_EmpComment.Text = "";
                tbPace_ObservComment.Text = "";
                tbPace_EmpComment.Text = "";
                tbLOF_ObservComment.Text = "";
                tbLOF_EmpComment.Text = "";
                tbPP_ObservComment.Text = "";
                tbPP_EmpComment.Text = "";
                tbEOP_ObservComment.Text = "";
                tbEOP_EmpComment.Text = "";
                tbFoo_ObservComment.Text = "";
                tbFoo_EmpComment.Text = "";
                tbConfA_ObservComment.Text = "";
                tbConfA_EmpComment.Text = "";
                tbComp_ObservComment.Text = "";
                tbComp_EmpComment.Text = "";
                tbCoor_ObservComment.Text = "";
                tbCoor_EmpComment.Text = "";
                tbID_ObservComment.Text = "";
                tbID_EmpComment.Text = "";
                tbClean_ObservComment.Text = "";
                tbClean_EmpComment.Text = "";
                tb5S_ObservComment.Text = "";
                tb5S_EmpComment.Text = "";
                tbTC_ObservComment.Text = "";
                tbTC_EmpComment.Text = "";
                tbTU_ObservComment.Text = "";
                tbTU_EmpComment.Text = "";
                tbTI_ObservComment.Text = "";
                tbTI_EmpComment.Text = "";
                tbFKL_ObservComment.Text = "";
                tbFKL_EmpComment.Text = "";
                tbPPE_S_ObservComment.Text = "";
                tbPPE_S_EmpComment.Text = "";
                tbPPE_U_ObservComment.Text = "";
                tbPPE_U_EmpComment.Text = "";
                tbPPE_C_ObservComment.Text = "";
                tbPPE_C_EmpComment.Text = "";

                //Evaluate the Returned Bits to Determine Which panles to Activate to the User 
                pnlCount = Convert.ToInt32(vobjADOCmd.Parameters["@intOBSCount"].Value);
                FG = Convert.ToBoolean(vobjADOCmd.Parameters["@FG"].Value);
                ALI = Convert.ToBoolean(vobjADOCmd.Parameters["@Ali"].Value);
                Ext = Convert.ToBoolean(vobjADOCmd.Parameters["@Ext"].Value);
                Rep = Convert.ToBoolean(vobjADOCmd.Parameters["@Rep"].Value);
                PC = Convert.ToBoolean(vobjADOCmd.Parameters["@PC"].Value);
                LOF = Convert.ToBoolean(vobjADOCmd.Parameters["@LOF"].Value);
                PP = Convert.ToBoolean(vobjADOCmd.Parameters["@PP"].Value);
                Eop = Convert.ToBoolean(vobjADOCmd.Parameters["@Eop"].Value);
                Foo = Convert.ToBoolean(vobjADOCmd.Parameters["@Foo"].Value);
                ConfA = Convert.ToBoolean(vobjADOCmd.Parameters["@ConfA"].Value);
                Comp = Convert.ToBoolean(vobjADOCmd.Parameters["@Comp"].Value);
                Coor = Convert.ToBoolean(vobjADOCmd.Parameters["@Coor"].Value);
                ID = Convert.ToBoolean(vobjADOCmd.Parameters["@ID"].Value);
                Clean = Convert.ToBoolean(vobjADOCmd.Parameters["@Clean"].Value);
                s5S = Convert.ToBoolean(vobjADOCmd.Parameters["@5S"].Value);
                TC = Convert.ToBoolean(vobjADOCmd.Parameters["@TC"].Value);
                TU = Convert.ToBoolean(vobjADOCmd.Parameters["@TU"].Value);
                TI = Convert.ToBoolean(vobjADOCmd.Parameters["@TI"].Value);
                FKL = Convert.ToBoolean(vobjADOCmd.Parameters["@FKL"].Value);
                PPE_S = Convert.ToBoolean(vobjADOCmd.Parameters["@PPE_S"].Value);
                PPE_U = Convert.ToBoolean(vobjADOCmd.Parameters["@PPE_U"].Value);
                PPE_C = Convert.ToBoolean(vobjADOCmd.Parameters["@PPE_C"].Value);

                //Test the Active Precaution count before we proceed to the For Loop --Waste of Time if =0
                if (pnlCount == 0)
                {
                    tb_SqlResults.Text = "Plant " + "[" + ddl_PlantQuery.SelectedItem.Text + "]" + " Returned no active Precautions Contact your System Administrator.";
                    tb_SqlResults.Visible = true;
                    pnlObsCoreData.Enabled = false;
                    return;
                }
                #endregion QueryActivePrecautions
        #region PnlDeterminination
                for (i = 0; i < pnlCount; i++)
                {
                    //Evaluate the Objects to Find the Correct Objects
                    if (FG)
                    {
                        Activepanel[i] = "FG";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }

                    }
                    if (ALI)
                    {
                        Activepanel[i] = "ALI";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Ext)
                    {
                        Activepanel[i] = "Ext";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Rep)
                    {
                        Activepanel[i] = "Rep";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (PC)
                    {
                        Activepanel[i] = "PC";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (LOF)
                    {
                        Activepanel[i] = "LOF";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (PP)
                    {
                        Activepanel[i] = "PP";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Eop)
                    {
                        Activepanel[i] = "Eop";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Foo)
                    {
                        Activepanel[i] = "Foo";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (ConfA)
                    {
                        Activepanel[i] = "ConfA";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Comp)
                    {
                        Activepanel[i] = "Comp";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Coor)
                    {
                        Activepanel[i] = "Coor";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (ID)
                    {
                        Activepanel[i] = "ID";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (Clean)
                    {
                        Activepanel[i] = "Clean";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (s5S)
                    {
                        Activepanel[i] = "s5S";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (TC)
                    {
                        Activepanel[i] = "TC";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (TU)
                    {
                        Activepanel[i] = "TU";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (TI)
                    {
                        Activepanel[i] = "TI";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (FKL)
                    {
                        Activepanel[i] = "FKL";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (PPE_S)
                    {
                        Activepanel[i] = "PPE_S";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (PPE_U)
                    {
                        Activepanel[i] = "PPE_U";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }
                    if (PPE_C)
                    {
                        Activepanel[i] = "PPE_C";
                        //test i to avoid breakinging the array -Out of Bounds failure-
                        if (i <= pnlCount)
                        {
                            i++;
                        }
                        if (i >= pnlCount)
                        {
                            break;
                        }
                    }

                }
                #endregion PnlDeterminination
        #region Create Panels
                for (int k = 0; k < pnlCount; k++)
                {
                    int PosSeperator = 135;
                    int Pos1 = 167;
                    int Pos2 = Pos1 + (PosSeperator);
                    int Pos3 = Pos2 + (PosSeperator);
                    int Pos4 = Pos3 + (PosSeperator);
                    int Pos5 = Pos4 + (PosSeperator);
                    int PostoMove = 0;
                    string vstrTopStatement;
                    string vstrTopStatement1;
                    System.Drawing.Color color = new System.Drawing.Color();
                    if (k == 0)
                    {
                        PostoMove = Pos1;
                        color = System.Drawing.ColorTranslator.FromHtml("#CCCC00");
                    }
                    if (k == 1)
                    {
                        PostoMove = Pos2;
                        color = System.Drawing.ColorTranslator.FromHtml("#FFFF00");
                    }
                    if (k == 2)
                    {
                        PostoMove = Pos3;
                        color = System.Drawing.ColorTranslator.FromHtml("#FFCC00");
                    }
                    if (k == 3)
                    {
                        PostoMove = Pos4;
                        color = System.Drawing.ColorTranslator.FromHtml("#FF9933");
                    }
                    if (k == 4)
                    {
                        PostoMove = Pos5;
                        color = System.Drawing.ColorTranslator.FromHtml("#FF6600");
                    }
                    vstrTopStatement = "Top";
                    vstrTopStatement1 = PostoMove.ToString() + "px";
                    switch (Activepanel[k])
                    {
                        case "FG":
                            pnlForceGrip.CssClass = "pnl" + k.ToString() + "Class";
                            pnlForceGrip.Style.Add("width", "1280px");
                            pnlForceGrip.Style.Add("height", "130px");
                            pnlForceGrip.Style.Add("position", "absolute");
                            pnlForceGrip.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlForceGrip.Style.Add("left", "10px");
                            pnlForceGrip.Style.Add("z - index", "1");
                            pnlForceGrip.BackColor = color;
                            pnlForceGrip.BorderStyle = BorderStyle.Solid;
                            pnlForceGrip.Visible = true;
                            pnlForceGrip.Enabled = true;
                            break;
                        case "ALI":
                            pnlAlignment.CssClass = "pnl" + k.ToString() + "Class";
                            pnlAlignment.Style.Add("width", "1280px");
                            pnlAlignment.Style.Add("height", "130px");
                            pnlAlignment.Style.Add("position", "absolute");
                            pnlAlignment.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlAlignment.Style.Add("left", "10px");
                            pnlAlignment.Style.Add("z - index", "1");
                            pnlAlignment.BackColor = color;
                            pnlAlignment.BorderStyle = BorderStyle.Solid;
                            pnlAlignment.Visible = true;
                            pnlAlignment.Enabled = true;
                            break;
                        case "Ext":
                            pnlExt.CssClass = "pnl" + k.ToString() + "Class";
                            pnlExt.Style.Add("width", "1280px");
                            pnlExt.Style.Add("height", "130px");
                            pnlExt.Style.Add("position", "absolute");
                            pnlExt.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlExt.Style.Add("left", "10px");
                            pnlExt.Style.Add("z - index", "1");
                            pnlExt.BackColor = color;
                            pnlExt.BorderStyle = BorderStyle.Solid;
                            pnlExt.Visible = true;
                            pnlExt.Enabled = true;
                            break;
                        case "Rep":
                            pnlRep.CssClass = "pnl" + k.ToString() + "Class";
                            pnlRep.Style.Add("width", "1280px");
                            pnlRep.Style.Add("height", "130px");
                            pnlRep.Style.Add("position", "absolute");
                            pnlRep.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlRep.Style.Add("left", "10px");
                            pnlRep.Style.Add("z - index", "1");
                            pnlRep.BackColor = color;
                            pnlRep.BorderStyle = BorderStyle.Solid;
                            pnlRep.Visible = true;
                            pnlRep.Enabled = true;
                            break;
                        case "PC":
                            pnlPace.CssClass = "pnl" + k.ToString() + "Class";
                            pnlPace.Style.Add("width", "1280px");
                            pnlPace.Style.Add("height", "130px");
                            pnlPace.Style.Add("position", "absolute");
                            pnlPace.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlPace.Style.Add("left", "10px");
                            pnlPace.Style.Add("z - index", "1");
                            pnlPace.BackColor = color;
                            pnlPace.BorderStyle = BorderStyle.Solid;
                            pnlPace.Visible = true;
                            pnlPace.Enabled = true;
                            break;
                        case "LOF":
                            pnlLineOfFire.CssClass = "pnl" + k.ToString() + "Class";
                            pnlLineOfFire.Style.Add("width", "1280px");
                            pnlLineOfFire.Style.Add("height", "130px");
                            pnlLineOfFire.Style.Add("position", "absolute");
                            pnlLineOfFire.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlLineOfFire.Style.Add("left", "10px");
                            pnlLineOfFire.Style.Add("z - index", "1");
                            pnlLineOfFire.BackColor = color;
                            //pnlLineOfFire.Style.Add("BackColor", color.ToString());
                            pnlLineOfFire.Style.Add("BorderStyle", "Solid");
                            pnlLineOfFire.Visible = true;
                            pnlLineOfFire.Enabled = true;
                            break;
                        case "PP":
                            pnlPP.CssClass = "pnl" + k.ToString() + "Class";
                            pnlPP.Style.Add("width", "1280px");
                            pnlPP.Style.Add("height", "130px");
                            pnlPP.Style.Add("position", "absolute");
                            pnlPP.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlPP.Style.Add("left", "10px");
                            pnlPP.Style.Add("z - index", "1");
                            pnlPP.BackColor = color;
                            pnlPP.BorderStyle = BorderStyle.Solid;
                            pnlPP.Visible = true;
                            pnlPP.Enabled = true;
                            break;
                        case "Eop":
                            pnlEopT.CssClass = "pnl" + k.ToString() + "Class";
                            pnlEopT.Style.Add("width", "1280px");
                            pnlEopT.Style.Add("height", "130px");
                            pnlEopT.Style.Add("position", "absolute");
                            pnlEopT.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlEopT.Style.Add("left", "10px");
                            pnlEopT.Style.Add("z - index", "1");
                            pnlEopT.BackColor = color;
                            pnlEopT.BorderStyle = BorderStyle.Solid;
                            pnlEopT.Visible = true;
                            pnlEopT.Enabled = true;
                            break;
                        case "Foo":
                            pnlFoo.CssClass = "pnl" + k.ToString() + "Class";
                            pnlFoo.Style.Add("width", "1280px");
                            pnlFoo.Style.Add("height", "130px");
                            pnlFoo.Style.Add("position", "absolute");
                            pnlFoo.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlFoo.Style.Add("left", "10px");
                            pnlFoo.Style.Add("z - index", "1");
                            pnlFoo.BackColor = color;
                            pnlFoo.BorderStyle = BorderStyle.Solid;
                            pnlFoo.Visible = true;
                            pnlFoo.Enabled = true;
                            break;
                        case "ConfA":
                            pnlConfA.CssClass = "pnl" + k.ToString() + "Class";
                            pnlConfA.Style.Add("width", "1280px");
                            pnlConfA.Style.Add("height", "130px");
                            pnlConfA.Style.Add("position", "absolute");
                            pnlConfA.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlConfA.Style.Add("left", "10px");
                            pnlConfA.Style.Add("z - index", "1");
                            pnlConfA.BackColor = color;
                            pnlConfA.BorderStyle = BorderStyle.Solid;
                            pnlConfA.Visible = true;
                            pnlConfA.Enabled = true;
                            break;
                        case "Comp":
                            pnlComp.CssClass = "pnl" + k.ToString() + "Class";
                            pnlComp.Style.Add("width", "1280px");
                            pnlComp.Style.Add("height", "130px");
                            pnlComp.Style.Add("position", "absolute");
                            pnlComp.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlComp.Style.Add("left", "10px");
                            pnlComp.Style.Add("z - index", "1");
                            pnlComp.BackColor = color;
                            pnlComp.BorderStyle = BorderStyle.Solid;
                            pnlComp.Visible = true;
                            pnlComp.Enabled = true;
                            break;
                        case "Coor":
                            pnlCoor.CssClass = "pnl" + k.ToString() + "Class";
                            pnlCoor.Style.Add("width", "1280px");
                            pnlCoor.Style.Add("height", "130px");
                            pnlCoor.Style.Add("position", "absolute");
                            pnlCoor.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlCoor.Style.Add("left", "10px");
                            pnlCoor.Style.Add("z - index", "1");
                            pnlCoor.BackColor = color;
                            pnlCoor.BorderStyle = BorderStyle.Solid;
                            pnlCoor.Visible = true;
                            pnlCoor.Enabled = true;
                            break;
                        case "ID":
                            pnlID.CssClass = "pnl" + k.ToString() + "Class";
                            pnlID.Style.Add("width", "1280px");
                            pnlID.Style.Add("height", "130px");
                            pnlID.Style.Add("position", "absolute");
                            pnlID.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlID.Style.Add("left", "10px");
                            pnlID.Style.Add("z - index", "1");
                            pnlID.BackColor = color;
                            pnlID.BorderStyle = BorderStyle.Solid;
                            pnlID.Visible = true;
                            pnlID.Enabled = true;
                            break;
                        case "Clean":
                            pnlClean.CssClass = "pnl" + k.ToString() + "Class";
                            pnlClean.Style.Add("width", "1280px");
                            pnlClean.Style.Add("height", "130px");
                            pnlClean.Style.Add("position", "absolute");
                            pnlClean.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlClean.Style.Add("left", "10px");
                            pnlClean.Style.Add("z - index", "1");
                            pnlClean.BackColor = color;
                            pnlClean.BorderStyle = BorderStyle.Solid;
                            pnlClean.Visible = true;
                            pnlClean.Enabled = true;
                            break;
                        case "s5S":
                            pnl5S.CssClass = "pnl" + k.ToString() + "Class";
                            pnl5S.Style.Add("width", "1280px");
                            pnl5S.Style.Add("height", "130px");
                            pnl5S.Style.Add("position", "absolute");
                            pnl5S.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnl5S.Style.Add("left", "10px");
                            pnl5S.Style.Add("z - index", "1");
                            pnl5S.BackColor = color;
                            pnl5S.BorderStyle = BorderStyle.Solid;
                            pnl5S.Visible = true;
                            pnl5S.Enabled = true;
                            break;
                        case "TC":
                            pnlTC.CssClass = "pnl" + k.ToString() + "Class";
                            pnlTC.Style.Add("width", "1280px");
                            pnlTC.Style.Add("height", "130px");
                            pnlTC.Style.Add("position", "absolute");
                            pnlTC.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlTC.Style.Add("left", "10px");
                            pnlTC.Style.Add("z - index", "1");
                            pnlTC.BackColor = color;
                            pnlTC.BorderStyle = BorderStyle.Solid;
                            pnlTC.Visible = true;
                            pnlTC.Enabled = true;
                            break;
                        case "TU":
                            pnlTU.CssClass = "pnl" + k.ToString() + "Class";
                            pnlTU.Style.Add("width", "1280px");
                            pnlTU.Style.Add("height", "130px");
                            pnlTU.Style.Add("position", "absolute");
                            pnlTU.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlTU.Style.Add("left", "10px");
                            pnlTU.Style.Add("z - index", "1");
                            pnlTU.BackColor = color;
                            pnlTU.BorderStyle = BorderStyle.Solid;
                            pnlTU.Visible = true;
                            pnlTU.Enabled = true;
                            break;
                        case "TI":
                            pnlTI.CssClass = "pnl" + k.ToString() + "Class";
                            pnlTI.Style.Add("width", "1280px");
                            pnlTI.Style.Add("height", "130px");
                            pnlTI.Style.Add("position", "absolute");
                            pnlTI.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlTI.Style.Add("left", "10px");
                            pnlTI.Style.Add("z - index", "1");
                            pnlTI.BackColor = color;
                            pnlTI.BorderStyle = BorderStyle.Solid;
                            pnlTI.Visible = true;
                            pnlTI.Enabled = true;
                            break;
                        case "FKL":
                            pnlFKL.CssClass = "pnl" + k.ToString() + "Class";
                            pnlFKL.Style.Add("width", "1280px");
                            pnlFKL.Style.Add("height", "130px");
                            pnlFKL.Style.Add("position", "absolute");
                            pnlFKL.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlFKL.Style.Add("left", "10px");
                            pnlFKL.Style.Add("z - index", "1");
                            pnlFKL.BackColor = color;
                            pnlFKL.BorderStyle = BorderStyle.Solid;
                            pnlFKL.Visible = true;
                            pnlFKL.Enabled = true;
                            break;
                        case "PPE_S":
                            pnlPPE_S.CssClass = "pnl" + k.ToString() + "Class";
                            pnlPPE_S.Style.Add("width", "1280px");
                            pnlPPE_S.Style.Add("height", "130px");
                            pnlPPE_S.Style.Add("position", "absolute");
                            pnlPPE_S.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlPPE_S.Style.Add("left", "10px");
                            pnlPPE_S.Style.Add("z - index", "1");
                            pnlPPE_S.BackColor = color;
                            pnlPPE_S.BorderStyle = BorderStyle.Solid;
                            pnlPPE_S.Visible = true;
                            pnlPPE_S.Enabled = true;
                            break;
                        case "PPE_U":
                            pnlPPE_U.CssClass = "pnl" + k.ToString() + "Class";
                            pnlPPE_U.Style.Add("width", "1280px");
                            pnlPPE_U.Style.Add("height", "130px");
                            pnlPPE_U.Style.Add("position", "absolute");
                            pnlPPE_U.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlPPE_U.Style.Add("left", "10px");
                            pnlPPE_U.Style.Add("z - index", "1");
                            pnlPPE_U.BackColor = color;
                            pnlPPE_U.BorderStyle = BorderStyle.Solid;
                            pnlPPE_U.Visible = true;
                            pnlPPE_U.Enabled = true;
                            break;
                        case "PPE_C":
                            pnlPPE_C.CssClass = "pnl" + k.ToString() + "Class";
                            pnlPPE_C.Style.Add("width", "1280px");
                            pnlPPE_C.Style.Add("height", "130px");
                            pnlPPE_C.Style.Add("position", "absolute");
                            pnlPPE_C.Style.Add(vstrTopStatement, vstrTopStatement1);
                            pnlPPE_C.Style.Add("left", "10px");
                            pnlPPE_C.Style.Add("z - index", "1");
                            pnlPPE_C.BackColor = color;
                            pnlPPE_C.BorderStyle = BorderStyle.Solid;
                            pnlPPE_C.Visible = true;
                            pnlPPE_C.Enabled = true;
                            break;
                        default:
                            break;
                    }

                }
                #endregion Create Panels
                // Refresh Drop down list boxes
                ddlUser.DataBind();
                ddlDepartment.DataBind();
                ddlMachine.DataBind();
                ddl_FGStatus.DataBind();
                ddl_FGCondition.DataBind();
                ddl_PaceStatus.DataBind();
                ddl_PaceCondition.DataBind();
                ddl_LOFStatus.DataBind();
                ddl_LOFCondition.DataBind();
                ddl_EOPStatus.DataBind();
                ddl_EOPCondition.DataBind();
            }
            /* Enable Execution Error Treatment and Parameter Closing Statements */
            con.Close();

        }
    }
}