using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form12WeeklySupport2
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string BehaviourSupport { get; set; }
        public string Respite { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }
        public string Other3 { get; set; }
        public string Other4 { get; set; }
    }
}
