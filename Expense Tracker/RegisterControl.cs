using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class RegisterControl : UserControl
    {
        public event EventHandler RegistrationSuccessful;
        public event EventHandler BackToLogin;

        public RegisterControl()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.ToLower();
            var password = txtPassword.Text;
            var email = txtEmail.Text.ToLower();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var users = UserStorage.LoadUsers();

            if (users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Any(u => u.Email == email))
            {
                MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new User { Username = username, Password = password, Email = email };
            AddDummyExpenses(newUser);
            users.Add(newUser);
            UserStorage.SaveUsers(users);

            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void AddDummyExpenses(User user)
        {
            user.Expenses.Add(new Expense { Date = DateTime.Now.AddDays (-15), Category = "Food", Amount = 50, Description = "Grocery shopping" });
            user.Expenses.Add(new Expense { Date = DateTime.Now.AddDays(-25), Category = "Travel", Amount = 20, Description = "Bus ticket" });
            user.Expenses.Add(new Expense { Date = DateTime.Now.AddDays(-5), Category = "Utilities", Amount = 100, Description = "Electricity bill" });
            user.Expenses.Add(new Expense { Date = DateTime.Now.AddDays(-35), Category = "Entertainment", Amount = 60, Description = "Movie tickets" });
            user.Expenses.Add(new Expense { Date = DateTime.Now.AddDays(-50).Date, Category = "Other", Amount = 15, Description = "Gift" });
        }

        private void LblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackToLogin?.Invoke(this, EventArgs.Empty);
        }
    }
}
