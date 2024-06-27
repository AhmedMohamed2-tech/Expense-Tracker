using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;

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
        public User CurrentUser { get; private set; }
        public event EventHandler<Expense> EditExpense;
        public event EventHandler ViewChart;
        public event EventHandler Logout;
        public event EventHandler QueryData;

        public MainControl(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            InitializeCategoryComboBox();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = CurrentUser.Expenses.Select(exp => new
            {
                Date = exp.Date.ToShortDateString(),
                exp.Category,
                exp.Amount,
                exp.Description
            }).ToList();
        }
        private void InitializeCategoryComboBox()
        {
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ExpenseCategory)));
            cmbCategory.SelectedIndex = 0;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            // Validate inputs
            if (cmbCategory.SelectedItem == null || string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse amount
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create and add expense
            var expense = new Expense
            {
                Date = dateTimePicker.Value.Date,
                Category = cmbCategory.SelectedItem.ToString(),
                Amount = amount,
                Description = txtDescription.Text
            };
            MessageBox.Show("Added Expense successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CurrentUser.Expenses.Add(expense);
            SaveUserChanges();
            UpdateDataGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = dgvExpenses.SelectedRows[0].Index;
            var selectedExpense = CurrentUser.Expenses[selectedIndex];

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
            var selectedExpense = CurrentUser.Expenses[selectedIndex];
            MessageBox.Show("Deleted Expense successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CurrentUser.Expenses.Remove(selectedExpense);
            SaveUserChanges();
            UpdateDataGridView();
        }

        private void BtnPieChart_Click(object sender, EventArgs e)
        {
            ViewChart?.Invoke(this, e);
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData?.Invoke(this, e);
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
                    csv.WriteRecords(CurrentUser.Expenses);
                }
                MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, e);
        }

        private void SaveUserChanges()
        {
            var users = UserStorage.LoadUsers();
            var currentUserInList = users.FirstOrDefault(u => u.Username == CurrentUser.Username);
            if (currentUserInList != null)
            {
                currentUserInList.Expenses = CurrentUser.Expenses;
                UserStorage.SaveUsers(users);
            }
        }
    }
}
