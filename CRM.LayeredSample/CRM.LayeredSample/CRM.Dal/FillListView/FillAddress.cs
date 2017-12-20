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
    public class FillAddress
    {
        public void FillAllAddress(ListView lstv)
        {
            AddressDetailsDAL dal = new AddressDetailsDAL();
            Result<List<AddressDetails>> rLa = dal.ListAllAddress();
            foreach (AddressDetails ad in rLa.TransactionResult)
            {
                ListViewItem li = new ListViewItem();
                li.Tag = ad;
                li.Text = ad.Address;
                li.SubItems.Add(ad.City);
                li.SubItems.Add(ad.Country);
                lstv.Items.Add(li);
            }
        }
    }
}
