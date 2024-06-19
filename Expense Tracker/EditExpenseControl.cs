using System;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class EditExpenseControl : UserControl
    {
        public event EventHandler BackToMain;
        public event EventHandler ExpenseUpdated;

        private Expense expense;

        public EditExpenseControl(Expense expense)
        {
            InitializeComponent();
            this.expense = expense;
            LoadExpenseDetails();
        }

        private void LoadExpenseDetails()
        {
            dateTimePicker.Value = expense.Date;
            cmbCategory.SelectedItem = expense.Category;
            txtAmount.Text = expense.Amount.ToString();
            txtDescription.Text = expense.Description;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            expense.Date = dateTimePicker.Value.Date;
            expense.Category = cmbCategory.SelectedItem.ToString();
            expense.Amount = decimal.Parse(txtAmount.Text);
            expense.Description = txtDescription.Text;

            ExpenseUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackToMain?.Invoke(this, EventArgs.Empty);
        }
    }
}
