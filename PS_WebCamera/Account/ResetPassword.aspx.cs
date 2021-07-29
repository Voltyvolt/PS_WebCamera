using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using PS_WebCamera.Models;

namespace PS_WebCamera
{
    public partial class ResetPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserID.Focus();
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            string lvUser = txtUserID.Text;
            string lvEmail = txtEmail.Text;

            //เช็ค Email
            string lvChkMail = GsysSQL.fncCheckEmail(lvUser);
            if (lvChkMail != lvEmail)
            {
                Response.Write("<script>alert('รหัสผู้ใช้งาน หรือ Email ไม่ถูกต้อง กรุณาตรวจสอบใหม่อีกครั้ง !!')</script>");
                txtUserID.Focus();
                return;
            }

            //สุ่มรหัสผ่าน 6 หลัก
            Random rnd = new Random();
            int lvNumBer = rnd.Next(100000, 999999);  // creates a number between 100000 and 999999
            string lvNewPass = lvNumBer.ToString();

            //ส่งเมล
            string lvSubject = "รีเซ็ตรหัสผ่าน สำหรับเข้าใช้งานโปรแกรม";
            string lvMsg = "<CENTER><font size = '12'><b>ท่านได้รีเซ็ตรหัสผ่าน เรียบร้อยแล้ว</b></font></CENTER><br> ";
            lvMsg += "<CENTER>รหัสผ่านใหม่</CENTER><br> ";
            lvMsg += "<CENTER><font size = '50'><b>" + lvNewPass + "</b></font></CENTER><br>";
            lvMsg += "<CENTER>**หลักจากเข้าใช้งานโปรแกรมได้แล้วกรุณาเปลี่ยนรหัสใหม่ตามที่ท่านต้องการ**</CENTER>";
            string lvResault = GsysFunc.FncSendMail(lvMsg,lvEmail,lvSubject);

            if (lvResault == "Success")
            {
                //Update รหัสผ่าน
                string lvSQL = "update sysuser set us_Password = '" + lvNewPass + "' where us_UserID = '" + lvUser + "' ";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                if (lvResault == "Success")
                {
                    Response.Redirect("/Account/ResetPassSuccess.aspx");
                }
                else
                {
                    Response.Write("<script>alert('" + lvResault + "')</script>");
                }
            }
        }
    }
}