using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form20BucketList
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string UltimateWish { get; set; }
    }
}
