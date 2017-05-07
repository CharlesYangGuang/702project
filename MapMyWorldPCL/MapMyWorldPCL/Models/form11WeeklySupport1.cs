using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form11WeeklySupport1
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string DailyLiving { get; set; }
        public string Work { get; set; }
        public string Learning { get; set; }
        public string SocialCommunity { get; set; }
        public string Home { get; set; }
        public string HealthAndWellbeing { get; set; }
        public string Transport { get; set; }
    }
}
