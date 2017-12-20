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
    public partial class UpdateContact : Form
    {
        public UpdateContact()
        {
            InitializeComponent();
        }
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        CustomerDAL customerDal = new CustomerDAL();
        FillContact fl = new FillContact();
        ContactDetails secili;
        private void UpdateContact_Load(object sender, EventArgs e)
        {
            lstvContact.Items.Clear();
            fl.FillAllContact(lstvContact);
        }

        private void lstvContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvContact.SelectedItems)
            {
                secili = li.Tag as ContactDetails;
            }
            txtMail.Text = secili.Mail;
            mtxtPhone.Text = secili.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            secili.Mail = txtMail.Text;
            secili.Phone = mtxtPhone.Text;
            if (contactDal.Update(secili).IsSucceeded)
            {
                lstvContact.Items.Clear();
                fl.FillAllContact(lstvContact);
                MessageBox.Show("İletişim bilgileri başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("İletişim bilgileri güncellenirken bir hatayla karşılaşıldı.");
            }
        }

        private void lstvContact_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
