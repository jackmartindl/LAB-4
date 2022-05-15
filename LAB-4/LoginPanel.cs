using System;
using System.Windows.Forms;

namespace LAB_4
{
    public partial class LoginPanel : Form
    {
        private bool _passwordShowed;
        private DatabaseHandler _database = new DatabaseHandler();
        private int loginAttempts = 0;
        public LoginPanel()
        {
            InitializeComponent();

            Text = "Logowanie";
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!_passwordShowed)
            {
                _passwordShowed = true;
                passwordField.PasswordChar = '\0';
            } else
            {
                _passwordShowed = false;
                passwordField.PasswordChar = '*';
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerPanel = new RegisterPanel();
            registerPanel.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginAttempts >= 3)
            {
                MessageBox.Show("Liczba prób logowania przekroczyła 3! Zablokowano możliwość logowania");
            }
            else
            {
                if (_database.CheckUserCredimentals(loginField.Text, passwordField.Text))
                {
                    loginAttempts = 0;
                    if (_database.getUser(loginField.Text).Permissions.Equals("user"))
                    {
                        Hide();
                        var userPanel = new UserPanel(_database.getUser(loginField.Text));
                        userPanel.Show();
                        userPanel.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    }
                    else
                    {
                        Hide();
                        var adminPanel = new AdminPanel();
                        adminPanel.Show();
                        adminPanel.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    }
                }
                else
                {
                    MessageBox.Show("Nie znaleziono podanego użytkownika!");
                    loginAttempts++;
                }
            }
        }
        
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}