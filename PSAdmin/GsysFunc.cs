using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace PSAdmin
{
    public class GsysFunc
    {
        public static string FncSendMail(string lvMsg, string lvEmail, string lvSubject)
        {
            string lvReturn = "";

            try
            {
                var myMail = new MailMessage();
                myMail.From = new MailAddress("Admin PSSugar<Webmaster@trrgroup.com>");

                myMail.Subject = lvSubject;
                myMail.To.Add(new MailAddress(lvEmail));
                myMail.IsBodyHtml = true;
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                myMail.Body = lvMsg;

                var smtpClient = new SmtpClient();
                smtpClient.Send(myMail);

                smtpClient.Dispose();
                myMail.Dispose();

                lvReturn = "Success";
            }
            catch (Exception ex)
            {
                lvReturn = ex.Message;
            }

            return lvReturn;
        }

        public static string Left(string str, int Length)
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

        public static int fncToInt(string strNumber)
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