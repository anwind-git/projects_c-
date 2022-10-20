using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tacsi
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            if (LoginFild.Text == "")
            {
                MessageBox.Show("Поле Логин незаполнено");
                return;
            }
            if (PasswordFild.Text == "")
            {
                MessageBox.Show("Поле Пароль незаполнено");
                return;
            }
            if (UserName.Text == "")
            {
                MessageBox.Show("Поле Имя незаполнено");
                return;
            }
            if (UserSurname.Text == "")
            {
                MessageBox.Show("Поле Фамилия незаполнено");
                return;
            }
            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pas, @name, @surname)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginFild.Text;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = PasswordFild.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Новый пользователь зарегистрирован");
                this.Hide();
                LoginForm loginform = new LoginForm();
                loginform.Show();
            }
            else
                MessageBox.Show("Неудалось зарегистрировать пользователя");      
                db.CloseConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginFild.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким Логином уже существует");
                return true;
            }
            else
                return false;
        }

        private void Autolabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }
    }
}
