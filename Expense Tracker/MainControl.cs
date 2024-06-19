using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public enum ExpenseCategory
    {
        Food,
        Travel,
        Utilities,
        Entertainment,
        Other
    }
    public partial class MainControl : UserControl
    {
        public event EventHandler<Expense> EditExpense;
        public event EventHandler ViewChart;
        public event EventHandler Logout;

        private User currentUser;

        public MainControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeCategoryComboBox();
            UpdateDataGridView();
        }

        private void InitializeCategoryComboBox()
        {
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ExpenseCategory)));
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
            currentUser.Expenses.Add(expense);
            SaveUserChanges();
            UpdateDataGridView();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStart.Value.Date;
            var endDate = dateTimePickerEnd.Value.Date;
            var queryResults = currentUser.Expenses.Where(exp => exp.Date >= startDate && exp.Date <= endDate).ToList();
            dgvExpenses.DataSource = queryResults.Select(exp => new
            {
                Date = exp.Date.ToShortDateString(),
                exp.Category,
                exp.Amount,
                exp.Description
            }).OrderBy(exp => exp.Date).ToList();
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
                    csv.WriteRecords(currentUser.Expenses);
                }
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

            int selectedIndex = dgvExpenses.SelectedRows[0].Index;
            var selectedExpense = currentUser.Expenses.OrderBy(exp => exp.Date).ElementAt(selectedIndex);
            EditExpense?.Invoke(this, selectedExpense);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = dgvExpenses.SelectedRows[0].Index;
            var selectedExpense = currentUser.Expenses.OrderBy(exp => exp.Date).ElementAt(selectedIndex);

            currentUser.Expenses.Remove(selectedExpense);
            SaveUserChanges();
            UpdateDataGridView();
        }

        private void BtnPieChart_Click(object sender, EventArgs e)
        {
            ViewChart?.Invoke(this, EventArgs.Empty);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void SaveUserChanges()
        {
            var users = UserStorage.LoadUsers();
            var currentUserInList = users.FirstOrDefault(u => u.Username == currentUser.Username);
            if (currentUserInList != null)
            {
                currentUserInList.Expenses = currentUser.Expenses;
                UserStorage.SaveUsers(users);
            }
        }

        private void UpdateDataGridView()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = currentUser.Expenses.OrderBy(exp => exp.Date).Select(exp => new
            {
                Date = exp.Date.ToShortDateString(),
                exp.Category,
                exp.Amount,
                exp.Description
            }).ToList();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
