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
    public partial class DeleteContact : Form
    {
        public DeleteContact()
        {
            InitializeComponent();
        }
        ContactDetails secili;
        ContactDetailsDAL contactDal = new ContactDetailsDAL();
        FillContact fl = new FillContact();
        int ID;
        private void DeleteContact_Load(object sender, EventArgs e)
        {
            lstvContact.Items.Clear();
            fl.FillAllContact(lstvContact);
        }

        private void lstvContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstvContact.SelectedItems)
            {
                secili = li.Tag as ContactDetails;
                ID = secili.CustomerID;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer==DialogResult.Yes)
            {
                if (contactDal.DeleteCustomerID(ID).IsSucceeded)
                {
                    lstvContact.Items.Clear();
                    fl.FillAllContact(lstvContact);
                    MessageBox.Show("İletişim bilgileri başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("İletişim bilgileri silinirken bir hatayla karşılaşıldı.");
                }
            }
        }
    }
}
