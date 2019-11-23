using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class CarType
    {
        public int CarTypeID { get; set; }
        public int CerNumber { get; set; }
        public string NameCar { get; set; }
        public string Seat { get; set; }
        public virtual CompanyCar CarType_CompanyCarID { get; set; }
    }
}
