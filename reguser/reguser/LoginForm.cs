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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void OpenUser_Click(object sender, EventArgs e)
        {
            string loginUser = LoginFild.Text;
            string passwordUser = PasswordFild.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MayForm mainform = new MayForm();
                mainform.Show();
            }
            else
                MessageBox.Show("Пользователь не авторизован");
        }

        private void LoginFild_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordFild_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registrForm = new RegistrForm();
            registrForm.Show();
        }
    }
}
