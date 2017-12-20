using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Common;
using CRM.Dal;
using CRM.Entity;
using CRM.Dal.FillListView;

namespace CRM.UI.Contact
{
    public partial class AllContacts : Form
    {
        public AllContacts()
        {
            InitializeComponent();
        }
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        CustomerDAL customerDal = new CustomerDAL();
        FillContact fl = new FillContact();
        private void AllContacts_Load(object sender, EventArgs e)
        {
            lstvContact.Items.Clear();
            fl.FillAllContact(lstvContact);
        }
        private void lstvContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            ContactDetails secili;
            int ID = 0;
            foreach (ListViewItem li in lstvContact.SelectedItems)
            {
                secili = li.Tag as ContactDetails;
                ID = secili.CustomerID;
            }

            Result<List<Customers>> rLc = customerDal.ListIDCustomers(ID);
            foreach (Customers c in rLc.TransactionResult)
            {
                txtName.Text = c.Name;
                txtSurname.Text = c.Surname;
            }
        }

        private void Temizle()
        {
            txtName.Clear();
            txtSurname.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
