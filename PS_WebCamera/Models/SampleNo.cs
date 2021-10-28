using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace PS_WebCamera.Models
{
    public class SampleNo
    {
        public bool success;
        [Key]
        public int id;
        public string Sampleno;
        List<string> nos = new List<string>();
        public string[] arrayno = null;

        public SampleNo()
        {
            Samplegetter();
        }

        public bool Samplegetter()
        {
            success = false;
            const string Year = "";

            DataTable DT = new DataTable();
            string SQL = "Select * From Queue_Diary Where Q_Year = '" + Year + "'";
            DT = GsysSQL.fncGetQueryDataSQL(SQL, DT);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Sampleno = Convert.ToString(DT.Rows[i]["Q_SampleNo"]);
                if(Sampleno != "")
                {
                    nos.Add(Sampleno);
                }
            }

            arrayno = nos.ToArray();
            return success = true;
        }
    }
}