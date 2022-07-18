using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.View.OptimaisationWindows;

namespace Urgent_Manager.View
{
    public partial class Optimisation : Form
    {
        public Optimisation()
        {
            InitializeComponent();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            subForm(new UrgentManager());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Optimisation_Load(object sender, EventArgs e)
        {

        }

        private void icBarrs_Click(object sender, EventArgs e)
        {
            if(sideBar.Width == 204)
            {
                btnLogout.TextAlign = HorizontalAlignment.Right;
                btnLogout.ImageAlign = HorizontalAlignment.Left;
                btnLogout.ImageOffset = new Point(0, 0);
                sideBar.Width = 42;
            }
            else
            {
                btnLogout.TextAlign = HorizontalAlignment.Left;
                btnLogout.ImageAlign = HorizontalAlignment.Right;
                btnLogout.ImageOffset = new Point(10, 0);
                sideBar.Width = 204;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void icUrgent_Click(object sender, EventArgs e)
        {
            subForm(new UrgentManager());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            subForm(new ArchiveManager());
        }
    }
}
