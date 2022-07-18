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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            gtxtAreaName.Focus();
        }
    }
}
