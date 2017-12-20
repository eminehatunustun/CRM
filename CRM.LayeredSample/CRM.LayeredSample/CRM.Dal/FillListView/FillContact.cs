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
    public class FillContact
    {
        public void FillAllContact(ListView lstv)
        {
            ContactDetailsDAL contactDal = new ContactDetailsDAL();
            Result<List<ContactDetails>> rLc = contactDal.ListOfContact();
            foreach (ContactDetails cd in rLc.TransactionResult)
            {
                ListViewItem li = new ListViewItem();
                li.Tag = cd;
                li.Text = cd.Mail;
                li.SubItems.Add(cd.Phone);
                lstv.Items.Add(li);
            }
        }
    }
}
