using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class form6Important
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string MyFamily { get; set; }
        public string WorkOrSchool { get; set; }
        public string HomeAndSupporters { get; set; }
        public string FriendsAndOthers { get; set; }
        public string VeryClose1 { get; set; }
        public string VeryClose2 { get; set; }
        public string VeryClose3 { get; set; }
        public string VeryClose4 { get; set; }



    }
}
