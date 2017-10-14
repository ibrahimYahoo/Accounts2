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
    public partial class EditSupp : MetroFramework.Forms.MetroForm
    {
    
        public int sid = 0;
        frmSuppliers owner = new frmSuppliers();
        public EditSupp(frmSuppliers form)
        {
            owner = form;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSupp_FormClosing);
            InitializeComponent();
            this.StyleManager = msmEditSupp;
            msmEditSupp.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmEditSupp.Style = MetroFramework.MetroColorStyle.Teal;
        }
        public void CLEAR_ALL()
        {
            txtSName.Text = "";
            txtSAddress.Text = "";
            txtSBalance.Text = "";
        
            txtSPhone.Text = "";
        }

        private void EditSupp_Load(object sender, EventArgs e)
        {

        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSName.Text != "" && txtSPhone.Text != "")
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Update Supplier SET SName=@CName,SAddress=@Con,SContact=@Add2,SBalance=@bal where SId = @cid", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtSName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Con", txtSAddress.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add2", txtSPhone.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@bal", txtSBalance.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@cid", sid);

                    dad.Fill(dt);
                    conn.Close();
                  lblmsg.Text ="Supplier Updated Successfully!! Success";
                    CLEAR_ALL();
                
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

            Refresh();

        }

        private void txtSAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtSPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtSBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtSName_Click(object sender, EventArgs e)
        {

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
                lblmsg.Text =  "Wrong Input! Error" ;
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

        private void EditSupp_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }
    }
}
