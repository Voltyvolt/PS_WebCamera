using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSAdmin
{
    public partial class frmReportlist : System.Web.UI.Page
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
        }
    }
}