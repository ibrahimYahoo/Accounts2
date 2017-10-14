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
    public partial class Purchases : MetroFramework.Forms.MetroForm
    {
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            gvPurchase.DataSource = new DAO().GetPurchases();
        }


        public void PerformRefresh()
        {
            gvPurchase.DataSource = new DAO().GetPurchases();
        }
        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txtoldpurprice_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TxtitemPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gvPurchase_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
               lblmsg.Text ="Wrong Input!  Error";
            }
        }

        private void txtoldpurprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnadditem_Click(object sender, EventArgs e)
        {
            Forms.AddPurchase ac = new Forms.AddPurchase(this);
            ac.ShowDialog();
        }

        private void txtItemQuantity_Leave(object sender, EventArgs e)
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(gvPurchase.CurrentRow.Cells[0].Value.ToString());
            Forms.EditPurchase ec = new Forms.EditPurchase(pid,this);



            ec.cmbItemName.DataSource = new DAO().GetItems();
            ec.cmbItemName.DisplayMember = "IName";
            ec.cmbItemName.ValueMember = "IId";
            ec.cmbItemName.Text = this.gvPurchase.CurrentRow.Cells[3].Value.ToString();
            ec.TxtitemPrice.Text = this.gvPurchase.CurrentRow.Cells[5].Value.ToString();
            ec.txtItemQuantity.Text = this.gvPurchase.CurrentRow.Cells[7].Value.ToString();
            ec.cmbSupplierName.DataSource = new DAO().GetSuppliers();
            ec.cmbSupplierName.DisplayMember = "SName";
            ec.cmbSupplierName.ValueMember = "SId";
            ec.cmbSupplierName.Text = gvPurchase.CurrentRow.Cells[4].Value.ToString();
            ec.txtpurchaseprice.Text = gvPurchase.CurrentRow.Cells[6].Value.ToString();
            ec.cmbpaydate.Text = this.gvPurchase.CurrentRow.Cells[1].Value.ToString();
            ec.txttotal.Text = gvPurchase.CurrentRow.Cells[7].Value.ToString();           
            // ec. = int.Parse(this.gvPurchase.CurrentRow.Cells[0].Value.ToString());
            ec.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int cid = 0;
            try
            {
                cid = int.Parse(this.gvPurchase.CurrentRow.Cells[0].Value.ToString());
                if (cid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Purchase where PId=@PId", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", cid);
                        dad.Fill(dt);
                        conn.Close();

                        lblmsg.Text = "Record Deleted Successfully! ";
                        gvPurchase.DataSource = new DAO().GetPurchases();
                    }
                }
                else if (cid == 0)
                {
                    lblmsg.Text = "Please select record to Delete!";
                }
                else
                { }

            }
            catch (Exception)
            {


            }

        }
    }
}
