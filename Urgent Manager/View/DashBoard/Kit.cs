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
    public partial class Kit : Form
    {
        public Kit()
        {
            InitializeComponent();
        }

        private void Kit_Load(object sender, EventArgs e)
        {
            gtxtKitRef.Focus();
        }
    }
}
