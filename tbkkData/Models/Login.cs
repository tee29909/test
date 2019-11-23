using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Login
    {
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual Employee Login_EmployeeID { get; set; }
    }
}
