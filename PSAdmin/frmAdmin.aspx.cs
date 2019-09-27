using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSAdmin
{
    public partial class frmAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //โหลดเปิดหน้า
        {
            //เรียกใช้ Function
            fncGetname();
            fncLoadData();

            //ปิดปุ่ม
            txtUser.Enabled = false;
            txtEmpID.Enabled = false;
            txtEmail.Enabled = false;
            txtUserEmpID.Enabled = false;
            cmbCode.Enabled = false;
            cmbRep.Enabled = false;
            chkAdd.Enabled = false;
            chkEdit.Enabled = false;
            chkDelete.Enabled = false;
            chkApprove.Enabled = false;
            chkCancel.Enabled = false;
            chkPrint.Enabled = false;
            chkEntry.Enabled = false;
            btnSaveDetail.Enabled = false;
            btnCancelDetail.Enabled = false;
        }

        #region//รวม Function
        private void fncGetname()
        {
            cmbUserID.Items.Clear();
            DataTable DT = new DataTable();
            string lvSQL = "Select us_UserID From sysuser";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumrow = DT.Rows.Count;

            for (int i = 0; i < lvNumrow; i++)
            {
                string DA = DT.Rows[i]["us_UserID"].ToString();
                cmbUserID.Items.Add(DA);
            }
        }

        private void fncGetProgram()
        {
            cmbCode.Items.Clear();
            DataTable DT = new DataTable();
            string lvSQL = "Select S_NodeDT From sysmenusoftware WHERE S_NodeDT > '' ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumrow = DT.Rows.Count;

            for (int i = 0; i < lvNumrow; i++)
            {
                string DA = DT.Rows[i]["S_NodeDT"].ToString();
                cmbCode.Items.Add(DA);
            }
        }

        private void fncGetReport()
        {
            cmbRep.Items.Clear();
            DataTable DT = new DataTable();
            string lvSQL = "Select S_NodeDT From sysmenureport WHERE S_NodeDT > '' ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumrow = DT.Rows.Count;

            for (int i = 0; i < lvNumrow; i++)
            {
                string DA = DT.Rows[i]["S_NodeDT"].ToString();
                cmbRep.Items.Add(DA);
            }
        }

        private void clearData1()
        {
            cmbUserID.Text = "";
            txtUserEmpID.Text = "";
        }

        private void clearData2()
        {
            txtUser.Enabled = false;
            txtEmpID.Enabled = false;
            txtEmail.Enabled = false;
            cmbCode.Enabled = false;
            chkAdd.Enabled = false;
            chkEdit.Enabled = false;
            chkDelete.Enabled = false;
            chkApprove.Enabled = false;
            chkCancel.Enabled = false;
            chkPrint.Enabled = false;
            chkEntry.Enabled = false;
            btnSaveDetail.Enabled = false;
            btnCancelDetail.Enabled = false;

            txtUser.Text = "";
            txtEmpID.Text = "";
            txtEmail.Text = "";
            cmbCode.Text = "";
            cmbRep.Text = "";
            chkAdd.Checked = false;
            chkEdit.Checked = false;
            chkDelete.Checked = false;
            chkApprove.Checked = false;
            chkCancel.Checked = false;
            chkPrint.Checked = false;
            chkEntry.Checked = false;
        }

        private void fncLoadData()
        {
            string lvSQL = "SELECT * FROM syspermission ";
            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            ASPxGridView1.DataSource = null;
            ASPxGridView1.DataSource = DT;
            ASPxGridView1.DataBind();
        }

        private void fncLoadDatabyID()
        {
            string lvID = cmbUserID.Text;
            string lvSQL = "SELECT * FROM syspermission WHERE Permission_UserID = '" + lvID + "'";
            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            ASPxGridView1.DataSource = null;
            ASPxGridView1.DataSource = DT;
            ASPxGridView1.DataBind();
        }

        private void fncLoadDatabyProgram()
        {
            string lvID = cmbUserID.Text;
            string lvProm = cmbCode.Text;
            string lvSQL = "SELECT * FROM syspermission WHERE Permission_UserID = '" + lvID + "' and Permission_Code = '" + lvProm + "' ";
            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            ASPxGridView1.DataSource = null;
            ASPxGridView1.DataSource = DT;
            ASPxGridView1.DataBind();
        }

        private void fncLoadDatabyReport()
        {
            string lvID = cmbUserID.Text;
            string lvProm = cmbRep.Text;
            string lvSQL = "SELECT * FROM syspermission WHERE Permission_UserID = '" + lvID + "' and Permission_Code = '" + lvProm + "' ";
            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            ASPxGridView1.DataSource = null;
            ASPxGridView1.DataSource = DT;
            ASPxGridView1.DataBind();
        }
        #endregion

        #region//รวม Action
        protected void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncLoadDatabyID();
            txtUserEmpID.Text = GsysSQL.fncGetEmpID(cmbUserID.Text);
            btnEditUser_Click(sender, e);
        }

        protected void btnCancelUser_Click(object sender, EventArgs e)
        {
            clearData1();
        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            #region//เปิดปุ่ม
            txtUser.Enabled = false;
            txtEmpID.Enabled = false;
            txtEmail.Enabled = true;
            cmbCode.Enabled = true;
            cmbRep.Enabled = true;
            chkAdd.Enabled = true;
            chkEdit.Enabled = true;
            chkDelete.Enabled = true;
            chkApprove.Enabled = true;
            chkCancel.Enabled = true;
            chkPrint.Enabled = true;
            chkEntry.Enabled = true;
            btnSaveDetail.Enabled = true;
            btnCancelDetail.Enabled = true;
            #endregion

            //เรียกข้อมูล
            txtUser.Text = cmbUserID.Text;
            txtEmpID.Text = txtUserEmpID.Text;
            txtEmail.Text = GsysSQL.fncCheckEmail(txtUser.Text);
            fncGetProgram();
            fncGetReport();
            fncLoadDatabyID();
        }

        protected void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncLoadDatabyProgram();
            string lvCheckNew = GsysSQL.fncCheckNew(txtUser.Text, cmbCode.Text);
            if (lvCheckNew == "1") chkAdd.Checked = true;
            if (lvCheckNew == "0") chkAdd.Checked = false;

            string lvCheckEdit = GsysSQL.fncCheckEdit(txtUser.Text, cmbCode.Text);
            if (lvCheckEdit == "1") chkEdit.Checked = true;
            if (lvCheckEdit == "0") chkEdit.Checked = false;

            string lvCheckDel = GsysSQL.fncCheckDelete(txtUser.Text, cmbCode.Text);
            if (lvCheckDel == "1") chkDelete.Checked = true;
            if (lvCheckDel == "0") chkDelete.Checked = false;

            string lvCheckApprove = GsysSQL.fncCheckApprove(txtUser.Text, cmbCode.Text);
            if (lvCheckApprove == "1") chkApprove.Checked = true;
            if (lvCheckApprove == "0") chkApprove.Checked = false;

            string lvCheckCancel = GsysSQL.fncCheckCancel(txtUser.Text, cmbCode.Text);
            if (lvCheckCancel == "1") chkCancel.Checked = true;
            if (lvCheckCancel == "0") chkCancel.Checked = false;

            string lvCheckPrint = GsysSQL.fncCheckPrint(txtUser.Text, cmbCode.Text);
            if (lvCheckPrint == "1") chkPrint.Checked = true;
            if (lvCheckPrint == "0") chkPrint.Checked = false;

            string lvCheckEntry = GsysSQL.fncCheckEntry(txtUser.Text, cmbCode.Text);
            if (lvCheckEntry == "1") chkEntry.Checked = true;
            if (lvCheckEntry == "0") chkEntry.Checked = false;

            #region//เปิดปุ่ม
            txtUser.Enabled = true;
            txtEmpID.Enabled = true;
            txtEmail.Enabled = true;
            cmbCode.Enabled = true;
            cmbRep.Enabled = false;
            chkAdd.Enabled = true;
            chkEdit.Enabled = true;
            chkDelete.Enabled = true;
            chkApprove.Enabled = true;
            chkCancel.Enabled = true;
            chkPrint.Enabled = true;
            chkEntry.Enabled = true;
            btnSaveDetail.Enabled = true;
            btnCancelDetail.Enabled = true;
            #endregion
        }


        protected void cmbRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncLoadDatabyReport();
            string lvCheckNew = GsysSQL.fncCheckNew(txtUser.Text, cmbRep.Text);
            if (lvCheckNew == "1") chkAdd.Checked = true;
            if (lvCheckNew == "0") chkAdd.Checked = false;

            string lvCheckEdit = GsysSQL.fncCheckEdit(txtUser.Text, cmbRep.Text);
            if (lvCheckEdit == "1") chkEdit.Checked = true;
            if (lvCheckEdit == "0") chkEdit.Checked = false;

            string lvCheckDel = GsysSQL.fncCheckDelete(txtUser.Text, cmbRep.Text);
            if (lvCheckDel == "1") chkDelete.Checked = true;
            if (lvCheckDel == "0") chkDelete.Checked = false;

            string lvCheckApprove = GsysSQL.fncCheckApprove(txtUser.Text, cmbRep.Text);
            if (lvCheckApprove == "1") chkApprove.Checked = true;
            if (lvCheckApprove == "0") chkApprove.Checked = false;

            string lvCheckCancel = GsysSQL.fncCheckCancel(txtUser.Text, cmbRep.Text);
            if (lvCheckCancel == "1") chkCancel.Checked = true;
            if (lvCheckCancel == "0") chkCancel.Checked = false;

            string lvCheckPrint = GsysSQL.fncCheckPrint(txtUser.Text, cmbRep.Text);
            if (lvCheckPrint == "1") chkPrint.Checked = true;
            if (lvCheckPrint == "0") chkPrint.Checked = false;

            string lvCheckEntry = GsysSQL.fncCheckEntry(txtUser.Text, cmbRep.Text);
            if (lvCheckEntry == "1") chkEntry.Checked = true;
            if (lvCheckEntry == "0") chkEntry.Checked = false;

            #region//เปิดปุ่ม
            txtUser.Enabled = true;
            txtEmpID.Enabled = true;
            txtEmail.Enabled = true;
            cmbCode.Enabled = false;
            cmbRep.Enabled = true;
            chkAdd.Enabled = true;
            chkEdit.Enabled = true;
            chkDelete.Enabled = true;
            chkApprove.Enabled = true;
            chkCancel.Enabled = true;
            chkPrint.Enabled = true;
            chkEntry.Enabled = true;
            btnSaveDetail.Enabled = true;
            btnCancelDetail.Enabled = true;
            #endregion
        }

        protected void btnCancelDetail_Click(object sender, EventArgs e)
        {
            clearData2();
        }

        protected void btnSaveDetail_Click(object sender, EventArgs e)
        {
            //เปลี่ยนอีเมลล์
            string lvUser = txtUser.Text;
            string lvEmail = txtEmail.Text;
            string lvSQL = "Update sysuser SET us_Email = '" + lvEmail + "' WHERE us_UserID = '" + lvUser + "' ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            //รับค่า
            string lvCode = cmbCode.Text;

            string lvAdd = "";
            if (chkAdd.Checked == true) lvAdd = "1";
            if (chkAdd.Checked == false) lvAdd = "0";

            string lvEdit = "";
            if (chkEdit.Checked == true) lvEdit = "1";
            if (chkEdit.Checked == false) lvEdit = "0";

            string lvDel = "";
            if (chkDelete.Checked == true) lvDel = "1";
            if (chkDelete.Checked == false) lvDel = "0";

            string lvApprove = "";
            if (chkApprove.Checked == true) lvApprove = "1";
            if (chkApprove.Checked == false) lvApprove = "0";

            string lvCancel = "";
            if (chkCancel.Checked == true) lvCancel = "1";
            if (chkCancel.Checked == false) lvCancel = "0";

            string lvPrint = "";
            if (chkPrint.Checked == true) lvPrint = "1";
            if (chkPrint.Checked == false) lvPrint = "0";

            string lvEntry = "";
            if (chkEntry.Checked == true) lvEntry = "1";
            if (chkEntry.Checked == false) lvEntry = "0";

            string lvCheckNewRep = GsysSQL.fncCheckNew(txtUser.Text, cmbRep.Text);
            string lvCheckEditRep = GsysSQL.fncCheckEdit(txtUser.Text, cmbRep.Text);
            string lvCheckDelRep = GsysSQL.fncCheckDelete(txtUser.Text, cmbRep.Text);
            string lvCheckApproveRep = GsysSQL.fncCheckApprove(txtUser.Text, cmbRep.Text);
            string lvCheckCancelRep = GsysSQL.fncCheckCancel(txtUser.Text, cmbRep.Text);
            string lvCheckPrintRep = GsysSQL.fncCheckPrint(txtUser.Text, cmbRep.Text);
            string lvCheckEntryRep = GsysSQL.fncCheckEntry(txtUser.Text, cmbRep.Text);
            string lvCheckNewProm = GsysSQL.fncCheckNew(txtUser.Text, cmbCode.Text);
            string lvCheckEditProm = GsysSQL.fncCheckEdit(txtUser.Text, cmbCode.Text);
            string lvCheckDelProm = GsysSQL.fncCheckDelete(txtUser.Text, cmbCode.Text);
            string lvCheckApproveProm = GsysSQL.fncCheckApprove(txtUser.Text, cmbCode.Text);
            string lvCheckCancelProm = GsysSQL.fncCheckCancel(txtUser.Text, cmbCode.Text);
            string lvCheckPrintProm = GsysSQL.fncCheckPrint(txtUser.Text, cmbCode.Text);
            string lvCheckEntryProm = GsysSQL.fncCheckEntry(txtUser.Text, cmbCode.Text);
            int lvGetLastID = GsysFunc.fncToInt(GsysSQL.fncGetLastID()) + 1;

            //Insert
            if (chkAdd.Checked == true || chkAdd.Checked == false) 
            {
                if (lvCheckNewRep == "" && lvCheckNewProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckNewRep != "" || lvCheckNewProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkEdit.Checked == true || chkEdit.Checked == false) 
            {
                if (lvCheckEditRep == "" && lvCheckEditProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckEditRep != "" || lvCheckEditProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkDelete.Checked == true || chkDelete.Checked == false) 
            {
                if (lvCheckDelRep == "" && lvCheckDelProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckDelRep != "" || lvCheckDelProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkApprove.Checked == true || chkApprove.Checked == false) 
            {
                if (lvCheckApproveRep == "" && lvCheckApproveProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckApproveProm != "" || lvCheckApproveProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkCancel.Checked == true || chkCancel.Checked == false) 
            {
                if (lvCheckCancelRep == "" && lvCheckCancelProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckCancelProm != "" || lvCheckCancelRep != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkPrint.Checked == true || chkPrint.Checked == false) 
            {
                if(lvCheckPrintRep == "" && lvCheckPrintProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckPrintRep != "" || lvCheckPrintProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (chkEntry.Checked == true || chkEntry.Checked == false) 
            {
                if (lvCheckEntryRep == "" && lvCheckEntryProm == "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    lvSQL = "Insert into syspermission (Permission_Id, Permission_Code , Permission_UserID, Permission_New, Permission_Edit, Permission_Del, Permission_AppDoc, Permission_CancelDoc, Permission_Print, Permission_Entry) ";
                    lvSQL += "Values ('" + lvGetLastID + "', '" + lvCodeInsert + "', '" + cmbUserID.Text + "', '" + lvAdd + "', '" + lvEdit + "', '" + lvDel + "', '" + lvApprove + "', '" + lvCancel + "', '" + lvPrint + "', '" + lvEntry + "') ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }

                if (lvCheckEntryRep != "" || lvCheckEntryProm != "")
                {
                    string lvCodeInsert = "";

                    if (cmbCode.Text != "" && cmbRep.Text == "")
                    {
                        lvCodeInsert = cmbCode.Text;
                    }
                    else if (cmbCode.Text == "" && cmbRep.Text != "")
                    {
                        lvCodeInsert = cmbRep.Text;
                    }

                    //Update ลงใน DT
                    lvSQL = "Update syspermission SET Permission_New = '" + lvAdd + "', Permission_Edit = '" + lvEdit + "', Permission_Del = '" + lvDel + "', Permission_AppDoc = '" + lvApprove + "', Permission_CancelDoc = '" + lvCancel + "', Permission_Print = '" + lvPrint + "', Permission_Entry = '" + lvEntry + "' ";
                    lvSQL += "WHERE Permission_UserID = '" + lvUser + "' And Permission_Code = '" + lvCodeInsert + "' ";
                    lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            clearData2();
            fncLoadDatabyID();
            btnEditUser_Click(sender, e);
        }
        #endregion

    }
}