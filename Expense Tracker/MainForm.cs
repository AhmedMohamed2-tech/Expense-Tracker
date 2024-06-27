using System;
using System.Drawing;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLoginControl(this, EventArgs.Empty);
        }

        private void LoadLoginControl(object sender, EventArgs e)
        {
            var loginControl = new LoginControl();
            loginControl.Dock = DockStyle.None;
            loginControl.LoginSuccess += LoadMainControl;
            Controls.Clear();
            Controls.Add(loginControl);
            CenterControl(loginControl);
        }

        public void LoadRegisterControl()
        {
            var registerControl = new RegisterControl();
            registerControl.Dock = DockStyle.None;
            registerControl.BackToLogin += LoadLoginControl;
            Controls.Clear();
            Controls.Add(registerControl);
            CenterControl(registerControl);
        }

        public void LoadPasswordRecoveryControl()
        {
            var passwordRecoveryControl = new PasswordRecoveryControl();
            passwordRecoveryControl.Dock = DockStyle.None;
            passwordRecoveryControl.BackToLogin += LoadLoginControl;
            Controls.Clear();
            Controls.Add(passwordRecoveryControl);
            CenterControl(passwordRecoveryControl);
        }

        private void LoadMainControl(object sender, User user)
        {
            var mainControl = new MainControl(user);
            mainControl.Dock = DockStyle.None;
            mainControl.EditExpense += LoadEditExpenseControl;
            mainControl.ViewChart += LoadChartControl;
            mainControl.QueryData += LoadQueryControl;
            mainControl.Logout += LoadLoginControl;
            Controls.Clear();
            Controls.Add(mainControl);
            CenterControl(mainControl);
        }

        private void LoadEditExpenseControl(object sender, Expense expense)
        {
            var mainControl = sender as MainControl;
            var editControl = new EditExpenseControl(expense, mainControl.CurrentUser);
            editControl.Dock = DockStyle.None;
            editControl.BackToMain += (s, ev) => LoadMainControl(sender, mainControl.CurrentUser);
            Controls.Clear();
            Controls.Add(editControl);
            CenterControl(editControl);
        }

        private void LoadQueryControl(object sender, EventArgs e)
        {
            var mainControl = sender as MainControl;
            var queryControl = new QueryControl(mainControl.CurrentUser);
            queryControl.Dock = DockStyle.None;
            queryControl.BackToMain += (s, ev) => LoadMainControl(sender, mainControl.CurrentUser);
            Controls.Clear();
            Controls.Add(queryControl);
            CenterControl(queryControl);
        }

        private void LoadChartControl(object sender, EventArgs e)
        {
            var mainControl = sender as MainControl;
            var chartControl = new ChartControl(mainControl.CurrentUser);
            chartControl.Dock = DockStyle.None;
            chartControl.BackToMain += (s, ev) => LoadMainControl(sender, mainControl.CurrentUser);
            Controls.Clear();
            Controls.Add(chartControl);
            CenterControl(chartControl);
        }

        private void CenterControl(Control control)
        {
            control.Left = (ClientSize.Width - control.Width) / 2;
            control.Top = (ClientSize.Height - control.Height) / 2;
        }
    }
}
