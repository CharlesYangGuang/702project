using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class form7MyHome
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string TypeOfHome { get; set; }
        public string PeopleLiveWith { get; set; }
        public string WhoHelp { get; set; }
        public string WhatHelp { get; set; }
        public string Equipment { get; set; }
    }
}
