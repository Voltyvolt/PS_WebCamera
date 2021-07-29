using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_WebCamera
{
    public partial class frmMatching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                //cmb_SearchDate.Text = GVar.gvDate;
            }
            else
            {
                cmb_SearchDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                GVar.gvDate = cmb_SearchDate.Text;
                fncLoadData();
                //fncGetAllfile();

                //ปิดปุ่ม
                btnAdd1F.Enabled = false;
                btnAdd1S.Enabled = false;
                btnAdd1T.Enabled = false;

                btnAdd2F.Enabled = false;
                btnAdd2S.Enabled = false;
                btnAdd2T.Enabled = false;

                btnAdd3F.Enabled = false;
                btnAdd3S.Enabled = false;
                btnAdd3T.Enabled = false;

                btnAdd4F.Enabled = false;
                btnAdd4S.Enabled = false;
                btnAdd4T.Enabled = false;

                btnAdd5F.Enabled = false;
                btnAdd5S.Enabled = false;
                btnAdd5T.Enabled = false;

                btnAdd6F.Enabled = false;
                btnAdd6S.Enabled = false;
                btnAdd6T.Enabled = false;

                btn_After.Enabled = false;
                btn_Next.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Cancel.Enabled = false;
            }
            
        }

        protected void cmb_Ka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Ka.SelectedIndex == 1)
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
            else if(cmb_Ka.SelectedIndex == 2)
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

        private void fncLoadData()
        {
            DataTable DT = new DataTable();
            string lvSQL = "Select * From I_Images";
            DT = GsysSQL.fncGetQueryDataSQL(lvSQL, DT);

            int lvNumrows = DT.Rows.Count;

            DataTable DTNew = new DataTable();
            DTNew.Columns.Add("I_Rail");
            DTNew.Columns.Add("I_Dump");
            DTNew.Columns.Add("I_Date");
            DTNew.Columns.Add("I_Time");
            DTNew.Columns.Add("I_Name_30");
            DTNew.Columns.Add("I_Name_45");
            DTNew.Columns.Add("I_Name_90");

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvField1 = DT.Rows[i]["I_Rail"].ToString();
                string lvField2 = DT.Rows[i]["I_Dump"].ToString();
                string lvField3 = GsysFunc.fncChangeSDate(DT.Rows[i]["I_Date"].ToString());
                string lvField4 = DT.Rows[i]["I_Time"].ToString();
                string lvField5 = DT.Rows[i]["I_Name_30"].ToString();
                string lvField6 = DT.Rows[i]["I_Name_45"].ToString();
                string lvField7 = DT.Rows[i]["I_Name_90"].ToString();

                DTNew.Rows.Add(new object[] { lvField1, lvField2, lvField3, lvField4, lvField5, lvField6, lvField7 });
            }

            //ปิดปุ่ม
            btnAdd1F.Enabled = true;
            btnAdd1S.Enabled = true;
            btnAdd1T.Enabled = true;

            btnAdd2F.Enabled = true;
            btnAdd2S.Enabled = true;
            btnAdd2T.Enabled = true;

            btnAdd3F.Enabled = true;
            btnAdd3S.Enabled = true;
            btnAdd3T.Enabled = true;

            btnAdd4F.Enabled = true;
            btnAdd4S.Enabled = true;
            btnAdd4T.Enabled = true;

            btnAdd5F.Enabled = true;
            btnAdd5S.Enabled = true;
            btnAdd5T.Enabled = true;

            btnAdd6F.Enabled = true;
            btnAdd6S.Enabled = true;
            btnAdd6T.Enabled = true;

            btn_After.Enabled = true;
            btn_Next.Enabled = true;

            GridV1.DataSource = null;
            GridV1.DataSource = DTNew;
            GridV1.DataBind();
            DT.Dispose();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            fncGetAllfile();
        }

        protected void GridV1_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.VisibleIndex);

            string lvDump = GridV1.GetRowValues(index, "I_Dump").ToString();
            string lvDate = GsysFunc.fncChangeTDate(GridV1.GetRowValues(index, "I_Date").ToString());
            string lvTime = GridV1.GetRowValues(index, "I_Time").ToString();
            string lvRail = GridV1.GetRowValues(index, "I_Rail").ToString();
            string lvName30 = "";
            string lvName45 = "";
            string lvName90 = "";

            ASPxImage1.ImageUrl = "";
            lbName1.Text = "รูปที่ 1";
            ASPxImage2.ImageUrl = "";
            lbName2.Text = "รูปที่ 2";
            ASPxImage3.ImageUrl = "";
            lbName3.Text = "รูปที่ 3";

            if(e.CommandArgs.CommandName == "E")
            {
                DataTable DT = new DataTable();
                string lvSQL = "Select * From I_Images INNER JOIN Queue_Diary ON I_Images.I_QNo = Queue_Diary.Q_No Where I_Date = '" + lvDate + "' And I_Time = '" + lvTime + "' And I_Rail = '" + lvRail + "' And I_Dump = '" + lvDump + "' ";
                DT = GsysSQL.fncGetQueryDataSQL(lvSQL, DT);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    txtDate.Text = GsysFunc.fncChangeSDate(DT.Rows[i]["I_Date"].ToString());
                    txtTime.Text = DT.Rows[i]["I_Time"].ToString();
                    txtDump.Text = DT.Rows[i]["I_Dump"].ToString();
                    txtQNo.Text = DT.Rows[i]["I_QNo"].ToString();
                    txtQuota.Text = DT.Rows[i]["Q_Quota"].ToString();
                    string lvCarNum = DT.Rows[i]["Q_CarNum"].ToString();
                    txtCarNum.Text = lvCarNum.Replace('a', '.');
                    lvName30 = DT.Rows[i]["I_Name_30"].ToString();
                    lbName1.Text = lvName30;
                    lvName45 = DT.Rows[i]["I_Name_45"].ToString();
                    lbName2.Text = lvName45;
                    lvName90 = DT.Rows[i]["I_Name_90"].ToString();
                    lbName3.Text = lvName90;

                    string lvPath = "/PicTakow/" + lvRail + "/" + lvDump + "/";
                    this.ASPxImage1.ImageUrl = lvPath + lvName30;
                    ASPxImage1.DataBind();
                    this.ASPxImage2.ImageUrl = lvPath + lvName45;
                    ASPxImage2.DataBind();
                    this.ASPxImage3.ImageUrl = lvPath + lvName90;
                    ASPxImage3.DataBind();

                    btn_Delete.Enabled = true;
                    btn_Cancel.Enabled = true;
                }
            }
        }

        private void fncGetAllfile()
        {
            try
            {
                //ซ่อนกล่อง + ปุ่ม
                AspImageShow1.ImageUrl = "";
                btnAdd1F.Enabled = false;
                btnAdd1S.Enabled = false;
                btnAdd1T.Enabled = false;

                AspImageShow2.ImageUrl = "";
                btnAdd2F.Enabled = false;
                btnAdd2S.Enabled = false;
                btnAdd2T.Enabled = false;

                AspImageShow3.ImageUrl = "";
                btnAdd3F.Enabled = false;
                btnAdd3S.Enabled = false;
                btnAdd3T.Enabled = false;

                AspImageShow4.ImageUrl = "";
                btnAdd4F.Enabled = false;
                btnAdd4S.Enabled = false;
                btnAdd4T.Enabled = false;

                AspImageShow5.ImageUrl = "";
                btnAdd5F.Enabled = false;
                btnAdd5S.Enabled = false;
                btnAdd5T.Enabled = false;

                AspImageShow6.ImageUrl = "";
                btnAdd6F.Enabled = false;
                btnAdd6S.Enabled = false;
                btnAdd6T.Enabled = false;

                if(cmb_Rail.Text == "-- เลือก --")
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('กรุณาเลือกราง');</script>");
                    return;
                }

                if(cmb_Time.Text == "")
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('กรุณาเลือกช่วงเวลา');</script>");
                    return;
                }

                if(cmb_Dump.Text == "")
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('กรุณาเลือกดั้ม');</script>");
                    return;
                }

                
                string lvRail = cmb_Rail.Text; //ราง
                string lvDump = cmb_Dump.Text; //ดั้ม
                string lvDate = GsysFunc.fncChangeTDate(cmb_SearchDate.Text); //วันที่
                string lvTime = cmb_Time.Text; //เวลา
                string lvPathMode = "/PicTakow/" + lvRail + "/" + lvDump + "/"; //Path ไฟล์รูปภาพ
                GVar.gvPathMode = lvPathMode; //เก็บตัวแปรไว้กดปุ่มถัดไป
                string[] lvTimeSplit = lvTime.Split(':'); //Split เวลา

                //ฟังก์ชั่น Contain string
                string lvContains = "*" + lvDate + lvTimeSplit[0] + "*";
            
                string[] allFile = Directory.GetFiles(GVar.gvPathMode, lvContains, SearchOption.AllDirectories); //เลือกไฟล์ทั้งหมดใน Folder ลงใน Array
            
                int arrayFileNumber = allFile.Length; //นับจำนวนไฟล์ใน Array

                GVar.gvPicNum = 0;

                txtDate.Text = cmb_SearchDate.Text;
                txtDump.Text = cmb_Dump.Text;

                //เปิดปุ่มย้อนกลับ + ถัดไป
                btn_Next.Enabled = true;
                btn_After.Enabled = true;
                
                string lvPic1 = allFile[GVar.gvPicNum];
                string[] lvPic1Split = lvPic1.Split('/');
                string lvPicFileName1 = GVar.gvPathMode + lvPic1Split[4];
                AspImageShow1.ImageUrl = lvPicFileName1;
                AspImageShow1.DataBind();
                btnAdd1F.Enabled = true;
                btnAdd1S.Enabled = true;
                btnAdd1T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName1 + "');</script>");

                string lvPic2 = allFile[GVar.gvPicNum + 1];
                string[] lvPic2Split = lvPic2.Split('/');
                string lvPicFileName2 = GVar.gvPathMode + lvPic2Split[4];
                AspImageShow2.ImageUrl = lvPicFileName2;
                AspImageShow2.DataBind();
                btnAdd2F.Enabled = true;
                btnAdd2S.Enabled = true;
                btnAdd2T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName2 + "');</script>");

                string lvPic3 = allFile[GVar.gvPicNum + 2];
                string[] lvPic3Split = lvPic3.Split('/');
                string lvPicFileName3 = GVar.gvPathMode + lvPic3Split[4];
                AspImageShow3.ImageUrl = lvPicFileName3;
                AspImageShow3.DataBind();
                btnAdd3F.Enabled = true;
                btnAdd3S.Enabled = true;
                btnAdd3T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName3 + "');</script>");

                string lvPic4 = allFile[GVar.gvPicNum + 3];
                string[] lvPic4Split = lvPic4.Split('/');
                string lvPicFileName4 = GVar.gvPathMode + lvPic4Split[4];
                AspImageShow4.ImageUrl = lvPicFileName4;
                AspImageShow4.DataBind();
                btnAdd4F.Enabled = true;
                btnAdd4S.Enabled = true;
                btnAdd4T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName4 + "');</script>");

                string lvPic5 = allFile[GVar.gvPicNum + 4];
                string[] lvPic5Split = lvPic5.Split('/');
                string lvPicFileName5 = GVar.gvPathMode + lvPic5Split[4];
                AspImageShow5.ImageUrl = lvPicFileName5;
                AspImageShow5.DataBind();
                btnAdd5F.Enabled = true;
                btnAdd5S.Enabled = true;
                btnAdd5T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName5 + "');</script>");

                string lvPic6 = allFile[GVar.gvPicNum + 5];
                string[] lvPic6Split = lvPic6.Split('/');
                string lvPicFileName6 = GVar.gvPathMode + lvPic6Split[4];
                AspImageShow6.ImageUrl = lvPicFileName6;
                AspImageShow6.DataBind();
                btnAdd6F.Enabled = true;
                btnAdd6S.Enabled = true;
                btnAdd6T.Enabled = true;
                Page.Response.Write("<script>console.log('" + lvPicFileName6 + "');</script>");
            }
            catch(Exception ex)
            {
                Page.Response.Write("<script>console.log('" + ex.ToString() + "');</script>");
            }
            
        }

        protected void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                AspImageShow1.ImageUrl = "";
                btnAdd1F.Enabled = false;
                btnAdd1S.Enabled = false;
                btnAdd1T.Enabled = false;

                AspImageShow2.ImageUrl = "";
                btnAdd2F.Enabled = false;
                btnAdd2S.Enabled = false;
                btnAdd2T.Enabled = false;

                AspImageShow3.ImageUrl = "";
                btnAdd3F.Enabled = false;
                btnAdd3S.Enabled = false;
                btnAdd3T.Enabled = false;

                AspImageShow4.ImageUrl = "";
                btnAdd4F.Enabled = false;
                btnAdd4S.Enabled = false;
                btnAdd4T.Enabled = false;

                AspImageShow5.ImageUrl = "";
                btnAdd5F.Enabled = false;
                btnAdd5S.Enabled = false;
                btnAdd5T.Enabled = false;

                AspImageShow6.ImageUrl = "";
                btnAdd6F.Enabled = false;
                btnAdd6S.Enabled = false;
                btnAdd6T.Enabled = false;

                string lvRail = cmb_Rail.Text;
                string lvDump = cmb_Dump.Text;
                string lvDate = GsysFunc.fncChangeTDate(cmb_SearchDate.Text);
                string lvTime = cmb_Time.Text;
                string lvPathMode = "/PicTakow/" + lvRail + "/" + lvDump + "/";
                //string lvPathMode = "~/Images/";
                //GVar.gvPathMode = lvPathMode;
                //string lvPathTest = "~/Pictures/";
                string[] lvTimeSplit = lvTime.Split(':');
                string lvContains = "*" + lvDate + lvTimeSplit[0] + "*";

                string[] allFile = Directory.GetFiles(GVar.gvPathMode, lvContains, SearchOption.AllDirectories); //เรียกดูไฟล์ทั้งหมดใน Folder
            
                GVar.gvPicNum = GVar.gvPicNum + 6;
                
                int arrayFileNumber = allFile.Length; //นับจำนวนไฟล์ใน Array

                string lvPic1 = allFile[GVar.gvPicNum];
                string[] lvPic1Split = lvPic1.Split('/');
                string lvPicFileName1 = GVar.gvPathMode + lvPic1Split[4];
                AspImageShow1.ImageUrl = lvPicFileName1;
                AspImageShow1.DataBind();
                if (AspImageShow1.ImageUrl != "")
                {
                    btnAdd1F.Enabled = true;
                    btnAdd1S.Enabled = true;
                    btnAdd1T.Enabled = true;
                }

                string lvPic2 = allFile[GVar.gvPicNum + 1];
                string[] lvPic2Split = lvPic2.Split('/');
                string lvPicFileName2 = GVar.gvPathMode + lvPic2Split[4];
                AspImageShow2.ImageUrl = lvPicFileName2;
                AspImageShow2.DataBind();
                if (AspImageShow2.ImageUrl != "")
                {
                    btnAdd2F.Enabled = true;
                    btnAdd2S.Enabled = true;
                    btnAdd2T.Enabled = true;
                }

                string lvPic3 = allFile[GVar.gvPicNum + 2];
                string[] lvPic3Split = lvPic3.Split('/');
                string lvPicFileName3 = GVar.gvPathMode + lvPic3Split[4];
                AspImageShow3.ImageUrl = lvPicFileName3;
                AspImageShow3.DataBind();
                if (AspImageShow3.ImageUrl != "")
                {
                    btnAdd3F.Enabled = true;
                    btnAdd3S.Enabled = true;
                    btnAdd3T.Enabled = true;
                }

                string lvPic4 = allFile[GVar.gvPicNum + 3];
                string[] lvPic4Split = lvPic4.Split('/');
                string lvPicFileName4 = GVar.gvPathMode + lvPic4Split[4];
                AspImageShow4.ImageUrl = lvPicFileName4;
                AspImageShow4.DataBind();
                if (AspImageShow4.ImageUrl != "")
                {
                    btnAdd4F.Enabled = true;
                    btnAdd4S.Enabled = true;
                    btnAdd4T.Enabled = true;
                }

                string lvPic5 = allFile[GVar.gvPicNum + 4];
                string[] lvPic5Split = lvPic5.Split('/');
                string lvPicFileName5 = GVar.gvPathMode + lvPic5Split[4];
                AspImageShow5.ImageUrl = lvPicFileName5;
                AspImageShow5.DataBind();
                if (AspImageShow5.ImageUrl != "")
                {
                    btnAdd5F.Enabled = true;
                    btnAdd5S.Enabled = true;
                    btnAdd5T.Enabled = true;
                }

                string lvPic6 = allFile[GVar.gvPicNum + 5];
                string[] lvPic6Split = lvPic6.Split('/');
                string lvPicFileName6 = GVar.gvPathMode + lvPic6Split[4];
                AspImageShow6.ImageUrl = lvPicFileName6;
                AspImageShow6.DataBind();
                if (AspImageShow6.ImageUrl != "")
                {
                    btnAdd6F.Enabled = true;
                    btnAdd6S.Enabled = true;
                    btnAdd6T.Enabled = true;
                }
                        
            }
            catch(Exception ex)
            {
                Page.Response.Write("<script>console.log('" + ex.ToString() + "');</script>");
            }
            
        }

        protected void btn_After_Click(object sender, EventArgs e)
        {
            try
            {

                AspImageShow1.ImageUrl = "";
                btnAdd1F.Enabled = false;
                btnAdd1S.Enabled = false;
                btnAdd1T.Enabled = false;

                AspImageShow2.ImageUrl = "";
                btnAdd2F.Enabled = false;
                btnAdd2S.Enabled = false;
                btnAdd2T.Enabled = false;

                AspImageShow3.ImageUrl = "";
                btnAdd3F.Enabled = false;
                btnAdd3S.Enabled = false;
                btnAdd3T.Enabled = false;

                AspImageShow4.ImageUrl = "";
                btnAdd4F.Enabled = false;
                btnAdd4S.Enabled = false;
                btnAdd4T.Enabled = false;

                AspImageShow5.ImageUrl = "";
                btnAdd5F.Enabled = false;
                btnAdd5S.Enabled = false;
                btnAdd5T.Enabled = false;

                AspImageShow6.ImageUrl = "";
                btnAdd6F.Enabled = false;
                btnAdd6S.Enabled = false;
                btnAdd6T.Enabled = false;

                string lvRail = cmb_Rail.Text;
                string lvDump = cmb_Dump.Text;
                string lvDate = GsysFunc.fncChangeTDate(cmb_SearchDate.Text);
                string lvTime = cmb_Time.Text;
                string lvPathMode = "/PicTakow/" + lvRail + "/" + lvDump + "/";
                //string lvPathMode = "~/Images/";
                //string lvPathTest = "~/Pictures/";
                string[] lvTimeSplit = lvTime.Split(':');

                string lvContains = "*" + lvDate + lvTimeSplit[0] + "*";

                string[] allFile = Directory.GetFiles(GVar.gvPathMode, lvContains, SearchOption.AllDirectories); //เรียกดูไฟล์ทั้งหมดใน Folder

                int arrayFileNumber = allFile.Length; //จำนวนทั้งหมดใน Folder
                

                GVar.gvPicNum = GVar.gvPicNum - 6;

           
                string lvPic1 = allFile[GVar.gvPicNum];
                string[] lvPic1Split = lvPic1.Split('/');
                string lvPicFileName1 = GVar.gvPathMode + lvPic1Split[4];
                AspImageShow1.ImageUrl = lvPicFileName1;
                if (AspImageShow1.ImageUrl != "")
                {
                    btnAdd1F.Enabled = true;
                    btnAdd1S.Enabled = true;
                    btnAdd1T.Enabled = true;
                }

                string lvPic2 = allFile[GVar.gvPicNum + 1];
                string[] lvPic2Split = lvPic2.Split('/');
                string lvPicFileName2 = GVar.gvPathMode + lvPic2Split[4];
                AspImageShow2.ImageUrl = lvPicFileName2;
                if (AspImageShow2.ImageUrl != "")
                {
                    btnAdd2F.Enabled = true;
                    btnAdd2S.Enabled = true;
                    btnAdd2T.Enabled = true;
                }

                string lvPic3 = allFile[GVar.gvPicNum + 2];
                string[] lvPic3Split = lvPic3.Split('/');
                string lvPicFileName3 = GVar.gvPathMode + lvPic3Split[4];
                AspImageShow3.ImageUrl = lvPicFileName3;
                if (AspImageShow3.ImageUrl != "")
                {
                    btnAdd3F.Enabled = true;
                    btnAdd3S.Enabled = true;
                    btnAdd3T.Enabled = true;
                }

                string lvPic4 = allFile[GVar.gvPicNum + 3];
                string[] lvPic4Split = lvPic4.Split('/');
                string lvPicFileName4 = GVar.gvPathMode + lvPic4Split[4];
                AspImageShow4.ImageUrl = lvPicFileName4;
                if (AspImageShow4.ImageUrl != "")
                {
                    btnAdd4F.Enabled = true;
                    btnAdd4S.Enabled = true;
                    btnAdd4T.Enabled = true;
                }

                string lvPic5 = allFile[GVar.gvPicNum + 4];
                string[] lvPic5Split = lvPic5.Split('/');
                string lvPicFileName5 = GVar.gvPathMode + lvPic5Split[4];
                AspImageShow5.ImageUrl = lvPicFileName5;
                if (AspImageShow5.ImageUrl != "")
                {
                    btnAdd5F.Enabled = true;
                    btnAdd5S.Enabled = true;
                    btnAdd5T.Enabled = true;
                }

                string lvPic6 = allFile[GVar.gvPicNum + 5];
                string[] lvPic6Split = lvPic6.Split('/');
                string lvPicFileName6 = GVar.gvPathMode + lvPic6Split[4];
                AspImageShow6.ImageUrl = lvPicFileName6;
                if (AspImageShow6.ImageUrl != "")
                {
                    btnAdd6F.Enabled = true;
                    btnAdd6S.Enabled = true;
                    btnAdd6T.Enabled = true;
                }
                
            }
            catch(Exception ex)
            {
                Page.Response.Write("<script>console.log('" + ex.ToString() + "');</script>");
            }
            
        }

        protected void btnAdd1F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow1.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd1S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow1.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd1T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow1.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btnAdd2F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow2.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd2S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow2.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd2T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow2.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btnAdd3F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow3.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd3S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow3.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd3T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow3.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btnAdd4F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow4.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd4S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow4.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd4T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow4.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btnAdd5F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow5.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd5S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow5.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd5T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow5.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btnAdd6F_Click(object sender, EventArgs e)
        {
            ASPxImage1.ImageUrl = AspImageShow6.ImageUrl; //ใส่ URL ลงในกล่องรูปที่ 1

            //Function หาค่าเวลาในรูปแรก
            string lvName30 = ASPxImage1.ImageUrl;
            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvIName30Split[4];
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            txtTime.Text = lvTime;

            //โชว์ชื่อใน Label
            string lvImageName = ASPxImage1.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName1.Text = lvNameUse;
        }

        protected void btnAdd6S_Click(object sender, EventArgs e)
        {
            ASPxImage2.ImageUrl = AspImageShow6.ImageUrl;
            string lvImageName = ASPxImage2.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName2.Text = lvNameUse;
        }

        protected void btnAdd6T_Click(object sender, EventArgs e)
        {
            ASPxImage3.ImageUrl = AspImageShow6.ImageUrl;
            string lvImageName = ASPxImage3.ImageUrl;
            string[] lvImageNameSplit = lvImageName.Split('/');
            string lvNameUse = lvImageNameSplit[4];
            lbName3.Text = lvNameUse;
        }

        protected void btn_Matching_Click(object sender, EventArgs e)
        {
            string lvQno = txtQNo.Text;
            string lvDate = GsysFunc.fncChangeTDate(txtDate.Text);

            string lvSQL = "Delete From I_Images Where I_QNo = '" + lvQno + "' And I_Date = '" + lvDate + "' ";
            string lvResult = GsysSQL.fncExecuteQueryDataSQL(lvSQL);

            string lvName30First = ASPxImage1.ImageUrl;
            string[] lvNameSplit30 = lvName30First.Split('/');
            string lvName30 = lvNameSplit30[4];
            
            string lvName45First = ASPxImage2.ImageUrl;
            string[] lvNameSplit45 = lvName45First.Split('/');
            string lvName45 = lvNameSplit45[4];

            string lvName90First = ASPxImage3.ImageUrl;
            string[] lvNameSplit90 = lvName90First.Split('/');
            string lvName90 = lvNameSplit90[4];

            string[] lvIName30Split = lvName30.Split('/');
            string lvNameTime = lvName30;
            string lvTimeReal1 = lvNameTime.Substring(16, 2);
            string lvTimeReal2 = lvNameTime.Substring(18, 2);
            string lvTime = lvTimeReal1 + ":" + lvTimeReal2;
            string lvRail = cmb_Rail.Text;
            string lvDump = txtDump.Text;
            string lvQuota = txtQuota.Text;
            string lvCarnum = txtCarNum.Text;

            if(lvQno == "")
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('กรุณากรอกเลขที่คิวก่อน!');</script>");
                return;
            }

            lvSQL = "Insert Into I_Images(I_QNo, I_Date, I_Time, I_Rail, I_Name_30, I_Name_45, I_Name_90, I_Dump) " +
                "Values ('" + lvQno + "', '" + lvDate + "', '" + lvTime + "', '" + lvRail + "', '" + lvName30 + "', '" + lvName45 + "', '" + lvName90 + "', '" + lvDump + "')";
            lvResult = GsysSQL.fncExecuteQueryDataSQL(lvSQL);

            if(lvResult == "Success")
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('บันทึกข้อมูลสำเร็จ!');</script>");

                fncLoadData();

                txtDate.Text = "";
                txtDump.Text = "";
                txtTime.Text = "";
                txtQNo.Text = "";
                txtQuota.Text = "";
                txtCarNum.Text = "";
                ASPxImage1.ImageUrl = "";
                lbName1.Text = "รูปที่ 1";
                ASPxImage2.ImageUrl = "";
                lbName2.Text = "รูปที่ 2";
                ASPxImage3.ImageUrl = "";
                lbName3.Text = "รูปที่ 3";
            }
        }

        protected void txtQNo_TextChanged(object sender, EventArgs e)
        {
            string lvQNo = txtQNo.Text;

            DataTable DT = new DataTable();
            string lvSQL = "Select Q_Quota, Q_CarNum From Queue_Diary Where Q_No = '" + lvQNo + "'";
            DT = GsysSQL.fncGetQueryDataSQL(lvSQL, DT);

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvQuota = DT.Rows[i]["Q_Quota"].ToString();
                string lvCarNum = DT.Rows[i]["Q_CarNum"].ToString();
                string lvCarNumReal = lvCarNum.Replace('a', '.');

                txtQuota.Text = lvQuota;
                txtCarNum.Text = lvCarNumReal;
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            string lvQno = txtQNo.Text;
            string lvDate = GsysFunc.fncChangeTDate(txtDate.Text);

            string lvSQL = "Delete From I_Images Where I_QNo = '" + lvQno + "' And I_Date = '" + lvDate + "' ";
            string lvResult = GsysSQL.fncExecuteQueryDataSQL(lvSQL);

            if (lvResult == "Success")
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alertMessage", "<script type='text/javascript'>alert('ลบข้อมูลสำเร็จ!');</script>");

                txtDate.Text = "";
                txtDump.Text = "";
                txtTime.Text = "";
                txtQNo.Text = "";
                txtQuota.Text = "";
                txtCarNum.Text = "";
                ASPxImage1.ImageUrl = "";
                lbName1.Text = "รูปที่ 1";
                ASPxImage2.ImageUrl = "";
                lbName2.Text = "รูปที่ 2";
                ASPxImage3.ImageUrl = "";
                lbName3.Text = "รูปที่ 3";
                btn_Delete.Enabled = false;
                btn_Cancel.Enabled = false;

                fncLoadData();
            }
        }

        protected void ASPxButton22_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmReport.aspx");
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDump.Text = "";
            txtTime.Text = "";
            txtQNo.Text = "";
            txtQuota.Text = "";
            txtCarNum.Text = "";

            ASPxImage1.ImageUrl = "";
            lbName1.Text = "รูปที่ 1";
            ASPxImage2.ImageUrl = "";
            lbName2.Text = "รูปที่ 2";
            ASPxImage3.ImageUrl = "";
            lbName3.Text = "รูปที่ 3";

            btn_Delete.Enabled = false;
            btn_Cancel.Enabled = false;
        }
    }
}