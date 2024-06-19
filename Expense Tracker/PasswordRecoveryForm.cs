using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class PasswordRecoveryForm : Form
    {
        private List<User> users;

        public PasswordRecoveryForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void BtnRecoverPassword_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var user = users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                MessageBox.Show($"Your password is: {user.Password}", "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No user found with this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
