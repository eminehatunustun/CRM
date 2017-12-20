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

namespace CRM.UI.Adress
{
    public partial class SaveAddress : Form
    {
        public SaveAddress()
        {
            InitializeComponent();
        }
        FillCustomers fl = new FillCustomers();
        AddressDetailsDAL adresDal = new AddressDetailsDAL();
        Customers secili;
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvVeriler.SelectedItems)
            {
                secili = li.Tag as Customers;
            }
            AddressDetails ad = new AddressDetails();
            ad.Address = txtAddress.Text;
            ad.City = txtCity.Text;
            ad.Country = txtCountry.Text;
            ad.CustomerID = secili.Id;
            if (adresDal.Save(ad).IsSucceeded)
            {
                MessageBox.Show("Adres başarıyla eklendi.");
                lstvVeriler.Items.Clear();
                fl.FillAllCustomers(lstvVeriler);             
            }
            else
            {
                MessageBox.Show("Ekleme sırasında bir hatayla karşılaşıldı.");
            }
        }

        private void SaveAddress_Load(object sender, EventArgs e)
        {
            lstvVeriler.Items.Clear();
            fl.FillAllCustomers(lstvVeriler);
        }
    }
}
