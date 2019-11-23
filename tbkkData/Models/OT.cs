using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class OT
    {
        public int OTID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string TypeOT { get; set; }
    }
}
