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
    public partial class EditPurchase : MetroFramework.Forms.MetroForm
    {
        Purchases owner;
        int PID;
        float prevQty;
        decimal prevBalance;
        public EditPurchase(int pid,Purchases frm1)
        {
            
            PID = pid;
            owner = frm1;
            FormClosing += new FormClosingEventHandler(EditPurchase_FormClosing);
            InitializeComponent();
        }

        private void EditPurchase_Load(object sender, EventArgs e)
        {
            prevQty = float.Parse(txtItemQuantity.Text);
            prevBalance = decimal.Parse(txttotal.Text);
            //cmbsuppname.DataSource = new DAO().GetSupp();
            //cmbsuppname.DisplayMember = "Display";
            //cmbsuppname.ValueMember = "SId";
            //cmbsuppname.SelectedIndex = -1;

            //cmbItemname.DataSource = new DAO().GetItemsDesc();
            //cmbItemname.DisplayMember = "Display";
            //cmbItemname.ValueMember = "IID";
            //cmbItemname.SelectedIndex = -1;

            //txtoldpurprice.Text = 0.ToString();
            //txtItemQuantity.Text = 0.ToString();
            //TxtitemPrice.Text = 0.ToString();

            //lblqty.Visible = false;
        }

        private void cmbsuppname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                if (cmbItemName.SelectedIndex != -1)
                {
                    bool parseOK = Int32.TryParse(cmbItemName.SelectedValue.ToString(), out x);
                }
                if (x != 0)
                {
                    //testtxt.Text = Convert.ToString(itemcmb.SelectedValue);
                    DataTable item = new DAO().ShowItemsByID(Convert.ToInt32(cmbItemName.SelectedValue));
                    txtpurchaseprice.Text = Convert.ToString(item.Rows[0][3]);
                    lblqty.Text = "Quantity left : " + Convert.ToString(item.Rows[0][4]);
                    lblqty.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Wrong Input!", "Error");
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
                MessageBox.Show("Wrong Input!", "Error");
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
                MessageBox.Show("Wrong Input!", "Error");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtItemQuantity.Text = 0.ToString();
            TxtitemPrice.Text = 0.ToString();
            txtpurchaseprice.Text = 0.ToString();
            cmbItemName.Text = " ";
            cmbpaydate.Text = "";
            cmbSupplierName.Text = "";
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplierName.Text != "" && cmbItemName.Text != "" && txtItemQuantity.Text != "" && TxtitemPrice.Text != "")
                {
                    new DAO().DeleteQty(int.Parse(cmbItemName.SelectedValue.ToString()), prevQty);
                    new DAO().DelSuppBalance(int.Parse(cmbSupplierName.SelectedValue.ToString()), prevBalance);
                    //int sid = new DAO().getSupplierIdFromName(cmbSupplierName.Text);
                    //decimal total = decimal.Parse(txttotal.Text);
                    //new DAO().SubSuppBalance(sid, total);
                    SqlConnection conn = DBConn.GetInstance();
                    SqlCommand cmd = new SqlCommand("update purchase set IId = @iid , ItemQty = @itemQty, PurPrice = @purprice, IPrice = @iprice , SId = @sid, PDate = @paydate,Total = @total where pid = @pid;", conn);
                    cmd.Parameters.AddWithValue("@pid", PID);
                    cmd.Parameters.AddWithValue("@iid", int.Parse(cmbItemName.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@sid", int.Parse(cmbSupplierName.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@paydate", cmbpaydate.Value);
                    cmd.Parameters.AddWithValue("@purprice", decimal.Parse(txtpurchaseprice.Text));
                    cmd.Parameters.AddWithValue("@iprice", decimal.Parse(TxtitemPrice.Text));
                    cmd.Parameters.AddWithValue("@itemQty", decimal.Parse(txtItemQuantity.Text));
                    cmd.Parameters.AddWithValue("@total", decimal.Parse( txttotal.Text));
                    cmd.ExecuteNonQuery();
                    new DAO().UpdateQtyAdd(int.Parse(cmbItemName.SelectedValue.ToString()), float.Parse(txtItemQuantity.Text));
                    new DAO().AddSuppBalance(int.Parse(cmbSupplierName.SelectedValue.ToString()), decimal.Parse(txttotal.Text));
                    MessageBox.Show("Purchase Updated Successfully!!!");

                
                }
                else
                {
                    MessageBox.Show("Choose a record to update/ Completely fill the record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }


        private void cmbSupplierName_Click(object sender, EventArgs e)
        {

        }

        private void cmbItemName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void EditPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }

        private void txtItemQuantity_Leave(object sender, EventArgs e)
        {
            if (TxtitemPrice.Text == "")
            {
                TxtitemPrice.Text = 0.ToString();
            }else
            {
                decimal qty = decimal.Parse(txtItemQuantity.Text);
                decimal price = decimal.Parse(txtpurchaseprice.Text);
                decimal total = qty * price;
                txttotal.Text = total.ToString();
            }
                 
        }

        private void txtItemQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
