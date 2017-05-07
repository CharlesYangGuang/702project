using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form13HealthWellbeing
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string HealthConcerns { get; set; }
        public string ImportantThings { get; set; }
        public string GoingWell { get; set; }
        public string NotWorkingWell { get; set; }
    }
}
