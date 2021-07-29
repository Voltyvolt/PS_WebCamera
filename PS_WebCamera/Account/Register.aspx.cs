using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PS_WebCamera.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace PS_WebCamera {
    public partial class Register : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string lvUser = txtUser.Text;
            string lvPass = txtPass.Text;
            string lvConfirmPass = txtConfirmPass.Text;
            string lvEmpID = txtEmpID.Text;
            string lvEmail = txtEmail.Text;

            //�礢�����
            if (lvPass != lvConfirmPass)
            {
                Response.Write("<script>alert('���ʼ�ҹ �Ѻ �׹�ѹ���ʼ�ҹ���ç�ѹ ')</script>");
                txtPass.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Focus();
                return;
            }

            //�� User ����������?
            string lvChkUser = GsysSQL.fncCheckUser(lvUser);
            if (lvChkUser != "")
            {
                Response.Write("<script>alert('���ʼ����ҹ��� ��١������� ��س�����¹���ʼ����ҹ���')</script>");
                txtUser.Focus();
                return;
            }

            //Insert
            string lvSQL = "Insert into sysuser (us_UserID,us_Password,us_EmpID,us_Email,us_Active) ";
            lvSQL += "Values ('"+ lvUser + "','" + lvPass + "','" + lvEmpID + "','" + lvEmail + "','1') ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            if (lvResault == "Success")
            {
                //Response.Write("<script>alert('ŧ����¹���º����')</script>");
                Response.Redirect("/Account/RegisterSuccess.aspx");
            }
            else
            {
                Response.Write("<script>alert('"+ lvResault + "')</script>");
            }
        }
    }
}