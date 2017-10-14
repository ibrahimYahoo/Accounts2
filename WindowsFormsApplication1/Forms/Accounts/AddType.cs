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
    public partial class AddType : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBConn.GetInstance();
        public AddType()
        {
            InitializeComponent();
            this.StyleManager = msmType;
            msmType.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmType.Style = MetroFramework.MetroColorStyle.Teal;
            MaximizeBox = false;
            Movable = false;
        }

        private void AddType_Load(object sender, EventArgs e)
        {
            gvType.DataSource = new DAO().GetTypes();
            gvType.Show();
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            lblSuccess.Text = "";
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text != "")
                {


                    DataTable dt = new DataTable();
                    

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Type(Type) values(@CName)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtType.Text);
                   

                    dad.Fill(dt);
                    conn.Close();
                    lblSuccess.Text = "Type Added Successfully!!";
                    lblSuccess.Visible = true;
                    txtType.Text = "";
                    gvType.DataSource = new DAO().GetTypes();
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

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void gvType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtType.Text = this.gvType.CurrentRow.Cells[1].Value.ToString();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text != "")
                {


                    DataTable dt = new DataTable();


                    SqlDataAdapter dad = new SqlDataAdapter("Update Type SET Type=@CName where TypeId = @tid", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@CName", txtType.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@tid", this.gvType.CurrentRow.Cells[0].Value.ToString());


                    dad.Fill(dt);
                    conn.Close();

                    lblSuccess.Text = "Type Updated Successfully!!";
                    lblSuccess.Visible = true;
                    txtType.Text = "";
                    gvType.DataSource = new DAO().GetTypes();
                }
                else
                {
                    lblSuccess.Text = "Please fill the textboxes!";
                    lblSuccess.Visible = true;
                }
            }
            catch (Exception)
            {
                lblSuccess.Text = "Error, Please try Again!!";
                lblSuccess.Visible = true;
             

            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int typeid = 0;
            try
            {
                typeid = int.Parse(this.gvType.CurrentRow.Cells[0].Value.ToString());
                if (typeid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Type where TypeId=@CID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", typeid);
                        dad.Fill(dt);
                        conn.Close();

                        lblSuccess.Text = "Record Deleted Successfully!";
                        lblSuccess.Visible = true; 
                        gvType.DataSource = new DAO().GetTypes();
                    }
                }
                else if (typeid == 0)
                {
                    lblSuccess.Text = "Please select record to Delete!";
                    lblSuccess.Visible = true;
                   
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
