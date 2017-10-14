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
using WindowsFormsApplication1.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class EditCus : MetroFramework.Forms.MetroForm
    {
        frmCustomer _owner;
        public int cid = 0;
        public EditCus(frmCustomer form1)
        {
            _owner = form1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCus_FormClosing);
            InitializeComponent();
            this.StyleManager = msmCusEdit;
            msmCusEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmCusEdit.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void EditCus_Load(object sender, EventArgs e)
        {

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose() ;
            Main frm = new Main();
            frm.Show();
        }

        public void CLEAR_ALL()
        {
            txtCName.Text = "";
            txtCAddress.Text = "";
            txtCBalance.Text = "";
            txtCEmail.Text = "";
            txtCPhone.Text = "";
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCName.Text != "" && txtCPhone.Text != "")
                {

                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Update Customer SET CName=@CName,CAddress=@Con,CEmail=@Add1,CContact=@Add2,CBalance=@bal where CId = @cid", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtCName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Con", txtCAddress.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add1", txtCEmail.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add2", txtCPhone.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@bal", txtCBalance.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@cid", cid);

                    dad.Fill(dt);
                    conn.Close();
                lblmsg.Text = "Customer Updated Successfully!! Success";
                    lblmsg.Visible = true;
                    CLEAR_ALL();
                    
                }
                else
                {
                    lblmsg.Text = "Please fill the textboxes!  ERROR!";
                    lblmsg.Visible = true;
                }
            }
            catch (Exception )
            {
                lblmsg.Text = "Error, Please try Again!  Stopped!";
                lblmsg.Visible = true;

            }
        }

        private void txtCAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtCPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtCEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtCName_Click(object sender, EventArgs e)
        {

        }

        private void EditCus_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void txtCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                lblmsg.Text = "Wrong Input!  Error";
            }
        }

        private void txtCBalance_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
