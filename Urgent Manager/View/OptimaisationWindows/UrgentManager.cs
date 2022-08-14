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
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach(DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                    column.Width = 150;
                else
                    column.Width = 100;
            }
            guna2DataGridView1.ScrollBars = ScrollBars.Both;
            gtxtSearch.Focus();
            if(Login.role != "")
            {
                if (Login.role != "Administrator")
                {
                    icExport.Location = new Point(585,23);
                    icPrint.Location = new Point(534, 23);
                    btnRefresh.Location = new Point(483, 23);
                    lblLoading.Location = new Point(385, 33);
                    btnUrgentDelete.Visible = false;
                }
            }
        }

        private void icPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMac.Text.Trim() != "")
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "Express Wires";
                    printer.SubTitle = cmbMac.Text;
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
                    printer.showDialogue = true;
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    urgentController.UrgentManagerExpress(guna2DataGridView1, cmbMac.Text,false);
                    printer.PrintDataGridView(guna2DataGridView1);
                    urgentController.UrgentManagerExpress(guna2DataGridView1);
                    cmbMac.SelectedIndex = -1;
                    urgentController.UrgentManagerExpress(guna2DataGridView1);
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                    {
                        if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                            column.Width = 150;
                        else
                            column.Width = 100;
                    }
                }
                else
                {
                    ArrayList machines = urgentController.machines();
                    int i = 0;
                    foreach (string machine in machines)
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
                        guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        urgentController.UrgentManagerExpress(guna2DataGridView1, machine,false);
                        printer.PrintDataGridView(guna2DataGridView1);
                        i++;
                    }
                    urgentController.UrgentManagerExpress(guna2DataGridView1);
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                    {
                        if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                            column.Width = 150;
                        else
                            column.Width = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbMac.SelectedIndex = -1;
            urgentController.UrgentManagerExpress(guna2DataGridView1);
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                    column.Width = 150;
                else
                    column.Width = 100;
            }
        }

        private void cmbMac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, cmbMac.Text, true);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                {
                    if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                        column.Width = 150;
                    else
                        column.Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gtxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(gtxtSearch.Text.Trim() != "")
                {

                    urgentController.singleUrgentExpress(guna2DataGridView1, gtxtSearch.Text, true);
                   
                }
                else
                {
                    urgentController.UrgentManagerExpress(guna2DataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void icExport_Click(object sender, EventArgs e)
        {
            try
            {
                lblLoading.Visible = true;
                await Task.Run(new Action(generateExcel));
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Generate Excel File

        private void generateExcel()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    guna2DataGridView1.SelectAll();
                    DataObject copyData = guna2DataGridView1.GetClipboardContent();
                    if (copyData != null) Clipboard.SetDataObject(copyData);
                    Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlapp.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWSheet;
                    Object misedData = System.Reflection.Missing.Value;
                    xlWBook = xlapp.Workbooks.Add(misedData);
                    xlWSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWBook.Worksheets[1];
                    Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWSheet.Cells[1, 1];
                    xlr.Select();
                    xlWSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                    init();
                    lblLoading.Visible = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize Datagridview selection mode

        private void init()
        {
            foreach(DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Selected = false;
            }
            guna2DataGridView1.Rows[0].Selected = true;
        }
    }
}
