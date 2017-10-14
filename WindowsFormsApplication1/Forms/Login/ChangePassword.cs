using MetroFramework;
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

namespace WindowsFormsApplication1.Forms
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            cmbLogin.DataSource = new DAO().getusers();
            cmbLogin.DisplayMember = "Username";
            cmbLogin.ValueMember = "Username";
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

            if (cmbLogin.Text == "Admin")
            {
                  if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {

                    if (textBox2.Text == textBox3.Text)

                    {
                        new PasswordDAL().UpdatePWAdmin(textBox3.Text);
                        lblmsg.Text = "Password changed successfully!";
                        Login r = new Login();
                        this.Dispose();
                        r.Show();


                    }
                    else
                        lblmsg.Text = "Passwords do not match! Error";
                    //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = '" + cmbLogin.Text + "'and Password ='" + textBox2.Text + "'", conn);

                   }
                   else
                    lblmsg.Text = "Please fill the textboxes! Error";

                }
                if (cmbLogin.Text == "Worker")
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {

                        if (textBox2.Text == textBox3.Text)
                        {

                            new PasswordDAL().UpdatePWWorker(textBox3.Text);
                        lblmsg.Text = "Password changed successfully! ";
                            Login fr = new Login();
                            this.Hide();
                            fr.Show();


                        }
                        else
                        lblmsg.Text = "Passwords do not match! Error";

                    }
                    else
                    lblmsg.Text = "Please fill the textboxes! Error";

                }
            }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void metroPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
    }

