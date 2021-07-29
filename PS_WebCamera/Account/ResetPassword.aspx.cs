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

            //�� Email
            string lvChkMail = GsysSQL.fncCheckEmail(lvUser);
            if (lvChkMail != lvEmail)
            {
                Response.Write("<script>alert('���ʼ����ҹ ���� Email ���١��ͧ ��سҵ�Ǩ�ͺ�����ա���� !!')</script>");
                txtUserID.Focus();
                return;
            }

            //�������ʼ�ҹ 6 ��ѡ
            Random rnd = new Random();
            int lvNumBer = rnd.Next(100000, 999999);  // creates a number between 100000 and 999999
            string lvNewPass = lvNumBer.ToString();

            //�����
            string lvSubject = "�������ʼ�ҹ ����Ѻ�����ҹ�����";
            string lvMsg = "<CENTER><font size = '12'><b>��ҹ���������ʼ�ҹ ���º��������</b></font></CENTER><br> ";
            lvMsg += "<CENTER>���ʼ�ҹ����</CENTER><br> ";
            lvMsg += "<CENTER><font size = '50'><b>" + lvNewPass + "</b></font></CENTER><br>";
            lvMsg += "<CENTER>**��ѡ�ҡ�����ҹ����������ǡ�س�����¹��������������ҹ��ͧ���**</CENTER>";
            string lvResault = GsysFunc.FncSendMail(lvMsg,lvEmail,lvSubject);

            if (lvResault == "Success")
            {
                //Update ���ʼ�ҹ
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