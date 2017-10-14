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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbLogin.DataSource = new DAO().getusers();
            cmbLogin.DisplayMember = "Username";
            cmbLogin.ValueMember = "Username";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConn.GetInstance();

            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = '" + cmbLogin.Text + "'and Password ='" + textBox2.Text + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = @UN and Password = @PW", conn);

            sda.SelectCommand.Parameters.AddWithValue("@UN", cmbLogin.Text);
            sda.SelectCommand.Parameters.AddWithValue("@PW", textBox2.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (cmbLogin.Text != "" && textBox2.Text != "")
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //SqlDataAdapter sda1 = new SqlDataAdapter("Select Username from Login where username = '" + cmbLogin.Text + "'and Password ='" + textBox2.Text + "'", conn);
                        SqlDataAdapter sda1 = new SqlDataAdapter("Select Username from Login where Username = @UN and Password = @PW", conn);

                        sda1.SelectCommand.Parameters.AddWithValue("@UN", cmbLogin.Text);
                        sda1.SelectCommand.Parameters.AddWithValue("@PW", textBox2.Text);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        //label4.Text = "Login approved as Admin";
                        if (dt1.Rows[0][0].ToString() == "Admin")
                        {
                            this.Hide();
                            Main FF = new Main();
                            //AdminForm af = new AdminForm();
                            conn.Close();
                            FF.Show();
                        }
                        else if (dt1.Rows[0][0].ToString() == "Worker")
                        {
                            //this.Hide();

                            //orderworker sf = new orderworker();
                            //conn.Close();
                            //sf.Show();
                        }
                    }
                    else if (dt.Rows[0][0].ToString() != "Admin" || dt.Rows[0][0].ToString() != "Worker")
                    {
                        //label5.Show();
                        lblincorrectpass.Text = "Incorrect Password!";
                    }
                }
                else
                    lblincorrectpass.Text = "Please select Username!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SqlConnection conn = DBConn.GetInstance();

                //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = '" + cmbLogin.Text + "'and Password ='" + textBox2.Text + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = @UN and Password = @PW", conn);

                sda.SelectCommand.Parameters.AddWithValue("@UN", cmbLogin.Text);
                sda.SelectCommand.Parameters.AddWithValue("@PW", textBox2.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                try
                {
                    if (cmbLogin.Text != "" && textBox2.Text != "")
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            //SqlDataAdapter sda1 = new SqlDataAdapter("Select Username from Login where username = '" + cmbLogin.Text + "'and Password ='" + textBox2.Text + "'", conn);
                            SqlDataAdapter sda1 = new SqlDataAdapter("Select Username from Login where Username = @UN and Password = @PW", conn);

                            sda1.SelectCommand.Parameters.AddWithValue("@UN", cmbLogin.Text);
                            sda1.SelectCommand.Parameters.AddWithValue("@PW", textBox2.Text);
                            DataTable dt1 = new DataTable();
                            sda1.Fill(dt1);
                            //label4.Text = "Login approved as Admin";
                            if (dt1.Rows[0][0].ToString() == "Admin")
                            {
                                this.Hide();
                                Main FF = new Main();
                                //AdminForm af = new AdminForm();
                                conn.Close();
                                FF.Show();
                            }
                            else if (dt1.Rows[0][0].ToString() == "Worker")
                            {
                                //this.Hide();

                                //orderworker sf = new orderworker();
                                //conn.Close();
                                //sf.Show();
                            }
                        }
                        else if (dt.Rows[0][0].ToString() != "Admin" || dt.Rows[0][0].ToString() != "Worker")
                        {
                            //label5.Show();
                            lblincorrectpass.Text = "Incorrect Password!";
                        }
                    }
                    else
                        lblincorrectpass.Text = "Please select Username!";
                }
                catch (Exception ex)
                {
                    lblmsg.Text = ex.Message;
                }
            }
        }
    }
}
