using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS_WebCamera.Models
{
    public class Rail
    {
        [Key]
        public int id;
        public string RailName;
        List<string> rails = new List<string>();
        public string[] arrayno = null;

        public Rail()
        {
            RailsGetter();
        }

        public void RailsGetter()
        {
            rails.Add("A");
            rails.Add("B");
            arrayno = rails.ToArray();
        }
    }
}