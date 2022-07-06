using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Model;

namespace Urgent_Manager
{
    public partial class Login : Form
    {
        private bool isUpdate = false;
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
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRoles.Text.Trim() != "Operateur")
            {
                if (!isUpdate)
                {
                    gtxtUserName.Visible = true;
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28,464);
                    btnLogin.Image = Properties.Resources.update;
                    btnLogin.Text = "Modifier";
                }
                else
                {
                    gtxtUserName.Visible = true;
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28, 400);
                    btnLogin.Image = Properties.Resources.user__1_;
                    btnLogin.Text = "Connexion";
                }
            }
            else
            {
                gtxtUserName.Visible = false;
                gtxtPass.Visible = false;
                icEyes.Visible = false;
                btnLogin.Visible = true;
                btnLogin.Location = new Point(28, 270);
                btnLogin.Image = Properties.Resources.user__1_;
                btnLogin.Text = "Connexion";
                gtxtUserName.Visible = false;
                gtxtUpdatedPass.Visible = false;
                icUpdatedPass.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                // Connect The User To His Interface
            }
            else
            {
                // Update The User's credentials
            }
        }
    }
}
