using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity
{
    public class ContactDetails : BaseType
    {
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int CustomerID { get; set; }
    }
}
