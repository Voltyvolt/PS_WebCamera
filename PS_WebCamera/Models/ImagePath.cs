using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS_WebCamera.Models
{
    public class ImagePath
    {
        public string path;

        public ImagePath(string Rail, string Dump)
        {
            path = @"E:/PicTakow/" + Rail + "/" + Dump;
        }
    }
}