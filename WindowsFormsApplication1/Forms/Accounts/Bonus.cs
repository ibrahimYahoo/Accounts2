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
    public partial class Bonus : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBConn.GetInstance();
        public Bonus()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Bonus_Load(object sender, EventArgs e)
        {
            cmbEmp.DataSource = new DAO().GetEmpForCMB();
            cmbEmp.DisplayMember = "Display";
            cmbEmp.ValueMember = "EmployeeID";
            cmbEmp.Show();

            gvBonus.DataSource = new DAO().BonusDetails();
            gvBonus.Show();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmp.SelectedIndex != -1 && dtBDate.Text != "" && txtBonusAmount.Text != "")
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Bonus(EmployeeID,BAmount,BDate) values(@id, @desc,@date)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@id", cmbEmp.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@desc", txtBonusAmount.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@date", dtBDate.Text);
           


                    dad.Fill(dt);
                    conn.Close();
                  //  new DAO().UpdateSalFromBonus(int.Parse(cmbEmp.SelectedValue.ToString()), int.Parse(txtBonusAmount.Text));
                   lblSuccess.Text = "Bonus Added Successfully";
                    lblSuccess.Visible = true;
                    CLEAR_ALL();
                    gvBonus.DataSource = new DAO().BonusDetails();
                  


                }
                else
                {
                    MessageBox.Show(this, "Please fill the textboxes!", "ERROR!", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error, Please try Again!", "Stopped!", MessageBoxButtons.OKCancel);
                //MessageBox.Show(ex.Message);
            }
        }

        void CLEAR_ALL()
        {
            txtBonusAmount.Text = "";
            dtBDate.Text = DateTime.Today.ToShortDateString();
           

        }
        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmp.SelectedIndex != -1 && dtBDate.Text != "" && txtBonusAmount.Text != "")
                {


                    DataTable dt = new DataTable();


                    SqlDataAdapter dad = new SqlDataAdapter("Update Bonus SET EmployeeID=@EName, BAmount=@Am, BDate=@Dt where BId = @bid", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@EName", cmbEmp.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@Am", txtBonusAmount.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@Dt", dtBDate.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@bid", this.gvBonus.CurrentRow.Cells[0].Value.ToString());


                    dad.Fill(dt);
                    conn.Close();
                    lblSuccess.Text = "Bonus Edited Successfully";
                    lblSuccess.Visible = true;

                    gvBonus.DataSource = new DAO().BonusDetails();
                    CLEAR_ALL();
                }
                else
                {
                    MessageBox.Show(this, "Please fill the textboxes!", "ERROR!", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error, Please try Again!", "Stopped!", MessageBoxButtons.OKCancel);

            }
        }

        private void gvBonus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void gvBonus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
            mtCreate.Enabled = true;
            lblSuccess.Visible = false;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int bid = 0;
            try
            {
                bid = int.Parse(this.gvBonus.CurrentRow.Cells[0].Value.ToString());
                if (bid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Bonus where BId=@CID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", bid);
                        dad.Fill(dt);
                        conn.Close();

                        lblSuccess.Text = "Bonus Deleted Successfully";
                        lblSuccess.Visible = true;
                        gvBonus.DataSource = new DAO().BonusDetails();
                        CLEAR_ALL();
                    }
                }
                else if (bid == 0)
                {
                    MessageBox.Show("Please select record to Delete!", "Error");
                }
                else
                { }

            }
            catch (Exception)
            {


            }

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void gvBonus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbEmp.DataSource = new DAO().GetEmpForCMB();
            cmbEmp.DisplayMember = "Display";
            cmbEmp.ValueMember = "EmployeeID";
            cmbEmp.Text = this.gvBonus.CurrentRow.Cells[1].Value.ToString();
            txtBonusAmount.Text = this.gvBonus.CurrentRow.Cells[2].Value.ToString();
            dtBDate.Text = this.gvBonus.CurrentRow.Cells[3].Value.ToString();
            mtCreate.Enabled = false;
        }
    }
}
