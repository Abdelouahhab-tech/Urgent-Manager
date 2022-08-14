using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;

namespace Urgent_Manager.View.OptimaisationWindows
{
    public partial class ArchiveManager : Form
    {
        UrgentController urgentController = new UrgentController();
        public ArchiveManager()
        {
            InitializeComponent();
        }

        private void ArchiveManager_Load(object sender, EventArgs e)
        {
            gdateTimeUrgent.Value = DateTime.Now;
            urgentController.FillCombobox("Machine", "Machine", cmbPlanBMc);
            urgentController.UrgentManagerFinished(guna2DataGridView1);
            urgentController.DeleteUrgent();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
