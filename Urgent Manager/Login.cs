using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.Model;

namespace Urgent_Manager
{
    public partial class Login : Form
    {
        private bool isUpdate = false;
        private bool update = false;
        public Login()
        {
            InitializeComponent();
        }

        private void icEyes_Click(object sender, EventArgs e)
        {
            if (gtxtPass.UseSystemPasswordChar)
            {
                gtxtPass.UseSystemPasswordChar = false;
                gtxtPass.PasswordChar = '\0';
                icEyes.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                gtxtPass.UseSystemPasswordChar = true;
                icEyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void icUpdatedPass_Click(object sender, EventArgs e)
        {
            if (gtxtUpdatedPass.UseSystemPasswordChar)
            {
                gtxtUpdatedPass.UseSystemPasswordChar = false;
                gtxtUpdatedPass.PasswordChar = '\0';
                icUpdatedPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                gtxtUpdatedPass.UseSystemPasswordChar = true;
                icUpdatedPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Get The Bool Value From Database (isUpdated)
            // assigne that value to the isUpdated Variable

            btnLogin.Location = new Point(28,270);
            this.Size = new Size(755, 500);
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRoles.Text.Trim() != "Operateur")
            {
                update = false;
                if (!isUpdate)
                {
                    gtxtUpdatedPass.Visible = false;
                    icUpdatedPass.Visible = false;
                    gtxtUserName.Visible = true;
                    gtxtUserName.Focus();
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28,400);
                    this.Size = new Size(755, 600);
                    btnLogin.Image = Properties.Resources.user__1_;
                    btnLogin.Text = "Log In";
                }
                else
                {
                    gtxtUserName.Visible = true;
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28, 400);
                    this.Size = new Size(755, 600);
                    btnLogin.Image = Properties.Resources.user__1_;
                    btnLogin.Text = "Log In";
                }
            }
            else
            {
                gtxtUserName.Visible = false;
                gtxtPass.Visible = false;
                icEyes.Visible = false;
                btnLogin.Visible = true;
                btnLogin.Location = new Point(28, 270);
                this.Size = new Size(755, 500);
                btnLogin.Image = Properties.Resources.user__1_;
                btnLogin.Text = "Log In";
                gtxtUserName.Visible = false;
                gtxtUpdatedPass.Visible = false;
                icUpdatedPass.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If The Users Role Is Different To Operateur

            if(cmbRoles.Text.Trim() != "Operateur")
            {
                if (!update)
                {
                    // Check if The Required Fields Are Filled
                    if (gtxtUserName.Text.Trim() != "" && gtxtPass.Text.Trim() != "")
                    {
                        // Check The Users Credentials
                        bool isAuth = true;
                        if (isAuth)
                        {
                            // Check If He Is Logged In For The First Time Or Not
                            bool isUpdated = false;
                            if (isUpdated)
                            {
                                // Connect The Specific User To His Window
                                update = true;
                                MessageBox.Show("Welcome " + cmbRoles.Text);
                            }
                            else
                            {
                                update = true;
                                gtxtUpdatedPass.Visible = true;
                                gtxtUpdatedPass.Focus();
                                icUpdatedPass.Visible = true;
                                gtxtUserName.Visible = true;
                                gtxtPass.Visible = true;
                                icEyes.Visible = true;
                                btnLogin.Visible = true;
                                btnLogin.Location = new Point(28, 464);
                                btnLogin.Image = Properties.Resources.update;
                                btnLogin.Text = "Update";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry You Are Not Authorized To This Session !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            init();
                        }
                    }
                    else
                    {
                        // All The Fields Are Required
                        MessageBox.Show("Username and Password Are Required");
                    }
                }
                else
                {
                    // Check If The Required Fields Are Filled
                    if (gtxtUserName.Text.Trim() != "" && gtxtPass.Text.Trim() != "" && gtxtUpdatedPass.Text != "")
                    {
                        // Check If The User Is Auth Again
                        bool isAuth = true;
                        if (isAuth)
                        {
                            // Check If The New Password Is Different From The Old Password
                            if (gtxtPass.Text.Trim() != gtxtUpdatedPass.Text.Trim())
                            {
                                // Update Users Credentials With The New Ones and Connect The User To His Specific Window
                                MessageBox.Show("Welcome " + cmbRoles.Text);
                                init();
                            }
                            else
                            {
                                // Choose a diffent Password To Your Old One
                                MessageBox.Show("Choose a deffirent Password To Yor Old One");
                                gtxtUpdatedPass.Focus();
                                gtxtUpdatedPass.SelectAll();
                            }
                        }
                    }
                    else
                    {
                        // All The Fields Are Required
                        MessageBox.Show("All The Fields Are Required");
                    }
                }
            }
            else
            {
                // Connect To The Operator Window
                MessageBox.Show("Welcome " + cmbRoles.Text);
            }
        }

        private void init()
        {
            gtxtUserName.Text = "";
            gtxtPass.Text = "";
            gtxtUpdatedPass.Text = "";
            gtxtUserName.Visible = false;
            gtxtPass.Visible = false;
            gtxtUpdatedPass.Visible = false;
            icEyes.Visible = false;
            icUpdatedPass.Visible = false;
            btnLogin.Visible = false;
            cmbRoles.SelectedIndex = -1;
        }

        private void gtxtUpdatedPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
