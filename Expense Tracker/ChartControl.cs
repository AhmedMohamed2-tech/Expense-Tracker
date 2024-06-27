using System;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Expense_Tracker
{
    public partial class ChartControl : UserControl
    {
        public User CurrentUser { get; private set; }
        public event EventHandler BackToMain;

        public ChartControl(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            LoadPieChart();
        }

        private void LoadPieChart()
        {
            var expensesByCategory = CurrentUser.Expenses
                .GroupBy(exp => exp.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Amount = g.Sum(exp => exp.Amount)
                }).ToList();

            pieChart.Series = new SeriesCollection();
            foreach (var expense in expensesByCategory)
            {
                pieChart.Series.Add(new PieSeries
                {
                    Title = expense.Category,
                    Values = new ChartValues<decimal> { expense.Amount }, // Ensure Amount is treated as decimal
                    DataLabels = true
                });
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackToMain?.Invoke(this, e);
        }
    }
}