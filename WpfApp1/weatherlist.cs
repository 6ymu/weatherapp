using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class WeatherList
    {
        public int id { set; get; }
        public string date { set; get; }
        public string city { set; get; }
        public int temp  { set; get; }
        public int temp_feels { set; get; }
        public int humidity { set; get; }
        public int wind { set; get; }
        public int temp_min { set; get; }
        public int temp_max { set; get; }
    }
}
