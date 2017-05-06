using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class form5TheWay
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string BeInvolved { get; set; }
        public string NDISMeeting { get; set; }
        public string HowCommunicate { get; set; }
        public string FinalDecision { get; set; }

    }
}
