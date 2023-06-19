using DB_project.Classes;
using DB_project.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB_project
{
    public partial class Auth : Form
    {
        public Model model;
        public Auth(Model md)
        {
            model = md;
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (loginInput.Text != "" && passwordInput.Text != "")
            {
                DataTable response = model.SharedTCP.tryAuthorization(loginInput.Text, passwordInput.Text);

                if (response.Rows.Count == 0)
                {
                    model.SharedHTTP.createAccount(loginInput.Text, passwordInput.Text);
                    MessageBox.Show("Регистрация прошла успешно!");
                    Hide();
                    loginInput.Clear();
                    passwordInput.Clear();
                    responseLabel.Text = "";
                    MainForm mainForm = new MainForm(model);
                    mainForm.Show();
                }
                else
                {
                    responseLabel.Text = "Аккаунт с таким логином существует!";
                }
            }
            else
            {
                responseLabel.Text = "Поля логина и пароля обязательны.";
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginInput.Text != "" || passwordInput.Text != "")
                {
                    DataTable response = model.SharedTCP.tryAuthorization(loginInput.Text, passwordInput.Text);
                    if (response.Rows.Count != 0)
                    {
                        loginInput.Clear();
                        passwordInput.Clear();
                        responseLabel.Text = "";
                        MainForm client = new MainForm(model);
                        client.Show();
                    }
                    else
                    {
                        responseLabel.Text = "Неверный логин или пароль!";
                    }
                }
                else
                {
                    responseLabel.Text = "Введите логин и пароль!";
                }
            }
            catch (Exception ex)
            {
                responseLabel.Text = ex.ToString();
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
                passwordInput.UseSystemPasswordChar = false;
            else
                passwordInput.UseSystemPasswordChar = true;
        }
    }
}
