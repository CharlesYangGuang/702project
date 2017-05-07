using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMyWorldPCL.Models
{
    public class form9DailyA2
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string WhatIW { get; set; } // W = Wednesday
        public string WhatIsW { get; set; }
        public string WhatIsNotW { get; set; }
        public string WhatITh { get; set; }  // Th = Thursday
        public string WhatIsTh { get; set; }
        public string WhatIsNotTh { get; set; }
        public string WhatIF { get; set; }  // F = Friday
        public string WhatIsF { get; set; }
        public string WhatIsNotF { get; set; }

    }
}
