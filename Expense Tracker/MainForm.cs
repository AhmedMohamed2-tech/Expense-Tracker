using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf; // Ensure this namespace is used

namespace Expense_Tracker
{
    public enum Expansions
    {
        Food, Transport, Entertainment, Other
    }

    public partial class MainForm : Form
    {
        private User loggedInUser;
        private List<Expense> expenseList;

        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            InitializeCategoryComboBox();
            UpdateExpenseList();
            UpdateDataGridView();
        }

        private void InitializeCategoryComboBox()
        {
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(Expansions)));
            cmbCategory.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var expense = new Expense
            {
                Date = dateTimePicker.Value.Date,
                Category = cmbCategory.SelectedItem.ToString(),
                Amount = decimal.Parse(txtAmount.Text),
                Description = txtDescription.Text
            };
            loggedInUser.Expenses.Add(expense);
            SaveUserChanges();
            UpdateExpenseList();
            UpdateDataGridView();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStart.Value.Date;
            var endDate = dateTimePickerEnd.Value.Date;
            var queryResults = loggedInUser.Expenses.QueryByDateRange(startDate, endDate).ToList();
            dgvExpenses.DataSource = queryResults.Select(exp => new
            {
                Date = exp.Date.ToShortDateString(),
                exp.Category,
                exp.Amount,
                exp.Description
            }).ToList();
        }

        private void UpdateExpenseList()
        {
            expenseList = loggedInUser.Expenses.GetAll().ToList();
        }

        private void UpdateDataGridView()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = expenseList.Select(exp => new
            {
                Date = exp.Date.ToShortDateString(),
                exp.Category,
                exp.Amount,
                exp.Description
            }).ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void BtnPieChart_Click(object sender, EventArgs e)
        {
            LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Fill
            };

            var categoryGroups = expenseList.GroupBy(exp => exp.Category)
                                            .Select(group => new { Category = group.Key, Total = group.Sum(exp => exp.Amount) })
                                            .ToList();

            foreach (var group in categoryGroups)
            {
                pieChart.Series.Add(new PieSeries
                {
                    Title = group.Category,
                    Values = new ChartValues<decimal> { group.Total },
                    DataLabels = true
                });
            }

            Form pieChartForm = new Form
            {
                Text = "Expense Distribution",
                Size = new System.Drawing.Size(800, 600)
            };
            pieChartForm.Controls.Add(pieChart);
            pieChartForm.ShowDialog();
        }

        private void BtnDownloadReport_Click(object sender, EventArgs e)
        {
            var csvLines = new List<string>
            {
                "Date,Category,Amount,Description"
            };

            csvLines.AddRange(expenseList.Select(exp => $"{exp.Date.ToShortDateString()},{exp.Category},{exp.Amount},{exp.Description}"));

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv",
                FileName = "ExpenseReport.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, csvLines);
                MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = dgvExpenses.SelectedRows[0].Index;
            var selectedExpense = expenseList[selectedIndex];

            var editForm = new EditExpenseForm(selectedExpense);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                SaveUserChanges();
                UpdateExpenseList();
                UpdateDataGridView();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = dgvExpenses.SelectedRows[0].Index;
            var selectedExpense = expenseList[selectedIndex];

            loggedInUser.Expenses.Remove(selectedExpense);
            SaveUserChanges();
            UpdateExpenseList();
            UpdateDataGridView();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                loggedInUser = loginForm.LoggedInUser;
                UpdateExpenseList();
                UpdateDataGridView();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void SaveUserChanges()
        {
            var users = UserStorage.LoadUsers();
            var currentUser = users.FirstOrDefault(u => u.Username == loggedInUser.Username);
            if (currentUser != null)
            {
                currentUser.Expenses = loggedInUser.Expenses;
                UserStorage.SaveUsers(users);
            }
        }
    }
}
