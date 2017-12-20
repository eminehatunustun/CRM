using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Common;
using CRM.Entity;

namespace CRM.Dal.FillListView
{
    public class FillCustomers
    {
        public void FillAllCustomers(ListView lstv)
        {
            CustomerDAL dal = new CustomerDAL();
            Result<List<Customers>> result = dal.ListOfCustomers();
            if (result.IsSucceeded == true)
            {
                foreach (Customers c in result.TransactionResult)
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = c;
                    li.Text = c.Name;
                    li.SubItems.Add(c.Surname);
                    lstv.Items.Add(li);
                }
            }
        }
    }
}
