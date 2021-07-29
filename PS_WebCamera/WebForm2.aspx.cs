using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_WebCamera
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            string lvPath = "V:\\PicTakow\\A\\3\\A_D3_30_202106221141.jpg";
            ASPxImage1.ImageUrl = lvPath;
        }
    }
}