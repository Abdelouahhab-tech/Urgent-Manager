using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager.View.DashBoard
{
    public partial class User : Form
    {
        public User()
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
    }
}
