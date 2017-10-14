using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class frmCart : MetroFramework.Forms.MetroForm
    {
        int OrderNo = 0;
        public frmCart()
        {
            InitializeComponent();
        }
        public frmCart(int orderno)
        {
            InitializeComponent();
            OrderNo = orderno;
            this.StyleManager = msmCart;
            msmCart.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmCart.Style = MetroFramework.MetroColorStyle.Teal;
            gvCart.DataSource = new DAO().Get_Cart(orderno);
            lblTotal.Text = new DAO().getTotal(orderno).ToString();
        }

        public void PerformRefresh(int order)
        {
            gvCart.DataSource = new DAO().Get_Cart(order);
            lblTotal.Text = new DAO().getTotal(order).ToString();
        }

        private void mtEdit_Click(object sender, EventArgs e)
        {
            try
            {

                EditOrder ec = new EditOrder(int.Parse(gvCart.CurrentRow.Cells[4].Value.ToString()), decimal.Parse(gvCart.CurrentRow.Cells[6].Value.ToString()), OrderNo,  this);
                ec.lblItemName.Text = gvCart.CurrentRow.Cells[5].Value.ToString();
                ec.nmQty.Value = decimal.Parse(gvCart.CurrentRow.Cells[6].Value.ToString());
                ec.lblTotalQty.Text = new DAO().getQty(int.Parse(gvCart.CurrentRow.Cells[4].Value.ToString())).ToString();
                ec.lblCost.Text = gvCart.CurrentRow.Cells[7].Value.ToString();
                ec.lblSubtotal.Text = gvCart.CurrentRow.Cells[8].Value.ToString();
                ec.ShowDialog();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            gvCart.DataSource = new DAO().Get_Cart(OrderNo);
            lblTotal.Text = new DAO().getTotal(OrderNo).ToString();
        }

        private void mtRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    decimal totalQty = new DAO().getQty(int.Parse(gvCart.CurrentRow.Cells[4].Value.ToString()));
                    decimal qty = decimal.Parse(gvCart.CurrentRow.Cells[6].Value.ToString());

                    decimal newQty = totalQty + qty;

                    new DAO().RemoveQty(newQty, int.Parse(gvCart.CurrentRow.Cells[4].Value.ToString()));
                    new DAO().RemoveOrder(int.Parse(gvCart.CurrentRow.Cells[0].Value.ToString()));
                    lblTotal.Text = new DAO().getTotal(OrderNo).ToString();
                }            
            }
            catch (Exception ex)
            {

            }
            gvCart.DataSource = new DAO().Get_Cart(OrderNo);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {         
               
                this.Dispose();
            AddOrder addorder = new AddOrder(OrderNo);
            addorder.Show();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {

        }

        private void gvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
