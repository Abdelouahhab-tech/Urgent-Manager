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

namespace Urgent_Manager.View.DashBoard
{
    public partial class Bobine : Form
    {
        CableController cableController = new CableController();
        public Bobine()
        {
            InitializeComponent();
        }

        private void Bobine_Load(object sender, EventArgs e)
        {
            gtxtCableName.Focus();
            LoadData();
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<CableModel> list = cableController.fetchRecords();
            foreach (CableModel cable in list)
            {
                guna2DataGridView1.Rows.Add(cable.Cable,cable.Section,cable.Pvc,cable.Color,cable.UserID);
            }
        }
    }
}
