using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Microsoft.AspNet.Identity.Owin;

namespace PSAdmin {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูล
            string lvChkUser = GsysSQL.fncCheckLogin(txtUser.Text, txtPass.Text);

            if (lvChkUser != "")
            {
                Session["UserName"] = lvChkUser.ToUpper();

                Response.Redirect("/Default.aspx");
                Response.End();
            }
            else
            {
                Response.Write("<script>alert('ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง')</script>");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                return;
            }

            lbAlert.Text = "เรียบร้อย";
        }
    }
}