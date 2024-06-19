using System;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class PasswordRecoveryControl : UserControl
    {
        public event EventHandler BackToLogin;

        public PasswordRecoveryControl()
        {
            InitializeComponent();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.ToLower();
            var users = UserStorage.LoadUsers();
            var user = users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                //SendRecoveryEmail(user);
                MessageBox.Show($"Your password is: {user.Password}" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SendRecoveryEmail(User user)
        //{
        //    string to = user.Email;
        //    string from = "your-email@example.com";
        //    string subject = "Password Recovery";
        //    string body = $"Your password is: {user.Password}";

        //    using (var mail = new System.Net.Mail.MailMessage(from, to, subject, body))
        //    using (var client = new System.Net.Mail.SmtpClient("smtp.example.com"))
        //    {
        //        client.Credentials = new System.Net.NetworkCredential("your-email@example.com", "your-email-password");
        //        client.EnableSsl = true;
        //        client.Send(mail);
        //    }
        //}

        private void LblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackToLogin?.Invoke(this, EventArgs.Empty);
        }
    }
}
