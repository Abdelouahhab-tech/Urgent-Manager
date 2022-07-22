using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager.View.OptimaisationWindows
{
    public partial class UrgentManager : Form
    {
        public UrgentManager()
        {
            InitializeComponent();
        }

        private void gtxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void btnUrgentDelete_Click(object sender, EventArgs e)
        {
            ArchivedUrgents archive = new ArchivedUrgents();
            archive.ShowDialog();
        }

        private void UrgentManager_Load(object sender, EventArgs e)
        {
            gtxtSearch.Focus();
            if(Login.role != "")
            {
                if (Login.role != "Administrator")
                {
                    icExport.Location = new Point(471, 23);
                    icPrint.Location = new Point(420, 23);
                    btnUrgentDelete.Visible = false;
                }
            }
        }
    }
}
