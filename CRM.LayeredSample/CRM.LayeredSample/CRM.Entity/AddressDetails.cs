using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity
{
    public class AddressDetails :BaseType
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CustomerID { get; set; }
    }
}
