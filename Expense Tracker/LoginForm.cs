using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class LoginForm : Form
    {
        private List<User> users;

        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            users = UserStorage.LoadUsers();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                LoggedInUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var email = txtEmail.Text; // Get email input

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
        }

        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {
            PasswordRecoveryForm recoveryForm = new PasswordRecoveryForm(users); // Pass users list to the recovery form
            recoveryForm.ShowDialog();
        }

        private void AddDummyExpenses(User user)
        {
            // Add some dummy expenses to the new user account for demonstration purposes
            user.Expenses.Add(new Expense { Date = DateTime.Now, Category = "Food", Amount = 50, Description = "Grocery shopping" });
            user.Expenses.Add(new Expense { Date = DateTime.Now, Category = "Travel", Amount = 20, Description = "Bus ticket" });
            user.Expenses.Add(new Expense { Date = DateTime.Now, Category = "Utilities", Amount = 100, Description = "Electricity bill" });
            user.Expenses.Add(new Expense { Date = DateTime.Now, Category = "Entertainment", Amount = 60, Description = "Movie tickets" });
        }
    }
}
