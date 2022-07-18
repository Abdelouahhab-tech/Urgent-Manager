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
    public partial class Bobine : Form
    {
        public Bobine()
        {
            InitializeComponent();
        }

        private void Bobine_Load(object sender, EventArgs e)
        {
            gtxtCableName.Focus();
        }
    }
}
