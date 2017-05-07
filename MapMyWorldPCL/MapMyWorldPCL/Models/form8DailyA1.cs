﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class form8DailyA1
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string WhatIM { get; set; } // M = Monday
        public string WhatIsM { get; set; }
        public string WhatIsNotM { get; set; }
        public string WhatIT { get; set; } // T = Tuesday
        public string WhatIsT { get; set; }
        public string WhatIsNotT { get; set; }

    }
}
