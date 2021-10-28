using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.IO;
using System.Globalization;

namespace PS_WebCamera.Models
{
    public class QueueDiary
    {
        public bool success;
        [Key]
        public int id;
        public double No;
        public string Rail;
        public string Date;
        public int Quota;
        public string Carnum;
        public string Sampleno;
        public string Dump;
        List<string> nos = new List<string>();
        public string[] arrayno = null;

        public QueueDiary(string Q_no, string Q_Date)
        {
            Queuegetter(Q_no, Q_Date);
        }

        public void Queuegetter(string Q_no, string Q_Date)
        {
            string ChgQ_Date = fncChangeTDate(Q_Date);
            success = false;
            const string Year = "";
            
            DataTable DT = new DataTable();
            string SQL = "Select * From Queue_Diary Where Q_Year = '" + Year + "' ";

            if(Q_no != "")
            {
                SQL += "AND Q_No = '" + Q_no + "' ";
            }

            if(Q_Date != "")
            {
                SQL += "AND Q_Date = '" + ChgQ_Date + "' ";
            }

            DT = GsysSQL.fncGetQueryDataSQL(SQL, DT);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                id = Convert.ToInt32(DT.Rows[i]["Q_PK"]);
                No = Convert.ToDouble(DT.Rows[i]["Q_No"]);
                nos.Add(No.ToString());
                Rail = Convert.ToString(DT.Rows[i]["Q_Rail"]);
                Date = fncChangeSDate(Convert.ToString(DT.Rows[i]["Q_Date"]));
                Quota = Convert.ToInt32(DT.Rows[i]["Q_Quota"]);
                Carnum = Convert.ToString(DT.Rows[i]["Q_Carnum"]);
                Sampleno = Convert.ToString(DT.Rows[i]["Q_SampleNo"]);
                Dump = Convert.ToString(DT.Rows[i]["Q_DumNo"]);
            }
            
            arrayno = nos.ToArray();
        }

        [WebMethod]
        public string GetterData()
        {
            string url = "http://110.77.148.116/PHP_API/PSApi/queuediary_get.php";
            var json = new WebClient().DownloadString(url);
            var myArr = JsonConvert.DeserializeObject<List<string>>(json);
            return null;
        }

        public static void lineNotify(string msg)
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

        public string fncChangeTDate(string strDate)
        {
            if (strDate == "") return "";
            //--เก็บประเภทของปฏิทิน
            var myCal = DateTimeFormatInfo.CurrentInfo.Calendar;

            //ปรับรูปแบบวันที่
            string[] lvArr1 = strDate.Split(' ');
            string[] lvArr = lvArr1[0].Split('/');

            if (lvArr.Count() > 0)
            {
                string lvDD = fncToInt(lvArr[0]).ToString("00");
                string lvMM = fncToInt(lvArr[1]).ToString("00");
                string lvYY = lvArr[2];

                strDate = lvDD + "/" + lvMM + "/" + lvYY;
            }

            //ฟังก์ชั่น แปลงวันที่ เป็นรูปแบบบ Text  รูปแบบ yyyyMMdd
            if (strDate.Trim().Length == 10)
            {
                string lvDay = Left(strDate, 2);
                string lvMonth = Mid(strDate, 4, 2);
                string lvYear = Right(strDate, 4);


                int lvNumYear = int.Parse(lvYear);

                if (lvNumYear > 2500)
                {
                    //--ตรวจว่าปฎิทินของเครื่องเป็นแบบปี พ.ศ. หรือไม่ ถ้าใช่ให้เปลี่ยนก่อนแสดงผล
                    if (myCal.ToString() == "System.Globalization.ThaiBuddhistCalendar")
                    {
                        lvNumYear = lvNumYear - 543;
                        lvYear = lvNumYear.ToString();
                    }
                }
                return lvYear + lvMonth + lvDay;
            }

            else
            {
                return strDate;
            }
        }

        public string Left(string str, int Length)
        {
            if (Length > 0 && str.Length >= Length)
            {
                return str.Substring(0, Length);
            }
            else
            {
                return str;
            }
        }

        public string Right(string str, int Length)
        {
            if (Length > 0 && str.Length >= Length)
            {
                return str.Substring(str.Length - Length, Length);
            }
            else
            {
                return str;
            }
        }

        public string Mid(string str, int strStart, int strLength)
        {
            return str.Substring(strStart - 1, strLength);
        }

        public string fncChangeSDate(string strDate)
        {
            //--เก็บประเภทของปฏิทิน
            var myCal = DateTimeFormatInfo.CurrentInfo.Calendar;

            string lvYear = Left(strDate, 4);

            //--แปลงปีให้อยู่ในรูปแบบของตัวเลข
            int lvYear2 = fncToInt(lvYear);
            int lvYear3 = lvYear2;

            if (lvYear2 < 2500)
            {
                //--ตรวจว่าปฎิทินของเครื่องเป็นแบบปี พ.ศ. หรือไม่ ถ้าใช่ให้เปลี่ยนก่อนแสดงผล
                if (myCal.ToString() == "System.Globalization.ThaiBuddhistCalendar" || lvYear3 < 2500)
                {
                    //lvYear3 = lvYear2 + 543;
                }
            }
            else if (lvYear2 > 3000)
            {
                lvYear2 -= 543;
            }
            else if (lvYear2 > 2500)
            {
                lvYear2 -= 543;
            }


            //ฟังก์ชั่น Show Date รูปแบบ dd/MM/yyyy
            if (strDate.Length == 8)
            {
                string lvDay = Right(strDate, 2);
                string lvMonth = Mid(strDate, 5, 2);

                return lvDay + "/" + lvMonth + "/" + lvYear3;
            }
            else
            {
                return strDate;
            }
        }

        public int fncToInt(string strNumber)
        {//ฟังก์ชั่นแปลงตัวเลขใน string ให้เป็นเลขจำนวนเต็ม  (+-2,147,483,647) 
            //แปลงค่าว่างได้ ,แปลงค่าที่มี comma ได้ เช่น 123,456
            //แปลงมีค่าลบได้ทั้งหน้าและหลัง เช่น 123,456.00-
            //แปลงค่าติดลบที่เป็นวงเล็บได้ เช่น (123,456.00) --> -123456

            try
            {
                int lvPosition = strNumber.IndexOf("."); //ค้นหาตำแหน่งจุดทศนิยม
                if (lvPosition > 0) strNumber = Left(strNumber, lvPosition); //เอาเฉพาะจำนวนเต็ม ตัดจุดทศนิยมออก

                return int.Parse(strNumber.Trim(), System.Globalization.NumberStyles.Any);
            }
            catch //(Exception ex)
            {
                return 0;
            }
        }
    }
}