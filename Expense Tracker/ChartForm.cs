using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Expense_Tracker
{
    public partial class ChartForm : Form
    {
        private DataGridView dataGridView;

        public ChartForm(User user)
        {
            InitializeComponent();

            // Initialize the panel to hold the charts and DataGridView
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(panel);


            // Initialize the PieChart
            var pieChart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Top,
                Height = 300,
                BackColor = System.Drawing.Color.White
            };
            panel.Controls.Add(pieChart);

            var pieSeriesCollection = new SeriesCollection();
            var categoryAmounts = new Dictionary<string, double>();

            foreach (var expense in user.Expenses)
            {
                if (categoryAmounts.ContainsKey(expense.Category))
                {
                    categoryAmounts[expense.Category] += (double)expense.Amount;
                }
                else
                {
                    categoryAmounts[expense.Category] = (double)expense.Amount;
                }
            }

            foreach (var kvp in categoryAmounts)
            {
                pieSeriesCollection.Add(new PieSeries
                {
                    Title = kvp.Key,
                    Values = new ChartValues<double> { kvp.Value },
                    DataLabels = true
                });
            }

            pieChart.Series = pieSeriesCollection;

            // Initialize the LineChart for monthly expenses
            var cartesianChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Top,
                Height = 300,
                BackColor = System.Drawing.Color.White
            };
            panel.Controls.Add(cartesianChart);

            var lineSeries = new LineSeries
            {
                Title = "Monthly Expenses",
                Values = new ChartValues<double>(),
                PointGeometry = null
            };

            var monthlyExpenses = new double[12];
            foreach (var expense in user.Expenses)
            {
                monthlyExpenses[expense.Date.Month - 1] += (double)expense.Amount;
            }

            foreach (var value in monthlyExpenses)
            {
                lineSeries.Values.Add(value);
            }

            cartesianChart.Series = new SeriesCollection { lineSeries };
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Amount",
                LabelFormatter = value => value.ToString("C")
            });
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            // Any additional setup when the form loads
        }
    }
}
