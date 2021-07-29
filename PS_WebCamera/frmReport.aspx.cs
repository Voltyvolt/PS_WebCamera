using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_WebCamera
{
    public partial class frmReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

            }
            else
            {
                fncLoadData();
                //GridViewFeaturesHelper.SetupGlobalGridViewBehavior(GridV1);
            }
        }

        protected void cmb_Ka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Ka.SelectedIndex == 1)
            {
                cmb_Time.Items.Clear();
                cmb_Time.Items.Add("08:00 - 09:00");
                cmb_Time.Items.Add("09:00 - 10:00");
                cmb_Time.Items.Add("10:00 - 11:00");
                cmb_Time.Items.Add("11:00 - 12:00");
                cmb_Time.Items.Add("12:00 - 13:00");
                cmb_Time.Items.Add("13:00 - 14:00");
                cmb_Time.Items.Add("14:00 - 15:00");
                cmb_Time.Items.Add("15:00 - 16:00");
                cmb_Time.Items.Add("16:00 - 17:00");
                cmb_Time.Items.Add("17:00 - 18:00");
                cmb_Time.Items.Add("18:00 - 19:00");
                cmb_Time.Items.Add("19:00 - 20:00");
            }
            else if (cmb_Ka.SelectedIndex == 2)
            {
                cmb_Time.Items.Clear();
                cmb_Time.Items.Add("20:00 - 21:00");
                cmb_Time.Items.Add("21:00 - 22:00");
                cmb_Time.Items.Add("22:00 - 23:00");
                cmb_Time.Items.Add("23:00 - 24:00");
                cmb_Time.Items.Add("24:00 - 01:00");
                cmb_Time.Items.Add("01:00 - 02:00");
                cmb_Time.Items.Add("02:00 - 03:00");
                cmb_Time.Items.Add("03:00 - 04:00");
                cmb_Time.Items.Add("04:00 - 05:00");
                cmb_Time.Items.Add("05:00 - 06:00");
                cmb_Time.Items.Add("06:00 - 07:00");
                cmb_Time.Items.Add("07:00 - 08:00");
            }
            else
            {
                cmb_Time.Items.Clear();
            }

            cmb_Time.SelectedIndex = 0;
        }

        public void fncLoadData()
        {
            DataTable DT = new DataTable();
            var lvSQL = "Select TOP 10 * From I_Images inner Join Queue_Diary ON I_Images.I_QNo = Queue_Diary.Q_No";
            DT = GsysSQL.fncGetQueryDataSQL(lvSQL, DT);

            var lvNumRow = DT.Rows.Count;

            DataTable DTNew = new DataTable();
            DTNew.Columns.Add("Q_Quota");
            DTNew.Columns.Add("Q_CarNum");
            DTNew.Columns.Add("I_Rail");
            DTNew.Columns.Add("I_Dump");
            DTNew.Columns.Add("I_Date");
            DTNew.Columns.Add("I_Time");
            DTNew.Columns.Add("I_QNo");
            DTNew.Columns.Add("I_Name_30");
            DTNew.Columns.Add("I_Name_45");
            DTNew.Columns.Add("I_Name_90");

            for (int i = 0; i < lvNumRow; i++)
            {
                var lvField1 = DT.Rows[i]["Q_Quota"].ToString();
                var lvField2 = DT.Rows[i]["Q_CarNum"].ToString();
                var lvField3 = DT.Rows[i]["I_Rail"].ToString();
                var lvField4 = DT.Rows[i]["I_Dump"].ToString();
                var lvField5 = GsysFunc.fncChangeSDate(DT.Rows[i]["I_Date"].ToString());
                var lvField6 = DT.Rows[i]["I_Time"].ToString();
                var lvField7 = DT.Rows[i]["I_QNo"].ToString();
                var lvField8 = DT.Rows[i]["I_Name_30"].ToString();
                var lvField9 = DT.Rows[i]["I_Name_45"].ToString();
                var lvField10 = DT.Rows[i]["I_Name_90"].ToString();

                DTNew.Rows.Add(new object[] { lvField1, lvField2, lvField3, lvField4, lvField5, lvField6, lvField7, lvField8, lvField9, lvField10 });

                GridV1.DataSource = null;
                GridV1.DataSource = DTNew;
                GridV1.DataBind();
                DT.Dispose();
            }
        }

        protected void btn_Print_Click(object sender, EventArgs e)
        {
            var items = QList.Items.Count;

            for (int i = 0; i < items; i++)
            {
                var lvOne = 
            }
        }
    }
}