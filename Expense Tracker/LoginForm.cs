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

            if (users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new User { Username = username, Password = password };
            AddDummyExpenses(newUser);
            users.Add(newUser);
            UserStorage.SaveUsers(users);

            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddDummyExpenses(User user)
        {
            var dummyRecords = new List<Expense>
            {
                new Expense { Date = DateTime.Now.AddDays(-15).Date, Category = "Food", Amount = 50, Description = "Groceries" },
                new Expense { Date = DateTime.Now.AddDays(-12).Date, Category = "Transport", Amount = 20, Description = "Gas" },
                new Expense { Date = DateTime.Now.Date, Category = "Entertainment", Amount = 100, Description = "Concert Tickets" },
                new Expense { Date = DateTime.Now.AddDays(-10).Date, Category = "Food", Amount = 30, Description = "Restaurant" },
                new Expense { Date = DateTime.Now.AddDays(-50).Date, Category = "Other", Amount = 15, Description = "Gift" }
            };

            foreach (var record in dummyRecords)
            {
                user.Expenses.Add(record);
            }
        }
    }
}
