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
    public partial class Marker : Form
    {
        public Marker()
        {
            InitializeComponent();
        }

        private void Marker_Load(object sender, EventArgs e)
        {
            gtxtMarkerColor.Focus();
        }
    }
}
