using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Collections.Generic;

namespace Expense_Tracker
{
    public partial class QueryControl : UserControl
    {
        public User CurrentUser { get; private set; }
        public event EventHandler BackToMain;

        public QueryControl(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {

            var startDate = dateTimePickerStart.Value.Date;
            var endDate = dateTimePickerEnd.Value.Date;
            if (startDate > endDate)
            {
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var queryResults = CurrentUser.Expenses

                .Where(exp => exp.Date >= startDate && exp.Date <= endDate)
                .Select(exp => new
                {

                    Date = exp.Date.ToShortDateString(),
                    exp.Category,
                    exp.Amount,
                    exp.Description
                }).ToList();

            dgvQueryResults.DataSource = queryResults;

            UpdatePieChart(queryResults);
        }

        private void BtnDownloadReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "ExpenseReport.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(CurrentUser.Expenses
                        .Where(exp => exp.Date >= dateTimePickerStart.Value.Date && exp.Date <= dateTimePickerEnd.Value.Date));
                }
                MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackToMain?.Invoke(this, e);
        }

        private void UpdatePieChart(dynamic queryResults)
        {
            pieChart.Series = new SeriesCollection();

            var expenseGroups = ((IEnumerable<dynamic>)queryResults)
                .GroupBy(exp => (string)exp.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    Total = group.Sum(exp => (decimal)exp.Amount)
                });

            foreach (var group in expenseGroups)
            {
                pieChart.Series.Add(new PieSeries
                {
                    Title = group.Category,
                    Values = new ChartValues<decimal> { group.Total }
                });
            }
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }
    }
}
