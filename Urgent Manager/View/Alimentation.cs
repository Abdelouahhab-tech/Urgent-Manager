using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager.View
{
    public partial class Alimentation : Form
    {
        private bool isMaximized = false;
        public Alimentation()
        {
            InitializeComponent();
        }

        private void Alimentation_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2ControlBox2.PerformClick();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gtxtScanne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnScanneUrgent.PerformClick();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
