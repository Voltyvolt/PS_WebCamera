using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS_WebCamera.Models
{
    public class Dump
    {
        [Key]
        public int id;
        public int dump;
        List<string> _dumps = new List<string>();
        public string result = null;
        public string[] arrayno = null;

        public Dump()
        {
            MethodLoadDump();
        }

        protected void MethodLoadDump()
        {
            for (int i = 0; i < 8; i++)
            {
                id = i + 1;
                dump = i + 1;
                _dumps.Add(dump.ToString());
                arrayno = _dumps.ToArray();
            }
        }
    }
}