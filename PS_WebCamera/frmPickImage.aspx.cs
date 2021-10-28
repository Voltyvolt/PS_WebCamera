using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using PS_WebCamera.Models;
using System.Drawing;
using System.Drawing.Imaging;

namespace PS_WebCamera
{
    public partial class frmPickImage : System.Web.UI.Page
    {
        //ประกาศ Model class เพื่อเรียกใช้ Data
        string Q_No = "";
        string Q_Date = "";
        Dump dump = new Dump();
        Rail rail = new Rail();
        SampleNo sampleno = new SampleNo();
        List<string> itemAllinDate = new List<string>();
        List<string> result = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                QueueDiary queue = new QueueDiary(Q_No, Q_Date);
                cmb_Date.Text = DateTime.Now.ToShortDateString();
                cmb_Qno.Items.AddRange(queue.arrayno);
                cmb_SampleNo.Items.AddRange(sampleno.arrayno);
                cmb_Dump.Items.AddRange(dump.arrayno);
                cmb_Rail.Items.AddRange(rail.arrayno);
            }
            else
            {
                
            }
        }

        [WebMethod]
        public void ReadImage(string Rails, string Dump, string SampleNo)
        {
            try
            {
                //ค้นหาไฟล์ทั้งหมดใน Path ตามที่ User ค้นหาข้อมูล
                ImagePath filepath = new ImagePath(Rails, Dump);
                var filters = "*" + SampleNo + ".jpg*";
                string[] fileDirectory = Directory.GetFiles(filepath.path.ToString(), filters, SearchOption.AllDirectories);
                List<String> _imagename = new List<string>();
                _imagename = fileDirectory.ToList();
                imagelist.Items.Clear();
                string _datetest = GsysFunc.fncChangeTDate(cmb_Date.Value.ToString());
                int x = 0;
                string[] AllDesignItem = { };
                string item = "";
                string _onlyfilename = "";
                string[] _filenamesplit = { };
                string _degree = "";
                string _date = "";


                for (int i = 0; i < _imagename.Count(); i++)
                {
                    item = _imagename[i]; //ไฟล์ปัจจุบัน
                    _onlyfilename = Path.GetFileName(item); //เอามาเฉพาะชื่อ
                    _filenamesplit = _onlyfilename.Split('_'); //แยก
                    _degree = _filenamesplit[2]; //องศาปัจจุบัน
                    _date = _filenamesplit[3]; //วันที่ปัจจุบัน

                    if (_date.Contains(_datetest))
                    {
                        itemAllinDate.Add(item);
                    }

                    x += 1;
                }

                foreach (var _itemallresult in itemAllinDate)
                {
                    System.Diagnostics.Debug.WriteLine(_itemallresult + " - ไฟล์ทั้งหมด");
                }

                //กรองไฟล์ออกมาเฉพาะ 3 ไฟล์สุดท้ายของแต่ละองศา
                AllDesignItem = itemAllinDate.ToArray();
                item = "";
                _onlyfilename = "";
                string nextitem = "";
                string _onlyfilenextname = "";
                string[] _nextfilenamesplit = { };
                _degree = "";
                _date = "";
                string _nextdegree = "";
                string _nextdate = "";

                for (int i = 0; i < AllDesignItem.Length; i++)
                {
                    int lvLastRow = AllDesignItem.Length - 1;
                    item = AllDesignItem[i]; //ไฟล์ปัจจุบัน
                    _onlyfilename = Path.GetFileName(item); //เอามาเฉพาะชื่อ
                    if (i != lvLastRow)
                    {
                        nextitem = AllDesignItem[i + 1]; //ไฟล์ต่อไป
                        _onlyfilenextname = Path.GetFileName(nextitem); //เอามาเฉพาะชื่อ
                        _filenamesplit = _onlyfilename.Split('_'); //แยก
                        _nextfilenamesplit = _onlyfilenextname.Split('_'); //แยก
                        _degree = _filenamesplit[2]; //องศาปัจจุบัน
                        _date = _filenamesplit[3]; //วันที่ปัจจุบัน
                        _nextdegree = _nextfilenamesplit[2]; //องศาต่อไป
                        _nextdate = _nextfilenamesplit[3]; //วันที่ต่อไป

                        if (_degree != _nextdegree)
                        {
                            result.Add(_onlyfilename.ToString());
                        }
                    }
                    else
                    {
                        result.Add(_onlyfilename.ToString());
                    }
                }
                foreach (var itemsresult in result)
                {
                    imagelist.Items.Add(itemsresult);
                }

                //นำไฟล์เข้าไปใน ImageBox
                string _imagedegree30 = filepath.path + "\\" + imagelist.Items[0].ToString();
                this.Image_30.ImageUrl = _imagedegree30.ToString();
                string _imagedegree45 = filepath.path + "\\" + imagelist.Items[1].ToString();
                this.Image_45.ImageUrl = _imagedegree45.ToString();
                string _imagedegree90 = filepath.path + "\\" + imagelist.Items[2].ToString();
                this.Image_90.ImageUrl = _imagedegree90.ToString();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('ไม่พบข้อมูลรูปภาพ กรุณาติดต่อแผนกคอมพิวเตอร์ค่ะ...');</script>");
                System.Diagnostics.Debug.WriteLine("Catch exception เพราะ " + ex.ToString());
                lineNotify("Error เพราะ " + ex.ToString() + "Event = ReadImage()");
            }
        }

        protected void Button_search_Click(object sender, EventArgs e)
        {
            try
            {
                Q_No = cmb_Qno.Text;
                Q_Date = cmb_Date.Text;

                QueueDiary queue = new QueueDiary(Q_No, Q_Date);

                string _SampleNo = queue.Sampleno.ToString();
                string _Rail = queue.Rail.ToString();
                string _Dump = queue.Dump.ToString();

                cmb_SampleNo.Text = _SampleNo;
                cmb_Rail.Text = _Rail;
                cmb_Dump.Text = _Dump;

                //ReadImage(_Rail, _Dump, _SampleNo); //อ่านไฟล์รูปภาพใน Folder

                //ค้นหาไฟล์ทั้งหมดใน Path ตามที่ User ค้นหาข้อมูล
                ImagePath filepath = new ImagePath(_Rail, _Dump);
                var filters = "*" + _SampleNo + ".jpg*";
                string[] fileDirectory = Directory.GetFiles(filepath.path.ToString(), filters, SearchOption.AllDirectories);
                List<String> _imagename = new List<string>();
                _imagename = fileDirectory.ToList();
                imagelist.Items.Clear();
                string _datetest = GsysFunc.fncChangeTDate(cmb_Date.Value.ToString());
                int x = 0;
                string[] AllDesignItem = { };
                string item = "";
                string _onlyfilename = "";
                string[] _filenamesplit = { };
                string _degree = "";
                string _date = "";


                for (int i = 0; i < _imagename.Count(); i++)
                {
                    item = _imagename[i]; //ไฟล์ปัจจุบัน
                    _onlyfilename = Path.GetFileName(item); //เอามาเฉพาะชื่อ
                    _filenamesplit = _onlyfilename.Split('_'); //แยก
                    _degree = _filenamesplit[2]; //องศาปัจจุบัน
                    _date = _filenamesplit[3]; //วันที่ปัจจุบัน

                    if (_date.Contains(_datetest))
                    {
                        itemAllinDate.Add(item);
                    }

                    x += 1;
                }

                foreach (var _itemallresult in itemAllinDate)
                {
                    System.Diagnostics.Debug.WriteLine(_itemallresult + " - ไฟล์ทั้งหมด");
                }

                //กรองไฟล์ออกมาเฉพาะ 3 ไฟล์สุดท้ายของแต่ละองศา
                AllDesignItem = itemAllinDate.ToArray();
                item = "";
                _onlyfilename = "";
                string nextitem = "";
                string _onlyfilenextname = "";
                string[] _nextfilenamesplit = { };
                _degree = "";
                _date = "";
                string _nextdegree = "";
                string _nextdate = "";

                for (int i = 0; i < AllDesignItem.Length; i++)
                {
                    int lvLastRow = AllDesignItem.Length - 1;
                    item = AllDesignItem[i]; //ไฟล์ปัจจุบัน
                    _onlyfilename = Path.GetFileName(item); //เอามาเฉพาะชื่อ
                    if (i != lvLastRow)
                    {
                        nextitem = AllDesignItem[i + 1]; //ไฟล์ต่อไป
                        _onlyfilenextname = Path.GetFileName(nextitem); //เอามาเฉพาะชื่อ
                        _filenamesplit = _onlyfilename.Split('_'); //แยก
                        _nextfilenamesplit = _onlyfilenextname.Split('_'); //แยก
                        _degree = _filenamesplit[2]; //องศาปัจจุบัน
                        _date = _filenamesplit[3]; //วันที่ปัจจุบัน
                        _nextdegree = _nextfilenamesplit[2]; //องศาต่อไป
                        _nextdate = _nextfilenamesplit[3]; //วันที่ต่อไป

                        if (_degree != _nextdegree)
                        {
                            result.Add(_onlyfilename.ToString());
                        }
                    }
                    else
                    {
                        result.Add(_onlyfilename.ToString());
                    }
                }
                foreach (var itemsresult in result)
                {
                    imagelist.Items.Add(itemsresult);
                }

                //นำไฟล์เข้าไปใน ImageBox
                string _imagedegree30 = @"" + filepath.path + "/" + imagelist.Items[0].ToString();
                Image_30.ImageUrl = _imagedegree30.ToString();
                lb_image30.Text = "ชื่อรูปที่ 1 : " + _imagedegree30.ToString();
                string _imagedegree45 = @"" + filepath.path + "/" + imagelist.Items[1].ToString();
                Image_45.ImageUrl = _imagedegree45.ToString();
                lb_image45.Text = "ชื่อรูปที่ 2 : " + _imagedegree45.ToString();
                string _imagedegree90 = @"" + filepath.path + "/" + imagelist.Items[2].ToString();
                Image_90.ImageUrl = _imagedegree90.ToString();
                lb_image90.Text = "ชื่อรูปที่ 3 : " + _imagedegree90.ToString();

            }
            catch(Exception ex)
            {
                if (Q_No == null || Q_No == "")
                {
                    Response.Write("<script>alert('กรุณากรอกเลขที่คิว...');</script>");
                }
                else if (Q_Date == null || Q_Date == "")
                {
                    Response.Write("<script>alert('กรุณากรอกวันที่...');</script>");
                }
                else
                {
                    Response.Write("<script>alert('ไม่พบข้อมูล กรุณาติดต่อแผนกคอมพิวเตอร์ค่ะ...');</script>");
                }
                lineNotify("Error เพราะ " + ex.ToString() + "Event = btn_Search()");
                System.Diagnostics.Debug.WriteLine("Catch exception เพราะ " + ex.ToString());
            }
            
        }

        private void lineNotify(string msg)
        {
            //string token = "Wuh3ocetjly3TUZgd9OV0YY3o9g6GouD3wPaIsthAna"; //ห้องคอม
            string token = "vRtm1XpGxkReljIAAsVjSK0rfWFBzpnXgaZdMXZWgkP"; //ส่วนตัว

            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                var postData = string.Format("message={0}", msg);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}