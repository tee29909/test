using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class FoodSet
    {

        public int FoodSetID { get; set; }
        public string Manu { get; set; }
        public string NameSet { get; set; }
        public virtual Canteen FoodSet_CanteenID { get; set; }
    }
}
