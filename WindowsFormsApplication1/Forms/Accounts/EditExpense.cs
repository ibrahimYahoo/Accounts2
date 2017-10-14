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

namespace WindowsFormsApplication1.Forms.Accounts
{
    public partial class EditExpense : MetroFramework.Forms.MetroForm
    {
        frmAccounts owner = new frmAccounts();
        public int expid = 0;
        public EditExpense(frmAccounts acc)
        {
            owner = acc;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditExpense_FormClosing);
            InitializeComponent();
            MaximizeBox = false;
            Movable = false;
        }

        private void EditExpense_Load(object sender, EventArgs e)
        {
         
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtECost.Text != "" && dtEDate.Text != "" && cmbType.SelectedIndex != -1)
                {

                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Update Expenses SET TypeId=@type,ExpDescription=@desc,ExpCost=@cost, ExpDate=@date where ExpId = @eid", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@type", cmbType.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@desc", txtEDesc.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@cost", txtECost.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@date", dtEDate.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@eid", expid);


                    dad.Fill(dt);
                    conn.Close();
                    
                    CLEAR_ALL();
                    lblSuccess.Text = "Expense Updated Successfully!!";
                    lblSuccess.Visible = true;

                }
                else
                {
                    lblSuccess.Text = "Please fill the textboxes!";
                    lblSuccess.Visible = true;
                }
            }
            catch (Exception)
            {

                lblSuccess.Text = "Error, Please try Again!";
                lblSuccess.Visible = true;
               

            }
        }

        public void CLEAR_ALL()
        {
            txtECost.Text = "";
            txtEDesc.Text = "";
            dtEDate.Text = DateTime.Today.ToString();
            cmbType.Text = "";
            lblSuccess.Visible = false;
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

        private void EditExpense_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.PerformRefresh();
        }
    }
}
