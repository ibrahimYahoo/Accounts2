using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms
{
    public partial class AddSupp : MetroFramework.Forms.MetroForm
    {

        frmSuppliers owner = new frmSuppliers();
       
        public AddSupp(frmSuppliers form)
        {
            owner = form;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSupp_FormClosing);
            InitializeComponent();
            this.StyleManager = msmAddSupp;
            msmAddSupp.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmAddSupp.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void AddSupp_Load(object sender, EventArgs e)
        {

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        public void ClEAR_ALL()
        {
            txtSAddress.Text = "";
            txtSBalance.Text = "";
            txtSName.Text = "";
            txtSPhone.Text = "";
        }
        private void mtClear_Click(object sender, EventArgs e)
        {
            ClEAR_ALL();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSName.Text != "" && txtSPhone.Text != "")
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Supplier(SName,SAddress,SContact,SBalance) values(@CName,@Con,@Add1,@bal)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtSName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Con", txtSAddress.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add1", txtSPhone.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@bal", txtSBalance.Text);

                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text = "Supplier Added Successfully!! Success";
                    ClEAR_ALL();
                 
                }
                else
                {
                    lblmsg.Text = "Please fill the textboxes! ERROR!";
                }
            }
            catch (Exception)
            {
                lblmsg.Text = "Error, Please try Again! Stopped!";

            }
        }

        private void txtSPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                lblmsg.Text = "Wrong Input! Error";
            }
        }

        private void txtSBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                lblmsg.Text = "Wrong Input! Error";
            }
        }

        private void AddSupp_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }
    }
}
