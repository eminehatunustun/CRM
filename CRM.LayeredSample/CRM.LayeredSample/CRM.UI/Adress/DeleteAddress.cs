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
    public partial class DeleteAddress : Form
    {
        public DeleteAddress()
        {
            InitializeComponent();
        }
        AddressDetailsDAL adresDal = new AddressDetailsDAL();
        FillAddress fl = new FillAddress();
        AddressDetails secili;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (adresDal.Delete(secili.Id).IsSucceeded)
            {
                MessageBox.Show("Adres bilgileri başarı ile silindi.");
                lstvAddress.Items.Clear();
                fl.FillAllAddress(lstvAddress);
            }
            else
            {
                MessageBox.Show("Silme sırasında bir hatayla karşılaşıldı.");
            }
            
        }
        private void DeleteAddress_Load(object sender, EventArgs e)
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
        }
    }
}
