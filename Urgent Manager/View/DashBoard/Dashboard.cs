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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icUrgent_Click(object sender, EventArgs e)
        {
            if (panelControls.Visible)
            {
                panelControls.Visible = false;
                btnCredentials.Location = new Point(0, 57);
                btnStatistics.Location = new Point(0, 95);
            }
            else
            {
                panelControls.Visible = true;
                btnCredentials.Location = new Point(0, 378);
                btnStatistics.Location = new Point(0, 416);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            btnCredentials.Location = new Point(0, 57);
            btnStatistics.Location = new Point(0, 95);
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            subForm(new Machine());
        }

        // Creating Method To Fiil The Main Panel With SubForms

        Form active = null;
        private void subForm(Form ChildForm)
        {
            if (active != null)
                active.Close();
            active = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            subForm(new Area());
        }

        private void btnFamille_Click(object sender, EventArgs e)
        {
            subForm(new Family());
        }

        private void btnBobine_Click(object sender, EventArgs e)
        {
            subForm(new Bobine());
        }

        private void btnOutil_Click(object sender, EventArgs e)
        {
            subForm(new Tool());
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            subForm(new Terminal());
        }

        private void btnSeal_Click(object sender, EventArgs e)
        {
            subForm(new Seal());
        }

        private void btnProtection_Click(object sender, EventArgs e)
        {
            subForm(new Protection());
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            subForm(new Group());
        }

        private void btnMarker_Click(object sender, EventArgs e)
        {
            subForm(new Marker());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            subForm(new Wire());
        }

        private void btnKit_Click(object sender, EventArgs e)
        {
            subForm(new Kit());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            subForm(new WireData());
        }

        private void NavBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            subForm(new User());
        }
    }
}
