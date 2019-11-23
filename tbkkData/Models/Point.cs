using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Point
    {
        public int PointID { get; set; }
        public string NamePoint { get; set; }
        public virtual Part Point_PartID { get; set; }
    }
}
