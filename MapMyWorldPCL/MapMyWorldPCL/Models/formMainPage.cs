﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class formMainPage
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
