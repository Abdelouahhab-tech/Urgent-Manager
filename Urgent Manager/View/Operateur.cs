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
    public partial class Operateur : Form
    {
        private bool isPlanB = false;
        public Operateur()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void Operateur_Load(object sender, EventArgs e)
        {

            guna2DataGridView1.Rows.Add("2400","2400-My-109","L45659872","GR","1000","#454#","G4");
            guna2DataGridView1.Rows.Add("2400", "2400-My-110", "L456594592", "GR-BR", "2100", "#454#", "G4");
            guna2DataGridView1.Rows.Add("2400", "2400-My-93", "L45653212", "GR-BK", "1500", "#454#", "G4");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2ControlBox2.PerformClick();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                lblUnico.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblLeadCode.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblMachine.Text = "M35";
                lblUrgents.Text = "10";
                lblAdress.Text = "P150 b1-2-3";
                lblBobine.Text = "M4764530";
                lblTerminalR.Text = "33252602";
                lblTerminalL.Text = "13854952";
                lblSealR.Text = "33265985";
                lblSealL.Text = "33265987";
                lblMarkerR.Text = "RD";
                lblMarkerL.Text = "BK";
                lblToolR.Text = "GG4204";
                lblToolL.Text = "GG4232";
            }
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void chIsPlanB_CheckedChanged(object sender, EventArgs e)
        {
            if (chIsPlanB.Checked)
            {
                cmbMachines.Visible = true;
                lblMc.Visible = true;
                isPlanB = true;
            }
            else
            {
                cmbMachines.Visible = false;
                lblMc.Visible = false;
                isPlanB = false;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
