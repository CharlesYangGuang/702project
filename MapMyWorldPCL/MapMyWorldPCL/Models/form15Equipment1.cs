using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form15Equipment1
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string What1 { get; set; }
        public string For1 { get; set; }
        public string When1 { get; set; }
        public string HowOften1 { get; set; }

        public string What2 { get; set; }
        public string For2 { get; set; }
        public string When2 { get; set; }
        public string HowOften2 { get; set; }

        public string What3 { get; set; }
        public string For3 { get; set; }
        public string When3 { get; set; }
        public string HowOften3 { get; set; }

        public string What4 { get; set; }
        public string For4 { get; set; }
        public string When4 { get; set; }
        public string HowOften4 { get; set; }

        public string What5 { get; set; }
        public string For5 { get; set; }
        public string When5 { get; set; }
        public string HowOften5 { get; set; }
    }
}
