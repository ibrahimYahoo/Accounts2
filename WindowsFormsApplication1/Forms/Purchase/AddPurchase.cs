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
    public partial class AddPurchase : MetroFramework.Forms.MetroForm
    {
        Purchases owner;
        public AddPurchase(Purchases frm1)
        {
            owner = frm1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPurchase_FormClosing);
            InitializeComponent();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {


            cmbsuppname.DataSource = new DAO().GetParties();
            cmbsuppname.DisplayMember = "Name";
            cmbsuppname.ValueMember = "Party-ID";
            cmbsuppname.SelectedIndex = -1;

            cmbItemname.DataSource = new DAO().GetItems();
            cmbItemname.DisplayMember = "IName";
            cmbItemname.ValueMember = "IId";
            cmbItemname.SelectedIndex = -1;

            TxtitemPrice.Text = 0.ToString();
            txtItemQuantity.Text = 0.ToString();

            txtoldpurprice.Text = "0";
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbsuppname.SelectedIndex != -1 && cmbItemname.SelectedIndex != -1 && txtItemQuantity.Text != "" && TxtitemPrice.Text != "")
                {
                    int PId = int.Parse(cmbsuppname.SelectedValue.ToString());
                    string purid = new DAO().GetPurchaseId().ToString();
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad = new SqlDataAdapter("Insert INTO Purchase(IId,PId,PurDate,IPrice,PurPrice,ItemQty,Total) values (@3,@4,@5,@6,@7,@8,@9)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@3", cmbItemname.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@4", cmbsuppname.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@5", cmbpaydate.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@6", TxtitemPrice.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@7", txtoldpurprice.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@8", txtItemQuantity.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@9", txttotal.Text);

                    decimal balance = int.Parse(txttotal.Text) - int.Parse(txtAmountPaid.Text);
                    
                    dad.Fill(dt);
                    conn.Close();
                   decimal RemainingBalance = new DAO().GetPartyBalance(PId);
                   new DAO().AddPurchaseTransaction(PId, 0, int.Parse(txtAmountPaid.Text), int.Parse(cmbItemname.SelectedValue.ToString()), int.Parse(txtItemQuantity.Text), "NA", DateTime.Today.Date, 1, RemainingBalance - balance);
                   new DAO().UpdateQtyAdd(int.Parse(cmbItemname.SelectedValue.ToString()), int.Parse(txtItemQuantity.Text));
                   new DAO().UpdateOwnerBalance(PId, balance);

                   
                    MessageBox.Show("Purchase Inserted successfully");
                    cmbsuppname.DataSource = new DAO().GetParties();
                    cmbsuppname.DisplayMember = "Name";
                    cmbsuppname.ValueMember = "Party-ID";
                    cmbsuppname.SelectedIndex = -1;

                    cmbItemname.DataSource = new DAO().GetItemsDesc();
                    cmbItemname.DisplayMember = "Display";
                    cmbItemname.ValueMember = "IId";
                    cmbItemname.SelectedIndex = -1;

                    txtoldpurprice.Text = 0.ToString();
                    txtItemQuantity.Text = 0.ToString();
                    TxtitemPrice.Text = 0.ToString();
                //    gvPurchase.DataSource = new DAO().GetPurchases();
                //    gvPurchase.Show();
                 //   lblqty.Visible = false;

                }
                else
                {
                    MessageBox.Show("Please fill all the textboxes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtItemQuantity_Leave(object sender, EventArgs e)
        {

            if (TxtitemPrice.Text == "")
            {
                TxtitemPrice.Text = 0.ToString();
            }
            try
            {

                txttotal.Text = (Convert.ToInt32(txtoldpurprice.Text) * Convert.ToInt32(txtItemQuantity.Text)).ToString();

            }

            catch (Exception)
            {
                MessageBox.Show("Please enter values correctly!");

            }
        }

    

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtItemQuantity.Text = 0.ToString();
            TxtitemPrice.Text = 0.ToString();
            txtoldpurprice.Text = 0.ToString();
            cmbItemname.Text = " ";
            cmbpaydate.Text = "";
            cmbsuppname.Text = "";
            txttotal.Text = 0.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }

        private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                if (cmbItemname.SelectedIndex != -1)
                {
                    bool parseOK = Int32.TryParse(cmbItemname.SelectedValue.ToString(), out x);
                }
                if (x != 0)
                {
                    DataTable item = new DAO().ShowItemsByID(Convert.ToInt32(cmbItemname.SelectedValue));                  
                    txtoldpurprice.Text = Math.Round(decimal.Parse(item.Rows[0][3].ToString()), 0).ToString();
                    //lblqty.Text = "Quantity left : " + Convert.ToString(item.Rows[0][6]);
                    //lblqty.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbsuppname_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtoldpurprice_Leave(object sender, EventArgs e)
        {
            if (TxtitemPrice.Text == "")
            {
                TxtitemPrice.Text = 0.ToString();
            }
            try
            {

                txttotal.Text = (Convert.ToInt32(txtoldpurprice.Text) * Convert.ToInt32(txtItemQuantity.Text)).ToString();

            }

            catch (Exception)
            {
                MessageBox.Show("Please enter values correctly!");

            }
        }

        private void AddPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }
    }
}
