using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_WebCamera.PS_CaneData
{
    public partial class frmQuota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region //เช็คถ้าไม่ได้ Login ให้ไป Login ก่อน
            if (Session["UserName"] == null || Session["UserName"].ToString() == "")
            {
                Response.Redirect("~/Account/LoginAlertMessage.aspx");
                Response.End();
            }
            #endregion

            if (IsPostBack)
            {

            }
            else
            {
                Session["Mode"] = "";
                LoadData();
            }
        }

        private void LoadData()
        {            
            string lvSQL = "SELECT * FROM cane_quota ";

            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            ASPxGridView1.DataSource = null;
            ASPxGridView1.DataSource = DT;
            ASPxGridView1.DataBind();
        }

        protected void ASPxGridView1_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.VisibleIndex);
            string lvPK = ASPxGridView1.GetRowValues(index, "Q_ID").ToString();

            if (e.CommandArgs.CommandName == "E")
            {
                Session["Mode"] = "Edit";

                LoadQuota(lvPK);
            }
        }

        private void LoadQuota(string lvID)
        {
            string lvSQL = "Select * from Cane_Quota Where Q_ID = '"+ lvID +"'";

            DataTable DT = new DataTable();
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;

            for (int i = 0; i < lvNumRow; i++)
            {
                txtQuota.Text = DT.Rows[i]["Q_ID"].ToString();
                txtName.Text = DT.Rows[i]["Q_FirstName"].ToString();
                txtLName.Text = DT.Rows[i]["Q_LastName"].ToString();
                txtCard.Text = DT.Rows[i]["Q_CardID"].ToString();
                txtAddress.Text = DT.Rows[i]["Q_Address"].ToString();
                txtKet.Text = DT.Rows[i]["Q_Ket"].ToString();
                txtSai.Text = DT.Rows[i]["Q_KetDisplay"].ToString();
            }

            DT.Dispose();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string lvSQL = "";
            string lvResault = "";

            string lvQuota = txtQuota.Text;
            string lvName = txtName.Text;
            string lvLName = txtLName.Text;
            string lvCard = txtCard.Text;
            string lvAddress = txtAddress.Text;
            string lvKet = txtKet.Text;
            string lvSai = txtSai.Text;

            if (Session["Mode"] == "")
            {
                //Insert
                lvSQL = "Insert into Cane_Quota (Q_ID, Q_FirstName, Q_LastName, Q_CardID, Q_Address, Q_Ket, Q_KetDisplay) ";
                lvSQL += "values('" + lvQuota + "','" + lvName + "', '" + lvLName + "', '" + lvCard + "', '" + lvAddress + "', '" + lvKet + "', '" + lvSai + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
            }
            else if (Session["Mode"] == "Edit")
            {
                //Update
                lvSQL = "Update Cane_Quota set Q_FirstName = '"+ lvName + "', Q_LastName = '" + lvLName + "', Q_CardID = '" + lvCard + "', Q_Address = '" + lvAddress + "', Q_Ket = '" + lvKet + "', Q_KetDisplay = '" + lvSai + "' ";
                lvSQL += "Where Q_ID = '"+ lvQuota + "'";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
            }

            if (lvResault == "Success")
                MessageboxAlert("บันทึกข้อมูลเรียบร้อย");

            //ล้างข้อมูล
            btnClear_Click(sender, e);
        }

        private void FncChkEmptryText(bool lvStatus)
        {
            txtQuota.ValidationSettings.RequiredField.IsRequired = lvStatus;
            txtName.ValidationSettings.RequiredField.IsRequired = lvStatus;
            txtLName.ValidationSettings.RequiredField.IsRequired = lvStatus;
            //txtCard.ValidationSettings.RequiredField.IsRequired = lvStatus;
            //txtAddress.ValidationSettings.RequiredField.IsRequired = lvStatus;
            txtKet.ValidationSettings.RequiredField.IsRequired = lvStatus;
            //txtSai.ValidationSettings.RequiredField.IsRequired = lvStatus;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtQuota.Text = "";
            txtName.Text = "";
            txtLName.Text = "";
            txtCard.Text = "";
            txtAddress.Text = "";
            txtKet.Text = "";
            txtSai.Text = "";

            Session["Mode"] = "";
            LoadData();
        }

        private void MessageboxAlert(string lvMessage)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + lvMessage + "');", true);
        }

        protected void ASPxGridView1_PageIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}