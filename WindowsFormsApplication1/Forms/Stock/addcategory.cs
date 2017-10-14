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
    public partial class addcategory : MetroFramework.Forms.MetroForm
    {
        public addcategory()
        {
            InitializeComponent();
        }

        private void addcategory_Load(object sender, EventArgs e)
        {
            gvcategory.DataSource = new DAO().GetCategory();
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatname.Text != "")
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Category(CatDesc) values(@CatDesc)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CatDesc", txtcatname.Text);

                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text = "Category Added Successfully!! Success";

                }
                else
                {
                    lblmsg.Text = "Please fill Category Name Textbox! ERROR!";
                }
            }

            catch (Exception)
            {
                lblmsg.Text = "Error, Please try Again! Stopped!";
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatname.Text != "")
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Update Category SET CatDesc=@CD where CatId=@CID", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CD", txtcatname.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@CID", this.gvcategory.CurrentRow.Cells[0].Value.ToString());

                    dad.Fill(dt);
                    conn.Close();
                   lblmsg.Text = "Category Updated Successfully!!";
                    
                }
                else
                    lblmsg.Text = "Please fill the textboxes! Error";
            }
            catch (Exception ex)
            {
                lblmsg.Text =ex.Message;
            }
        }

        private void gvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatname.Text != "" && MessageBox.Show("Do you want to delete this row ", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Delete From Category where CatDesc=@CD", conn);

                    dad.SelectCommand.Parameters.AddWithValue("@CD",txtcatname.Text );
                    dad.Fill(dt);
                    conn.Close();
                    lblmsg.Text="Category Deleted Successfully!!";
                    
                }
                else
                    lblmsg.Text = "Please fill the textboxes! Error";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvcategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcatname.Text = gvcategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                mtCreate.Enabled = false;
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;

            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }
    }
}
