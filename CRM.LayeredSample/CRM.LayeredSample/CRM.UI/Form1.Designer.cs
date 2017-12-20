namespace CRM.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.allAddresesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AllContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = false;
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Home.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(200, 50);
            this.Home.Text = "Home";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.AutoSize = false;
            this.customersToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCustomersToolStripMenuItem,
            this.updateCustomersToolStripMenuItem,
            this.deleteCustomersToolStripMenuItem,
            this.addCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // updateCustomersToolStripMenuItem
            // 
            this.updateCustomersToolStripMenuItem.Name = "updateCustomersToolStripMenuItem";
            this.updateCustomersToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.updateCustomersToolStripMenuItem.Text = "Update Customer";
            this.updateCustomersToolStripMenuItem.Click += new System.EventHandler(this.updateCustomersToolStripMenuItem_Click);
            // 
            // deleteCustomersToolStripMenuItem
            // 
            this.deleteCustomersToolStripMenuItem.Name = "deleteCustomersToolStripMenuItem";
            this.deleteCustomersToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.deleteCustomersToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomersToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomersToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allAddresesToolStripMenuItem,
            this.updateAddressToolStripMenuItem,
            this.deleteAddressToolStripMenuItem,
            this.addAddressToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 50);
            this.toolStripMenuItem4.Text = "Adres Details";
            // 
            // allAddresesToolStripMenuItem
            // 
            this.allAddresesToolStripMenuItem.Name = "allAddresesToolStripMenuItem";
            this.allAddresesToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.allAddresesToolStripMenuItem.Text = "All Addreses";
            this.allAddresesToolStripMenuItem.Click += new System.EventHandler(this.allAddresesToolStripMenuItem_Click_1);
            // 
            // updateAddressToolStripMenuItem
            // 
            this.updateAddressToolStripMenuItem.Name = "updateAddressToolStripMenuItem";
            this.updateAddressToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.updateAddressToolStripMenuItem.Text = "Update Address";
            this.updateAddressToolStripMenuItem.Click += new System.EventHandler(this.updateAddressToolStripMenuItem_Click);
            // 
            // deleteAddressToolStripMenuItem
            // 
            this.deleteAddressToolStripMenuItem.Name = "deleteAddressToolStripMenuItem";
            this.deleteAddressToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.deleteAddressToolStripMenuItem.Text = "DeleteAddress";
            this.deleteAddressToolStripMenuItem.Click += new System.EventHandler(this.deleteAddressToolStripMenuItem_Click);
            // 
            // addAddressToolStripMenuItem
            // 
            this.addAddressToolStripMenuItem.Name = "addAddressToolStripMenuItem";
            this.addAddressToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.addAddressToolStripMenuItem.Text = "Add Address";
            this.addAddressToolStripMenuItem.Click += new System.EventHandler(this.addAddressToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllContactToolStripMenuItem,
            this.updateContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem,
            this.addContactToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 50);
            this.toolStripMenuItem2.Text = "Contact  Details";
            // 
            // AllContactToolStripMenuItem
            // 
            this.AllContactToolStripMenuItem.Name = "AllContactToolStripMenuItem";
            this.AllContactToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.AllContactToolStripMenuItem.Text = "All Contacts";
            this.AllContactToolStripMenuItem.Click += new System.EventHandler(this.AllContactToolStripMenuItem_Click);
            // 
            // updateContactToolStripMenuItem
            // 
            this.updateContactToolStripMenuItem.Name = "updateContactToolStripMenuItem";
            this.updateContactToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.updateContactToolStripMenuItem.Text = "Update Contact";
            this.updateContactToolStripMenuItem.Click += new System.EventHandler(this.updateContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.customersToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(241, 402);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 402);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "CrmDB - Customers Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem allAddresesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AllContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

