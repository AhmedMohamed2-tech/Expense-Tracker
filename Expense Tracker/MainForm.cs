using System;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class MainForm : Form
    {
        public User CurrentUser { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadLoginControl();
        }

        public void LoadLoginControl()
        {
            mainPanel.Controls.Clear();
            var loginControl = new LoginControl();
            loginControl.LoginSuccessful += LoadMainControl;
            CenterControl(loginControl);
            mainPanel.Controls.Add(loginControl);
        }

        public void LoadRegisterControl()
        {
            mainPanel.Controls.Clear();
            var registerControl = new RegisterControl();
            registerControl.RegistrationSuccessful += (s, e) => LoadLoginControl();
            registerControl.BackToLogin += (s, e) => LoadLoginControl();
            CenterControl(registerControl);
            mainPanel.Controls.Add(registerControl);
        }

        public void LoadPasswordRecoveryControl()
        {
            mainPanel.Controls.Clear();
            var passwordRecoveryControl = new PasswordRecoveryControl();
            passwordRecoveryControl.BackToLogin += (s, e) => LoadLoginControl();
            CenterControl(passwordRecoveryControl);
            mainPanel.Controls.Add(passwordRecoveryControl);
        }

        public void LoadMainControl(object sender, User user)
        {
            CurrentUser = user;
            mainPanel.Controls.Clear();
            var mainControl = new MainControl(user);
            mainControl.EditExpense += (s, expense) => LoadEditExpenseControl(expense);
            mainControl.ViewChart += (s, e) => LoadChartControl(user);
            mainControl.Logout += (s, e) => LoadLoginControl();
            CenterControl(mainControl);
            mainPanel.Controls.Add(mainControl);
        }

        public void LoadEditExpenseControl(Expense expense)
        {
            mainPanel.Controls.Clear();
            var editExpenseControl = new EditExpenseControl(expense);
            editExpenseControl.ExpenseUpdated += (s, e) => LoadMainControl(this, CurrentUser);
            editExpenseControl.BackToMain += (s, e) => LoadMainControl(this, CurrentUser);
            CenterControl(editExpenseControl);
            mainPanel.Controls.Add(editExpenseControl);
        }

        public void LoadChartControl(User user)
        {
            mainPanel.Controls.Clear();
            var chartControl = new ChartControl(user);
            chartControl.BackToMain += (s, e) => LoadMainControl(this, CurrentUser);
            CenterControl(chartControl);
            mainPanel.Controls.Add(chartControl);
        }

        private void CenterControl(Control control)
        {
            control.Location = new System.Drawing.Point(
                (mainPanel.Width - control.Width) / 2,
                (mainPanel.Height - control.Height) / 2);
            control.Anchor = AnchorStyles.None;
        }
    }
}
