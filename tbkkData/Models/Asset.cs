using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string SerailNumber { get; set; }
        public string MACAddr { get; set; }
        public DateTime InstallDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public virtual Location Asset_LocationID { get; set; }
        public virtual Company Asset_CompanyID { get; set; }
        public virtual Department Asset_DepartmentID { get; set; }
        public virtual Supplier Asset_SupplierID { get; set; }
        public virtual Employee EmployeeID { get; set; }
        public virtual Model ModelID { get; set; }
    }
}
