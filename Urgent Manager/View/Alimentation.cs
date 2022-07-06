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
        public Alimentation()
        {
            InitializeComponent();
        }

        private void Alimentation_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss");
            timer1.Start();
            guna2DataGridView1.Rows.Add("hello", "hjsxdghjsd");
            guna2DataGridView1.Rows.Add("hello", "hjsxdghjsd");
            guna2DataGridView1.Rows.Add("hello", "hjsxdghjsd");
            guna2DataGridView1.Rows.Add("hello", "hjsxdghjsd");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss");
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2ControlBox2.PerformClick();
        }
    }
}
