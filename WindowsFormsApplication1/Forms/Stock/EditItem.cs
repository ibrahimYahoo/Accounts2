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
    public partial class EditItem : MetroFramework.Forms.MetroForm
    {

        Stock owner = new Stock();

        public EditItem(Stock form)

        {
            owner = form;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditItem_FormClosing);
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
           
        }

        private void txtItemName_Click(object sender, EventArgs e)
        {

        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
        }
        public void CLEAR_ALL()
        {
            txtitemdesc.Text = "";
            txtItemName.Text = "";
            TxtitemPrice.Text = "";
            txtItemQuantity.Text = "";
            cmbcatname.Text = "";
            txtReOrder.Text = "";
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text != "" && TxtitemPrice.Text != "" && txtItemQuantity.Text != "" && txtReOrder.Text != "" && cmbcatname.Text != "")
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();
                    int a = new DAO().GetCatIdfromDesc(cmbcatname.Text);
                    SqlDataAdapter dad = new SqlDataAdapter("Update Items SET IName=@1,CatId=@2, IPrice=@3, IQty=@4,IReorder=@5 where IId=@6", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@1",txtItemName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@2", new DAO().GetCatIdfromDesc(cmbcatname.Text));
                    dad.SelectCommand.Parameters.AddWithValue("@3", TxtitemPrice.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@4", txtItemQuantity.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@5", txtReOrder.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@6", new DAO().getItemIdFromName(txtItemName.Text));

                    dad.Fill(dt);
                    conn.Close();
                  lblmsg.Text = "Item Updated Successfully!!";
                    CLEAR_ALL();
                }
                else
                    lblmsg.Text = "Please fill the textboxes!  Error";
            }
            catch (Exception ex)
            {
                lblmsg.Text = (ex.Message);
            }

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void cmbcatname_Click(object sender, EventArgs e)
        {
            cmbcatname.DataSource = new DAO().ShowCatList1();
            cmbcatname.DisplayMember = "Display";
            cmbcatname.ValueMember = "CatId";
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
                lblmsg.Text = "Wrong Input!  Error";
            }
        }

        private void txtReOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                lblmsg.Text =  "Wrong Input! Error";
            }
        }

        private void EditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }
    }

}
