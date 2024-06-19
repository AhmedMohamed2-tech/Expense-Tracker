using System;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;

namespace Expense_Tracker
{
    public partial class ChartControl : UserControl
    {
        public event EventHandler BackToMain;

        private User currentUser;

        public ChartControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeChart();
        }

        private void InitializeChart()
        {
            var pieChart = new PieChart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(pieChart);

            var seriesCollection = new SeriesCollection();

            var groupedExpenses = currentUser.Expenses.GroupBy(e => e.Category)
                                                      .Select(g => new
                                                      {
                                                          Category = g.Key,
                                                          Amount = g.Sum(e => e.Amount)
                                                      });

            foreach (var group in groupedExpenses)
            {
                seriesCollection.Add(new LiveCharts.Wpf.PieSeries
                {
                    Title = group.Category,
                    Values = new ChartValues<decimal> { group.Amount },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"
                });
            }

            pieChart.Series = seriesCollection;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackToMain?.Invoke(this, EventArgs.Empty);
        }
    }
}
