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
    public partial class SaveContact : Form
    {
        public SaveContact()
        {
            InitializeComponent();
        }
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        FillCustomers fl = new FillCustomers();
        Customers secili;
        private void SaveContact_Load(object sender, EventArgs e)
        {
            lstvVeriler.Items.Clear();
            fl.FillAllCustomers(lstvVeriler);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvVeriler.SelectedItems)
            {
                secili = li.Tag as Customers;
            }
            ContactDetails cd = new ContactDetails();
            cd.Mail = txtMail.Text;
            cd.Phone = mtxtPhone.Text;
            cd.CustomerID = secili.Id;
            if (contactDal.Save(cd).IsSucceeded)
            {
                MessageBox.Show("İletişim bilgileri başarıyla eklendi.");
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
