using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Dal;
using CRM.Entity;
using CRM.Dal.FillListView;
namespace CRM.UI.Adress
{
    public partial class UpdateAddress : Form
    {
        public UpdateAddress()
        {
            InitializeComponent();
        }
        AddressDetailsDAL adresDal = new AddressDetailsDAL();
        FillAddress fl = new FillAddress();
        AddressDetails secili;
        private void UpdateAddress_Load(object sender, EventArgs e)
        {
            lstvAddress.Items.Clear();
            fl.FillAllAddress(lstvAddress);
        }

        private void lstvAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvAddress.SelectedItems)
            {
                secili = li.Tag as AddressDetails;
            }
            txtAddress.Text = secili.Address;
            txtCity.Text = secili.City;
            txtCountry.Text = secili.Country;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            secili.Address = txtAddress.Text;
            secili.City = txtCity.Text;
            secili.Country = txtCountry.Text;
            if (adresDal.Update(secili).IsSucceeded)
            {
                MessageBox.Show("Adres bilgileri başarıyla güncellendi.");
                lstvAddress.Items.Clear();
                fl.FillAllAddress(lstvAddress);
            }
            else
            {
                MessageBox.Show("Adres bilgileri güncellenirken bir hatayla karşılaşıldı.");
            }
        }
    }
}
