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
    public partial class Items : MetroFramework.Forms.MetroForm
    {
        Stock owner;
        public Items(Stock form)
        {
            owner = form;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Items_FormClosing);
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            cmbcatname.DataSource = new DAO().ShowCatList1();
            cmbcatname.DisplayMember = "Display";
            cmbcatname.ValueMember = "CatId";
            cmbcatname.SelectedIndex = -1;



        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text != "" && cmbcatname.Text != "")
                {

                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Items(IName,CatId,IQty,Iprice,IReorder) values(@IName,@catId,@IQty,@IPrice,@Ireorder)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@IName", txtItemName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@catId", cmbcatname.SelectedValue.ToString());
                    //dad.SelectCommand.Parameters.AddWithValue("@Con", txtcatname.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@IQty", txtItemQuantity.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@IPrice", TxtitemPrice.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Ireorder", metroTextBox1.Text);


                    dad.Fill(dt);
                    conn.Close();
                  lblmsg.Text = "Item Added Successfully!! Success";
                    CLEAR_ALL();
                }
                else
                {
                    lblmsg.Text = "Please fill all textboxes! ERROR!";
                }
            }
            catch (Exception)
            {
                lblmsg.Text = "Error, Please try Again! Stopped!";


            }
        }
        public void CLEAR_ALL()
        {
    //        txtcatname.Text = "";
            txtitemdesc.Text = "";
            txtItemName.Text = "";
            TxtitemPrice.Text = "";
            txtItemQuantity.Text = "";
            cmbcatname.Text = "";
            metroTextBox1.Text = "";
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
        }

        private void cmbcatname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtitemPrice_Click(object sender, EventArgs e)
        {

        }

        private void TxtitemPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addcategory frm = new addcategory();
            frm.ShowDialog();
        }
    }
}
    
