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
    public partial class SaveCustomer : Form
    {
        public SaveCustomer()
        {
            InitializeComponent();
        }
        CustomerDAL customerDal = new CustomerDAL();
        FillCustomers fl = new FillCustomers();
        private void SaveCustomer_Load(object sender, EventArgs e)
        {
            lstvVeriler.Items.Clear();
            fl.FillAllCustomers(lstvVeriler);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Name = txtName.Text;
            c.Surname = txtSurname.Text;
            if (rbE.Checked)
            {
                c.Gender = false;
            }
            else
            {
                c.Gender = true;
            }

            if (customerDal.Save(c).IsSucceeded)
            {
                MessageBox.Show("Kişi başarıyla eklendi.");
                lstvVeriler.Items.Clear();
                fl.FillAllCustomers(lstvVeriler);
            }
            else
            {
                MessageBox.Show("Ekleme sırasında bir hatayla karşılaşıldı.");
            }
        }
      
    }
}
