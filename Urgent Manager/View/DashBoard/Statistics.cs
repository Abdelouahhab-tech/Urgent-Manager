using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
            int i = 0;
            int length = 4;
            for(; i < length; i++)
            {
                Guna2Panel p = card("G" + (i + 1), i + 20,Color.FromArgb(255,234,79,12));
                flowLayoutPanel1.Controls.Add(p);
            }

            chart();
            HourlyChart();
        }

        private Guna2Panel card(string Name,int values,Color bk)
        {
            Guna2Panel p = new Guna2Panel();
            p.Size = new Size(220, 100);
            p.Margin = new Padding(5);
            p.BorderRadius = 8;
            p.FillColor = bk;
            Label title = new Label();
            title.ForeColor = Color.White;
            title.Font = new Font("Arial", 20,FontStyle.Bold);
            title.Text = Name;
            title.BackColor = Color.Transparent;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Location = new Point(60, 5);
            title.Height = 40;
            Label value = new Label();
            value.ForeColor = Color.White;
            value.Width = 220;
            value.Font = new Font("Arial", 11);
            value.Text = "Total Urgents : " + values;
            value.BackColor = Color.Transparent;
            value.TextAlign = ContentAlignment.MiddleCenter;
            value.Location = new Point(0, 60);

            p.Controls.Add(title);
            p.Controls.Add(value);

            return p;
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void chart()
        {
            SeriesCollection series = new SeriesCollection();
            int g1 = 150,
                g2 = 200,
                g3 = 80,
                g4 = 450;
            series.Add(new PieSeries() { Title = "G1", Values = new ChartValues<int> { g1 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "G2", Values = new ChartValues<int> { g2 }, DataLabels = true, LabelPoint = labelPoint });
            series.Add(new PieSeries() { Title = "G3", Values = new ChartValues<int> { g3 }, DataLabels = true, LabelPoint = labelPoint});
            series.Add(new PieSeries() { Title = "G4", Values = new ChartValues<int> { g4 }, DataLabels = true, LabelPoint = labelPoint });

            DefaultLegend customLegend = new DefaultLegend();
            customLegend.Foreground = System.Windows.Media.Brushes.White;
            pieChart1.DefaultLegend = customLegend;

            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Top;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void HourlyChart()
        {
            cartesianChart1.AxisX.Add(new Axis()
            {

                Title = "Shift Hours",
                Labels = new string[] { "6h", "7h", "8h", "9h", "10h", "11h", "12h", "13h" }

            });

            cartesianChart1.AxisY.Add(new Axis()
            {

                Title = "Urgents"

            });
            SeriesCollection series2 = new SeriesCollection()
            {

              new LineSeries
                {
                    Title = "Current Urgents",
                    Values = new ChartValues<int>() { 140, 150, 250, 300, 400, 180,400, 180 },
                    Stroke = System.Windows.Media.Brushes.Red
                },
                new LineSeries
                {
                    Title = "Finished Urgents",
                    Values = new ChartValues<int>() { 400, 250, 150, 500, 100, 80,400, 180 },
                    Stroke = System.Windows.Media.Brushes.Green
                },
                     new LineSeries
                {
                    Title = "Total Urgents",
                    Values = new ChartValues<int>() { 340, 400, 400, 800, 500, 180,400, 180 },
                    Stroke = System.Windows.Media.Brushes.Turquoise
                }
            };

            DefaultLegend customLegend = new DefaultLegend();
            customLegend.Foreground = System.Windows.Media.Brushes.White;
            cartesianChart1.DefaultLegend = customLegend;

            cartesianChart1.Series = series2;
            cartesianChart1.LegendLocation = LegendLocation.Top;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "Finished")
            {
                pieChart1.Series.Clear();
                chart();
                flowLayoutPanel1.Controls.Clear();
                int i = 0;
                int length = 4;
                for (; i < length; i++)
                {
                    Guna2Panel p = card("G" + (i + 1), i + 20, Color.Green);
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
            else
            {
                pieChart1.Series.Clear();
                chart();
                flowLayoutPanel1.Controls.Clear();
                int i = 0;
                int length = 4;
                for (; i < length; i++)
                {
                    Guna2Panel p = card("G" + (i + 1), i + 20, Color.FromArgb(255,234,79,12));
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
        }
    }
}
