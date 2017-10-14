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
using MetroFramework;

namespace WindowsFormsApplication1.Forms
{
    public partial class AddCus : MetroFramework.Forms.MetroForm
    {
        frmCustomer _owner;
        public AddCus(frmCustomer form1)
        {
            _owner = form1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCus_FormClosing);
            InitializeComponent();
            this.StyleManager = msmAddCus;
            msmAddCus.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmAddCus.Style = MetroFramework.MetroColorStyle.Teal;
    
        }

        private void AddCus_Load(object sender, EventArgs e)
        {

        }


        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCName.Text != "" && txtCPhone.Text != "")
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Customer(CName,CAddress,CEmail,CContact,CBalance) values(@CName,@Con,@Add1,@Add2,@bal)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtCName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Con", txtCAddress.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add1", txtCEmail.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Add2", txtCPhone.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@bal", txtCBalance.Text);

                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text = "Customer Added Successfully!!";
                    lblmsg.Visible = true;
                    CLEAR_ALL();
                   
                }
                else
                {
                    lblmsg.Text = "Please fill the textboxes!";
                    lblmsg.Visible = true; 
                }
            }
            catch (Exception)
            {
                lblmsg.Text = "Error! Please Try Again!";
                lblmsg.Visible = true;

            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void AddCus_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void txtCName_Click(object sender, EventArgs e)
        {

        }
    }
}
