using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class DetailOT
    {
        public int DetailOTID { get; set; }
        public int Hour { get; set; }
        public string Type { get; set; }
        public int CarNumber { get; set; }
        public int Status { get; set; }
        public virtual Employee DetailOT_EmployeeID { get; set; }
        public virtual Part DetailOT_PartID { get; set; }
        public virtual CarType DetailOT_CarTypeID { get; set; }
        public virtual FoodSet DetailOT_FoodSetID { get; set; }
        public virtual OT DetailOT_OTID { get; set; }
    }
}
