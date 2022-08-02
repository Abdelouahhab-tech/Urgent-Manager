using DGVPrinterHelper;
using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class UrgentManager : Form
    {

        UrgentController urgentController = new UrgentController();
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
            urgentController.FillCombobox("Machine", "Machine", cmbMac);
            urgentController.UrgentManagerExpress(guna2DataGridView1);
            guna2DataGridView1.Columns[0].Width = 100;
            guna2DataGridView1.ScrollBars = ScrollBars.Both;
            gtxtSearch.Focus();
            if(Login.role != "")
            {
                if (Login.role != "Administrator")
                {
                    icExport.Location = new Point(585,23);
                    icPrint.Location = new Point(534, 23);
                    btnRefresh.Location = new Point(483, 23);
                    btnUrgentDelete.Visible = false;
                }
            }
        }

        private void icPrint_Click(object sender, EventArgs e)
        {
            ArrayList machines = urgentController.machines();
            int i = 0;
            foreach(string machine in machines)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Express Wires";
                printer.SubTitle = machine;
                printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Printed By " + Login.FullName + " | " + DateTime.Now.ToShortDateString();
                printer.FooterColor = Color.LightGray;
                printer.SubTitleSpacing = 15;
                printer.FooterSpacing = 15;
                printer.SubTitleColor = Color.Gray;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.showDialogue = i == 0 ? true : false;
                urgentController.UrgentManagerExpress(guna2DataGridView1, machine);
                printer.PrintDataGridView(guna2DataGridView1);
                i++;
            }
            urgentController.UrgentManagerExpress(guna2DataGridView1);
            guna2DataGridView1.Columns[0].Width = 100;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            urgentController.UrgentManagerExpress(guna2DataGridView1);
            guna2DataGridView1.Columns[0].Width = 100;
        }
    }
}
