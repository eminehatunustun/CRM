using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity
{
    public class Customers : BaseType
    {
        public Customers()
        {
            this.CreateDate = DateTime.Now;
           // this.Id = Convert.ToInt32(Guid.NewGuid());
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool? Gender { get; set; }
        public string PhotoPath { get; set; }
    }
}

