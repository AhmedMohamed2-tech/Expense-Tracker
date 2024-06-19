﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class LoginControl : UserControl
    {
        private List<User> users;

        public event EventHandler<User> LoginSuccessful;

        public LoginControl()
        {
            InitializeComponent();
            users = UserStorage.LoadUsers();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.ToLower();
            var password = txtPassword.Text;

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                LoginSuccessful?.Invoke(this, user);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = FindForm() as MainForm;
            mainForm?.LoadRegisterControl();
        }

        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = FindForm() as MainForm;
            mainForm?.LoadPasswordRecoveryControl();
        }
    }
}
