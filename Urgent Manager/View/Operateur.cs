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
using Urgent_Manager.Model;
using ZXing;

namespace Urgent_Manager.View
{
    public partial class Operateur : Form
    {
        UrgentController urgentController = new UrgentController();
        WireController wireController = new WireController();
        WPCSController wpcsController = new WPCSController(@"C:\Users\21267\Desktop\Database\Job.sdc.arc");
        public Operateur()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void Operateur_Load(object sender, EventArgs e)
        {

            Wpcs.Start();
            fetchData(Environment.MachineName);
            if(guna2DataGridView1.Rows.Count > 0)
            {
                string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                if (unico != "")
                {
                    fetchExpressSingleRecord(Environment.MachineName, unico);
                }
            }
            else
            {
                panelWire.Visible = false;
            }


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
                if (!chNormalWire.Checked)
                {
                  fetchExpressSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                  fetchNormalSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBobine_MouseEnter(object sender, EventArgs e)
        {
            lblBobine.ForeColor = System.Drawing.Color.FromArgb(255, 234, 79, 12);
        }

        private void lblBobine_MouseLeave(object sender, EventArgs e)
        {
            lblBobine.ForeColor = System.Drawing.Color.White;
        }


        // Fetch All The Express Data From Urgent Table

        public void fetchData(string machine)
        {
            try
            {
                List<UrgentModel> list = urgentController.fetchAllExpressRecords(machine);
                guna2DataGridView1.Rows.Clear();

                foreach(UrgentModel urgent in list)
                {
                    guna2DataGridView1.Rows.Add(urgent.Family, urgent.UrgentUnico, urgent.LeadCode, urgent.Color, urgent.Length, urgent.Group, urgent.LeadPrep);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetch Wire Records

        public void fetchExpressSingleRecord(string machine,string unico)
        {
            try
            {
                UrgentModel urgent = new UrgentModel();
                urgent = urgentController.fetchSingleExpressRecord(machine, unico);

                // Header Data
                lblUnico.Text = urgent.UrgentUnico;
                lblLeadCode.Text = urgent.LeadCode;
                lblMachine.Text = Environment.MachineName;
                lblAdress.Text = urgent.Adress;
                lblUrgents.Text = urgentController.actualUrgents(Environment.MachineName).ToString();


                // Cable
                lblBobine.Text = urgent.Cable;
                // Marker Left
                lblMarkerL.Text = urgent.MarL;
                lblMarkerL.Visible = urgent.MarL != "" ? true : false;
                // Marker Right
                lblMarkerR.Text = urgent.MarR;
                lblMarkerR.Visible = urgent.MarR != "" ? true : false;
                // Seal Left
                lblSealL.Text = urgent.SealL;
                lblSealL.Visible = urgent.SealL != "" ? true : false;
                lblSealLHeader.Visible = urgent.SealL != "" ? true : false;
                picTerminalSealL.Visible = urgent.SealL != "" && urgent.TerL != "" ? true : false;
                // Seal Right
                lblSealR.Text = urgent.SealR;
                lblSealR.Visible = urgent.SealR != "" ? true : false;
                lblSealRHeader.Visible = urgent.SealR != "" ? true : false;
                picTerminalSealR.Visible = urgent.SealR != "" && urgent.TerR != "" ? true : false;
                // Terminal Left
                lblTerminalL.Text = urgent.TerL;
                lblTerminalL.Visible = urgent.TerL != "" ? true : false;
                lblTerLHeader.Visible = urgent.TerL != "" && urgent.ToolL != "" ? true : false;
                picTerminalL.Visible = urgent.TerL != "" && urgent.SealL == "" && urgent.ToolL != "" ? true : false;
                // Terminal Right
                lblTerminalR.Text = urgent.TerR;
                lblTerminalR.Visible = urgent.TerR != "" ? true : false;
                lblTerRHeader.Visible = urgent.TerR != "" && urgent.ToolR != "" ? true : false;
                picTerminalR.Visible = urgent.TerR != "" && urgent.SealR == "" && urgent.ToolR != "" ? true : false;
                // Tool Left
                lblToolL.Text = urgent.ToolL;
                lblToolL.Visible = urgent.ToolL != "" ? true : false;
                lblToolLHeader.Visible = urgent.ToolL != "" ? true : false;
                // Tool Right
                lblToolR.Text = urgent.ToolR;
                lblToolR.Visible = urgent.ToolR != "" ? true : false;
                lblToolRHeader.Visible = urgent.ToolR != "" ? true : false;

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void chNormalWire_CheckedChanged(object sender, EventArgs e)
        {
            if (chNormalWire.Checked)
            {
                gtxtUnico.Visible = true;
                gtxtUnico.Focus();
                panelBorderBottom.Visible = true;
                panelWire.Visible = true;
                // Fill DataGridView With Normal Wires

                fetchNormalRecords(Environment.MachineName);
                fetchNormalSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
            }
            else
            {
                gtxtUnico.Visible = false;
                panelBorderBottom.Visible = false;


                // Fill DataGridView With Express Wires
                fetchData(Environment.MachineName);
                if(guna2DataGridView1.Rows.Count > 0)
                {
                    fetchExpressSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                    panelWire.Visible = true;
                }
                else
                {
                    panelWire.Visible = false;
                    lblUnico.Text = "Loading...";
                    lblLeadCode.Text = "Loading...";
                    lblAdress.Text = "Loading...";
                }
            }
        }

        // Fetch Normal Records

        private void fetchNormalRecords(string machine)
        {
            try
            {
                List<WireModel> list = wireController.fetchNormalRecords(machine);
                guna2DataGridView1.Rows.Clear();
                foreach(WireModel wire in list)
                {
                    guna2DataGridView1.Rows.Add(wire.Family,wire.Unico,wire.LeadCode,wire.Color,wire.Length,wire.GroupRef,wire.LeadPrep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Handling Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetch a Single Normal Data Record From Wire Table

        public void fetchNormalSingleRecord(string machine, string unico)
        {
            try
            {
                WireModel wire = new WireModel();
                wire = wireController.fetchNormalSingleRecord(machine, unico);

                // Header Data
                lblUnico.Text = wire.Unico;
                lblLeadCode.Text = wire.LeadCode;
                lblMachine.Text = Environment.MachineName;
                lblAdress.Text = wire.Adress;
                lblUrgents.Text = urgentController.actualUrgents(Environment.MachineName).ToString();


                // Cable
                lblBobine.Text = wire.Cable;
                // Marker Left
                lblMarkerL.Text = wire.MarkL;
                lblMarkerL.Visible = wire.MarkL != "" ? true : false;
                // Marker Right
                lblMarkerR.Text = wire.MarkR;
                lblMarkerR.Visible = wire.MarkR != "" ? true : false;
                // Seal Left
                lblSealL.Text = wire.SealL;
                lblSealL.Visible = wire.SealL != "" ? true : false;
                lblSealLHeader.Visible = wire.SealL != "" ? true : false;
                picTerminalSealL.Visible = wire.SealL != "" && wire.TerL != "" ? true : false;
                // Seal Right
                lblSealR.Text = wire.SealR;
                lblSealR.Visible = wire.SealR != "" ? true : false;
                lblSealRHeader.Visible = wire.SealR != "" ? true : false;
                picTerminalSealR.Visible = wire.SealR != "" && wire.TerR != "" ? true : false;
                // Terminal Left
                lblTerminalL.Text = wire.TerL;
                lblTerminalL.Visible = wire.TerL != "" ? true : false;
                lblTerLHeader.Visible = wire.TerL != "" && wire.ToolL != "" ? true : false;
                picTerminalL.Visible = wire.TerL != "" && wire.SealL == "" && wire.ToolL != "" ? true : false;
                // Terminal Right
                lblTerminalR.Text = wire.TerR;
                lblTerminalR.Visible = wire.TerR != "" ? true : false;
                lblTerRHeader.Visible = wire.TerR != "" && wire.ToolR != "" ? true : false;
                picTerminalR.Visible = wire.TerR != "" && wire.SealR == "" && wire.ToolR != "" ? true : false;
                // Tool Left
                lblToolL.Text = wire.ToolL;
                lblToolL.Visible = wire.ToolL != "" ? true : false;
                lblToolLHeader.Visible = wire.ToolL != "" ? true : false;
                // Tool Right
                lblToolR.Text = wire.ToolR;
                lblToolR.Visible = wire.ToolR != "" ? true : false;
                lblToolRHeader.Visible = wire.ToolR != "" ? true : false;

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 94, 148, 255);
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gtxtUnico_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                if (gtxtUnico.Text.Trim() != "")
                {
                    foreach (DataGridViewRow r in guna2DataGridView1.Rows)
                    {
                        if (r.Cells[1].Value.ToString() == gtxtUnico.Text)
                        {
                            row = r;
                            guna2DataGridView1.Rows.Clear();
                            guna2DataGridView1.Rows.Add(r);
                            fetchNormalSingleRecord(Environment.MachineName, row.Cells[1].Value.ToString());
                            break;
                        }
                    }
                }else if(gtxtUnico.Text == "")
                {
                    fetchNormalRecords(Environment.MachineName);
                    fetchNormalSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblBobine_MouseEnter_1(object sender, EventArgs e)
        {
            lblBobine.ForeColor = System.Drawing.Color.FromArgb(255, 234, 79, 12);
        }

        private void lblBobine_MouseLeave_1(object sender, EventArgs e)
        {
            lblBobine.ForeColor = System.Drawing.Color.White;
        }

        private void lblBobine_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                CableModel cable = wireController.fetchCable(lblBobine.Text);

                Font fHeader = new Font("Arial", 62);
                Font fItems = new Font("Arial", 40);
                e.Graphics.DrawString("Commande Bobine", fHeader, Brushes.Black, new Point(20, 20));
                e.Graphics.DrawLine(new Pen(System.Drawing.Color.Black), new Point(20, fHeader.Height + 30), new Point(e.PageBounds.Width - 10, fHeader.Height + 30));
                e.Graphics.DrawString("Bobine", fItems, Brushes.Black, new Point(100, fHeader.Height + 50));
                e.Graphics.DrawString(lblBobine.Text, fItems, Brushes.Black, new Point(420, fHeader.Height + 50));
                e.Graphics.DrawString("Section", fItems, Brushes.Black, new Point(100, fHeader.Height + 150));
                e.Graphics.DrawString(cable.Section, fItems, Brushes.Black, new Point(420, fHeader.Height + 150));
                e.Graphics.DrawString("Color", fItems, Brushes.Black, new Point(100, fHeader.Height + 250));
                e.Graphics.DrawString(cable.Color, fItems, Brushes.Black, new Point(420, fHeader.Height + 250));
                e.Graphics.DrawString("MC", fItems, Brushes.Black, new Point(100, fHeader.Height + 350));
                e.Graphics.DrawString(Environment.MachineName, fItems, Brushes.Black, new Point(420, fHeader.Height + 350));
                BarcodeWriter br = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                br.Options.Width = e.PageBounds.Width - 20;
                br.Options.PureBarcode = true;
                Image img = br.Write(lblBobine.Text);
                e.Graphics.DrawImage(img, new Point(0, fHeader.Height + 450));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss"), fItems, Brushes.Black, new Point(120, fHeader.Height + 600));
            }
            catch (Exception ex)
            {
            }
        }

        private void Wpcs_Tick(object sender, EventArgs e)
        {
            updateUrgentStatus();
        }

        private void updateUrgentStatus()
        {
            List<UrgentModel> urgents = urgentController.fetchAllExpressRecords(Environment.MachineName);
        
            try
            {
                foreach(UrgentModel urgent in urgents)
                {
                    if (wpcsController.DeleteUrgent(urgent.LeadCode, urgent.UrgentUnico))
                    {
                        MessageBox.Show("updated");
                        if (!chNormalWire.Checked)
                        {
                            fetchData(Environment.MachineName);
                            if(guna2DataGridView1.Rows.Count > 0)
                            {
                                fetchExpressSingleRecord(Environment.MachineName, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                            }
                            else
                            {
                                panelWire.Visible = false;
                                // Initialize All The Data
                            
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
