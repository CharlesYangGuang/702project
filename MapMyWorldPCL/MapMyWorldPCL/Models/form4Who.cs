﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class form4Who
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string WhatImportant { get; set; }
        public string WhatLike { get; set; }
        public string OtherLikeAbout { get; set; }
        public string HowSupport { get; set; }
    }
}
