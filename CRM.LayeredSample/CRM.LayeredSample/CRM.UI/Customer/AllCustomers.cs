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

namespace CRM.UI.Customer
{
    public partial class AllCustomers : Form
    {
        public AllCustomers()
        {
            InitializeComponent();
        }
        CustomerDAL dal = new CustomerDAL();
        AddressDetailsDAL addressDal = new AddressDetailsDAL();
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        private void AllCustomers_Load(object sender, EventArgs e)
        {
            FillCustomers fl = new FillCustomers();
            fl.FillAllCustomers(lstvVeriler);
        }
        private void lstvVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customers secili;
            int ID = 0;
            foreach (ListViewItem c in lstvVeriler.SelectedItems)
            {
                secili = c.Tag as Customers;
                ID = secili.Id;
            }
            //-----------------------------------------------------------------------------
            AdresleriGetir(ID);
            ContactDetailsGetir(ID);
        }

        private void ContactDetailsGetir(int ID)
        {
            lstvContact.Items.Clear();
            Result<List<ContactDetails>> result = contactDal.ListIDContact(ID);
            if (result.IsSucceeded)
            {
                foreach (ContactDetails cd in result.TransactionResult)
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = cd;
                    li.Text = cd.Mail;
                    li.SubItems.Add(cd.Phone);
                    lstvContact.Items.Add(li);
                }
            }
        }

        private void AdresleriGetir(int ID)
        {
            lstvAddress.Items.Clear();
            Result<List<AddressDetails>> result = addressDal.ListIDAddress(ID);
            if (result.IsSucceeded)
            {
                foreach (AddressDetails ad in result.TransactionResult)
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = ad;
                    li.Text = ad.Address;
                    li.SubItems.Add(ad.City);
                    li.SubItems.Add(ad.Country);
                    lstvAddress.Items.Add(li);
                }
            }
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.AllCustomers frm = new Customer.AllCustomers();
            frm.Show();
            this.Close();
        }

        private void updateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.UpdateCustomer frm = new Customer.UpdateCustomer();
            frm.Show();
            this.Close();
        }

        private void deleteCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.DeleteCustomer frm = new Customer.DeleteCustomer();
            frm.Show();
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.SaveCustomer frm = new Customer.SaveCustomer();
            frm.Show();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
