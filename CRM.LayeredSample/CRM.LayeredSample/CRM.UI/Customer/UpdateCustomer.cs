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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        CustomerDAL customerDal = new CustomerDAL();
        Customers secili = new Customers();
        FillCustomers fl = new FillCustomers();
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            lstvVeriler.Items.Clear();
            fl.FillAllCustomers(lstvVeriler);
        }

        private void lstvVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (ListViewItem li in lstvVeriler.SelectedItems)
            {
                secili = li.Tag as Customers;
            }
            txtName.Text = secili.Name;
            txtSurname.Text = secili.Surname;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (secili.Id!=0)
            {
                secili.Name = txtName.Text;
                secili.Surname = txtSurname.Text;
                if (customerDal.Update(secili).IsSucceeded)
                {
                    MessageBox.Show("Kişi başarıyla güncellendi.");
                    lstvVeriler.Items.Clear();
                    fl.FillAllCustomers(lstvVeriler);

                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hatayla karşılaşıldı.");

                }
            }
        }

        private void lstvVeriler_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
