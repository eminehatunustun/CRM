using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.UI
{
    using CRM.Common;
    using CRM.Dal;
    using CRM.Entity;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerDAL dal = new CustomerDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.AllCustomers frm = new Customer.AllCustomers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void updateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.UpdateCustomer frm = new Customer.UpdateCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.DeleteCustomer frm = new Customer.DeleteCustomer();
            frm.Show();
            frm.MdiParent = this;
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.SaveCustomer frm = new Customer.SaveCustomer();
            frm.Show();
            frm.MdiParent = this;
        }
        private void allAddresesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Adress.AllAdreses frm = new Adress.AllAdreses();
            frm.Show();
            frm.MdiParent = this;
        }

        private void updateAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adress.UpdateAddress frm = new Adress.UpdateAddress();
            frm.Show();
            frm.MdiParent = this;
        }

        private void deleteAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adress.DeleteAddress frm = new Adress.DeleteAddress();
            frm.Show();
            frm.MdiParent = this;
        }

        private void addAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adress.SaveAddress frm = new Adress.SaveAddress();
            frm.Show();
            frm.MdiParent = this;
        }
        private void AllContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.AllContacts frm = new Contact.AllContacts();
            frm.Show();
            frm.MdiParent = this;
        }
        private void updateContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.UpdateContact frm = new Contact.UpdateContact();
            frm.Show();
            frm.MdiParent = this;
        }
        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.DeleteContact frm = new Contact.DeleteContact();
            frm.Show();
            frm.MdiParent = this;
        }
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.SaveContact frm = new Contact.SaveContact();
            frm.Show();
            frm.MdiParent = this;
        }
    }
}
