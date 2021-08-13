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
                //FncCheckLoginWeb();
                cmb_SearchDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fncLoadData();
                //GridViewFeaturesHelper.SetupGlobalGridViewBehavior(GridV1);
            }

            FncClearLogin();
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
            var lvSQL = "Select * From I_Images inner Join Queue_Diary ON I_Images.I_QNo = Queue_Diary.Q_No Where Q_Year = '' ";
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
            var SQL = "";
            var Success = "";

            SQL = "Delete From Systemp";
            Success = GsysSQL.fncExecuteQueryDataSQL(SQL);

            var items = QList.Items.Count;

            var lvQ = "";
            var lvDate = "";
            var lvDateNow = DateTime.Now.ToString("dd/MM/yyyy");
            var lvTime = "";
            var lvRail = "";
            var lvDump = "";
            var lvCarNum = "";
            var lvCarNum2 = "";
            var lvName30 = "";
            var lvName45 = "";
            var lvName90 = "";
            var lvQuota = "";
            var lvCaneType = "";
            var lvFirstName = "";
            var lvLastName = "";
            var lvName = "";

            var Status = cmb_Status.Text;
            var Remark = txt_Remark.Text;

            for (int i = 0; i < items; i++)
            {
                DataTable DT = new DataTable();

                var SearchItem = QList.Items[i];
                SQL = "Select * From I_Images Inner Join Queue_Diary On I_Images.I_QNo = Queue_Diary.Q_No INNER JOIN Cane_Quota ON Cane_Quota.Q_ID = Queue_Diary.Q_Quota INNER JOIN Cane_CaneType ON Queue_Diary.Q_CaneType = Cane_CaneType.C_ID Where I_QNo = '" + SearchItem + "' And Q_Year = '' ";
                DT = GsysSQL.fncGetQueryDataSQL(SQL, DT);

                for (int k = 0; k < DT.Rows.Count; k++)
                {
                    lvQ = DT.Rows[k]["I_QNo"].ToString(); //1
                    lvDate = GsysFunc.fncChangeSDate(DT.Rows[k]["I_Date"].ToString()); //2
                    lvTime = DT.Rows[k]["I_Time"].ToString(); //3
                    lvRail = DT.Rows[k]["I_Rail"].ToString(); //4
                    lvDump = DT.Rows[k]["I_Dump"].ToString(); //5
                    lvName30 = DT.Rows[k]["I_Name_30"].ToString(); //6
                    lvName45 = DT.Rows[k]["I_Name_45"].ToString(); //7
                    lvName90 = DT.Rows[k]["I_Name_90"].ToString(); //8
                    lvCarNum = DT.Rows[k]["Q_CarNum"].ToString(); //9
                    lvCarNum2 = GsysSQL.fncGetCarnum2(lvQ);
                    lvQuota = DT.Rows[k]["Q_Quota"].ToString(); //10
                    lvCaneType = DT.Rows[k]["C_Name"].ToString(); //13
                    lvFirstName = DT.Rows[k]["Q_FirstName"].ToString(); //11
                    lvLastName = DT.Rows[k]["Q_LastName"].ToString(); //12
                    lvName = lvFirstName + " " + lvLastName;

                    SQL = "Insert Into SysTemp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9, S_Fieid10, S_Fieid11, S_Fieid12, S_Fieid13, S_Fieid14, S_Fieid15, S_Fieid16, S_Fieid17, S_Fieid18) " +
                        "Values ('" + lvQ + "', '" + lvDate + "', '" + lvTime + "', '" + lvRail + "', '" + lvDump + "', '" + lvName30 + "', '" + lvName45 + "', '" + lvName90 + "', '" + Status + "', '" + Remark + "', '" + lvCarNum + "', '" + lvQuota + "', '" + lvFirstName + "', '" + lvLastName + "', '" + lvName + "', '" + lvCaneType + "', '" + lvCarNum2 + "', '" + lvDateNow + "')";
                    Success = GsysSQL.fncExecuteQueryDataSQL(SQL);
                }
            }

            if (Success == "Success")
            {
                if(chk_Typegood.Checked == false || chk_Typebad.Checked == false)
                {

                }

                if (chk_Typegood.Checked)
                {
                    Response.Redirect("frmShowReport.aspx");
                }
                if (chk_Typebad.Checked)
                {
                    Response.Redirect("frmShowReport2.aspx");
                }
            }
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            fncSearchDetail();
        }

        private void fncSearchDetail()
        {
            DataTable DT = new DataTable();
            var Q_no = txt_QNo.Text;
            var Q_no2 = Q_no + ".1";
            var Rail = cmb_Rail.Text;
            var Date = GsysFunc.fncChangeTDate(cmb_SearchDate.Text);
            var Ka = cmb_Ka.Text;
            var Dump = cmb_Dump.Text;
            var Time = cmb_Time.Text;
            string[] TimeSplit = Time.Split(':');
            var Times = TimeSplit[0];

            var SQL = "Select TOP 10 * From I_Images inner Join Queue_Diary ON I_Images.I_QNo = Queue_Diary.Q_No where 1 = 1 ";

            if(Q_no != "")
            {
                SQL += "And I_QNo = '" + Q_no + "' ";
            }

            if(Rail != "เลือก")
            {
                SQL += "And I_Rail = '" + Rail + "' ";
            }

            if(Date != "")
            {
                SQL += "And I_Date = '" + Date + "' ";
            }

            if(Dump != "")
            {
                SQL += "And I_Dump = '" + Dump + "' ";
            }

            if(Times != "")
            {
                SQL += "And I_Time LIKE '%" + Times + "%' ";
            }

            SQL += "And Q_Year = ''";

            DT = GsysSQL.fncGetQueryDataSQL(SQL, DT);

            int Numrow = DT.Rows.Count;

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

            for (int i = 0; i < Numrow; i++)
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

        protected void GridV1_PageIndexChanged(object sender, EventArgs e)
        {
            fncLoadData();
        }

        private void FncCheckLoginWeb()
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;

            string lvCookieUser = "";
            string lvOnline = "";

            //ถ้าขึ้นต้นด้วยไอพี ไม่ต้อง Login
            if (url.Contains("10.104.1.9"))
            {
                //ไม่ต้อง Login
            }
            else
            {
                //ดึงข้อมูล User เพื่อนำมาเช็คสถานะออนไลน์
                lvCookieUser = FncReadCookie("Login", "Username");

                //ถ้า Login ออนไลน์ไว้อยู่แล้วก็แสดงข้อมูลต่อได้เลย ถ้าไม่ ให้ Login ใหม่
                lvOnline = GsysSQL.fncCheckOnlineStatus(lvCookieUser);

                if (lvOnline != "")
                {
                    string lvDateNow = GsysFunc.fncChangeTDate(DateTime.Now.ToString("dd/MM/yyyy"));
                    string lvTimeNow = DateTime.Now.ToString("HHmmss");

                    //ถ้าออนไลน์ให้บันทึก LastUpdate ไปใหม่
                    string lvSQL = "Update SysLoginTable set L_Update = '" + lvDateNow + lvTimeNow + "' Where L_UserName = '" + lvCookieUser + "' ";
                    string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                }
                else
                {
                    //MessageboxAlert("ไม่พบข้อมูลผู้ใช้ของท่าน กรุณาเข้าสู่ระบบใหม่อีกครั้ง");

                    //สร้าง Cookie ส่งข้อมูล Url
                    FncCreateCookie("Url", "LastUrl", url);

                    //ถ้าไม่ออนไลน์ให้ Login ใหม่
                    string lvUrlNew = "/LoginMonitor.aspx";// + "?LastUrl=" + url
                    Response.Redirect(lvUrlNew);
                }
            }
        }

        private void FncClearLogin()
        {
            string lvSQL = "";
            string lvResault = "";
            string lvDateNow = GsysFunc.fncChangeTDate(DateTime.Now.ToString("dd/MM/yyyy"));
            string lvTimeNow = DateTime.Now.ToString("HHmmss");
            string lvDateDiff = GsysFunc.fncChangeTDate(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));

            lvSQL = "Delete From SysLoginTable Where L_Update < '" + lvDateDiff + lvTimeNow + "' ";
            lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
        }

        private string FncReadCookie(string lvKeys, string lvName)
        {
            string lvReturn = "Success";

            try
            {
                lvReturn = Request.Cookies[lvKeys][lvName];
            }
            catch (Exception ex)
            {
                lvReturn = ex.Message;
            }

            return lvReturn;
        }

        private void FncCreateCookie(string lvKeyName, string lvName, string lvData)
        {
            //*** Instance of the HttpCookies ***//
            HttpCookie newCookie = new HttpCookie(lvKeyName);
            newCookie[lvName] = lvData;
            newCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(newCookie);
        }

        private void FncDeleteCookie(string lvKeyName)
        {
            HttpCookie delCookie1;
            delCookie1 = new HttpCookie(lvKeyName);
            delCookie1.Expires = DateTime.Now.AddDays(-1D);
            Response.Cookies.Add(delCookie1);
        }
    }
}