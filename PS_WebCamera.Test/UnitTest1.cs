using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PS_WebCamera.Test
{
    [TestClass]
    public class UnitTest1
    {
        List<string> itemAllinDate = new List<string>();
        List<string> result = new List<string>();
        string _Outofrangeitems;

        [TestMethod]
        public void TestRuncarnum()
        {
            //
            var Fullcar = "";
            var Carnum = "พล.82-5563";
            var Carnum2 = "พล.82-5564";

            if (Carnum2 == "")
            {
                Fullcar = Carnum;
            }
            else
            {
                Fullcar = Carnum + " / " + Carnum2;
            }
            System.Diagnostics.Debug.WriteLine(Fullcar);
        }
        
        [TestMethod]
        public void TestReadImageRailA()
        {
            int expected = 4;
            string _samplecheck = "5550";
            var filters = "*5550" + "*";
            string[] fileDirectory = Directory.GetFiles("D:\\PicTakow\\B\\6", filters, SearchOption.AllDirectories);
            List<String> _imagename = new List<string>();
            _imagename = fileDirectory.ToList();
            int x = 0;
            string _datetest = "20211013";
            foreach (var item in _imagename)
            {
                string _onlyfilename = Path.GetFileName(item);
                string[] _filenamesplit = _onlyfilename.Split('_');
                string _degree = _filenamesplit[2];
                string _date = _filenamesplit[3];
                string _sampleno = _filenamesplit[4];
                if (_date.Contains(_datetest))
                {
                    System.Diagnostics.Debug.WriteLine(_onlyfilename);
                }
                x += 1;
            }
            Assert.AreEqual(expected, x, "imagename found correctly");
        }

        [TestMethod]
        public void TestReadImageRailB()
        {
            try
            {
                int expected = 5;
                var filters = "*5550" + "*";
                string[] fileDirectory = Directory.GetFiles("D:\\PicTakow\\B\\6", filters, SearchOption.AllDirectories); //ค้นหาไฟล์ใน Directory
                List<String> _imagename = new List<string>();
                _imagename = fileDirectory.ToList(); //ชื่อไฟล์ + Path
                int x = 0; //for Assert check
                string _datetest = "20211013";
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
                        itemAllinDate.Add(_onlyfilename);
                    }

                    x += 1;
                }

                foreach (var _itemallresult in itemAllinDate)
                {
                    System.Diagnostics.Debug.WriteLine(_itemallresult + " - ไฟล์ทั้งหมด");
                }

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
                    System.Diagnostics.Debug.WriteLine(itemsresult + " - ไฟล์ใช้ใน imagebox");
                }

                //Assert.AreEqual(expected, x, "imagename found correctly");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Catch exception เพราะ " + ex.ToString());
            }
            
        }
    }
}
