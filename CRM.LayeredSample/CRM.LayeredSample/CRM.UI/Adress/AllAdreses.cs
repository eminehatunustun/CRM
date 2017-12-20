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

namespace CRM.UI.Adress
{
    public partial class AllAdreses : Form
    {
        public AllAdreses()
        {
            InitializeComponent();
        }
        AddressDetailsDAL addressDal = new AddressDetailsDAL();
        CustomerDAL customerDal = new CustomerDAL();
        private void AllAdreses_Load(object sender, EventArgs e)
        {
            Result<List<AddressDetails>> rLa = addressDal.ListAllAddress();
            foreach (AddressDetails ad in rLa.TransactionResult)
            {
                ListViewItem li = new ListViewItem();
                li.Tag = ad;
                li.Text = ad.Address;
                li.SubItems.Add(ad.City);
                li.SubItems.Add(ad.Country);
                lstvAddress.Items.Add(li);
            }
        }

        private void lstvAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            AddressDetails secili;
            int ID=0;
            foreach (ListViewItem li in lstvAddress.SelectedItems)
            {
                secili = li.Tag as AddressDetails;
                ID = secili.CustomerID;
            }
            
            Result<List<Customers>> rLc = customerDal.ListIDCustomers(ID);
            foreach (Customers c in rLc.TransactionResult)
            {
                txtName.Text= c.Name;
                txtSurname.Text = c.Surname;
            }
        }

        private void Temizle()
        {
            txtName.Clear();
            txtSurname.Clear();
        }
    }
}
