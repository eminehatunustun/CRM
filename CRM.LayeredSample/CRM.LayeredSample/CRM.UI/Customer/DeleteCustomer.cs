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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }
        Customers secili;
        int ID;
        FillCustomers fl = new FillCustomers();
        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            lstvVeriler.Items.Clear();
            fl.FillAllCustomers(lstvVeriler);
        }
        AddressDetailsDAL addressDal = new AddressDetailsDAL();
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        CustomerDAL customerDal = new CustomerDAL();
        private void lstvVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvVeriler.SelectedItems)
            {
                secili = li.Tag as Customers;
                ID = secili.Id;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Silmek istediğinize Emin misiniz? (Kişinin tüm bilgileri silinecektir)", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer == DialogResult.Yes)
            {
                if (ID != 0)
                {
                    addressDal.DeleteCustomerID(ID);
                    contactDal.DeleteCustomerID(ID);
                    if (customerDal.Delete(ID).IsSucceeded)
                    {
                        MessageBox.Show("Kişi başarıyla silindi");
                        lstvVeriler.Items.Clear();
                        fl.FillAllCustomers(lstvVeriler);
                    }
                }
            }
        }
    }
}
