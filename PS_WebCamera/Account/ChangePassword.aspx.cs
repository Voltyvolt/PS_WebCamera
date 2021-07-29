using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PS_WebCamera;


namespace PS_WebCamera {
    public partial class ChangePassword : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbCurrentPassword.Focus();
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string lvUserName = Session["UserName"].ToString();
            string lvOldPass = tbCurrentPassword.Text;
            string lvPass = tbPassword.Text;
            string lvConfirmPass = tbConfirmPassword.Text;

            //เช็คข้อมูล
            if (lvPass != lvConfirmPass)
            {
                Response.Write("<script>alert('รหัสผ่าน กับ ยืนยันรหัสผ่านไม่ตรงกัน ')</script>");
                tbPassword.Text = "";
                tbConfirmPassword.Text = "";
                tbPassword.Focus();
                return;
            }

            //เช็ค รหัสเดิม ว่าถูกหรือไม่?
            string lvChkPass = GsysSQL.fncCheckPass(lvUserName);
            if (lvOldPass != lvChkPass)
            {
                Response.Write("<script>alert('รหัสผ่านเดิมไม่ถูกต้อง กรุณาระบุใหม่อีกครั้ง')</script>");
                tbCurrentPassword.Focus();
                return;
            }

            //Update รหัสผ่าน
            string lvSQL = "update sysuser set us_Password = '"+ lvPass + "' where us_UserID = '"+ lvUserName + "' ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            if (lvResault == "Success")
            {
                Session["UserName"] = null;
                Response.Redirect("/Account/ChangePasswordSuccess.aspx");
            }
            else
            {
                Response.Write("<script>alert('" + lvResault + "')</script>");
            }
        }

    }
}