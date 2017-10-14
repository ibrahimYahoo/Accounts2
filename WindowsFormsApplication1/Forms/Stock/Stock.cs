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
using MetroFramework;
using System.IO;

namespace WindowsFormsApplication1.Forms
{
    public partial class Stock : MetroFramework.Forms.MetroForm
    {
        public Stock()
        {
            InitializeComponent();
        }

        public void PerformRefresh()
        {
            gvStock.DataSource = new DAO().getItems();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            gvStock.DataSource = new DAO().getItems();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Forms.Items ac = new Forms.Items(this);
            ac.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Forms.EditItem ec = new Forms.EditItem(this);
            ec.txtItemName.Text = this.gvStock.CurrentRow.Cells[1].Value.ToString();
            ec.cmbcatname.DataSource = new DAO().ShowCatList1();
            ec.cmbcatname.DisplayMember = "Display";
            ec.cmbcatname.ValueMember = "CatId";
            ec.cmbcatname.Text = new DAO().GetCatDescfromCatId(int.Parse(gvStock.CurrentRow.Cells[2].Value.ToString()));
            ec.txtReOrder.Text = gvStock.CurrentRow.Cells[5].Value.ToString();
            ec.TxtitemPrice.Text = this.gvStock.CurrentRow.Cells[3].Value.ToString();
            ec.txtItemQuantity.Text = this.gvStock.CurrentRow.Cells[4].Value.ToString();
            ec.Show();
        }
        void performRefresh()
        {
            gvStock.DataSource = new DAO().getItems();
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            int IId = 0;
            try
            {
                IId = int.Parse(this.gvStock.CurrentRow.Cells[0].Value.ToString());
                if (IId != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Items where IId=@IID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@IID", IId);
                        dad.Fill(dt);
                        conn.Close();

                      lblmsg.Text = "Record Deleted Successfully! ";
                        gvStock.DataSource = new DAO().getItems();
                    }
                }
                else if (IId == 0)
                {
                    lblmsg.Text = "Please select record to Delete! Error";
                }
                else
                { }

            }
            catch (Exception)
            {


            }


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvStock.DataSource = new DAO().getItems();
        }

        private void gvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().GetStock();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Catalog.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Stock"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        //    sw.WriteLine("Hello World!");
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
