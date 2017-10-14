using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms;
using WindowsFormsApplication1.Forms.Accounts;
using WindowsFormsApplication1.Forms.Order;
using WindowsFormsApplication1.Forms.Search;

namespace WindowsFormsApplication1
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Forms.Stock ac = new Forms.Stock();
            ac.Show();
            ac.WindowState = FormWindowState.Maximized;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddOrder addorder = new AddOrder();
            addorder.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Hide();

            Purchases ac = new Purchases();
            ac.Show();
            ac.WindowState = FormWindowState.Maximized;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCustomer ac = new frmCustomer();
            ac.Show();
            ac.WindowState = FormWindowState.Maximized;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSuppliers ac = new frmSuppliers();
            ac.Show();
            ac.WindowState = FormWindowState.Maximized;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();

            Payments ac = new Payments();
            ac.Show();
            ac.WindowState = FormWindowState.Maximized;

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAccounts fa = new frmAccounts();
            fa.Show();
            fa.WindowState = FormWindowState.Maximized;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSearch search = new frmSearch();
            search.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login frm = new Login();
            frm.Show();
        }

        
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            transactions transObj = new transactions();
            transObj.Show();
          

        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            JournalVoucher JvObj = new JournalVoucher();
            JvObj.Show();

        }
    }
}
