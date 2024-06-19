using System;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class EditExpenseForm : Form
    {
        private Expense expense;

        public EditExpenseForm(Expense expense)
        {
            InitializeComponent();
            this.expense = expense;

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

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditExpenseForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ExpenseCategory)));
            cmbCategory.SelectedItem = expense.Category;
        }
    }
}
