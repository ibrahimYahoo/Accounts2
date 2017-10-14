using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using WindowsFormsApplication1.Code;
using System.Data.SqlClient;
using WindowsFormsApplication1.Forms;
using System.IO;

namespace WindowsFormsApplication1.Forms
{
    public partial class frmSuppliers : MetroFramework.Forms.MetroForm
    {
        

        public void PerformRefresh()
        {
            gvSuppliers.DataSource = new DAO().GetSupplier();
            gvSuppliers.Show();
        }


        public frmSuppliers()
        {
            InitializeComponent();
         
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            gvSuppliers.DataSource = new DAO().GetSupplier();
            gvSuppliers.Show();
        }
      
        private void metroTile2_Click(object sender, EventArgs e)
        {
            Forms.EditSupp ec = new Forms.EditSupp(this);
            ec.txtSName.Text = this.gvSuppliers.CurrentRow.Cells[1].Value.ToString();
            ec.txtSAddress.Text = this.gvSuppliers.CurrentRow.Cells[2].Value.ToString();
            ec.txtSPhone.Text = this.gvSuppliers.CurrentRow.Cells[3].Value.ToString();
            ec.txtSBalance.Text = this.gvSuppliers.CurrentRow.Cells[4].Value.ToString();
            ec.sid = int.Parse(this.gvSuppliers.CurrentRow.Cells[0].Value.ToString());
            ec.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Forms.AddSupp ac = new Forms.AddSupp(this);
            ac.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvSuppliers.DataSource = new DAO().GetSupplier();
            gvSuppliers.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int sid = 0;
            try
            {
                sid = int.Parse(this.gvSuppliers.CurrentRow.Cells[0].Value.ToString());
                if (sid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Supplier where SId=@CID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", sid);
                        dad.Fill(dt);
                        conn.Close();

                        lblmsg.Text ="Record Deleted Successfully! ";
                        gvSuppliers.DataSource = new DAO().GetSupplier();
                    }
                }
                else if (sid == 0)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void gvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().GetSuppDataset();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Suppliers.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Suppliers"].Rows.Count > 0)
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
