using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Uchet_uspevaemosti
{
    public partial class FormAvtorizacia : Form
    {
        private SqlConnection sqlConnection = null;
        public FormAvtorizacia()
        {
            InitializeComponent();
        }

        private void buttonVxod_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT*FROM Users  WHERE login = @login AND password = @password", sqlConnection);
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = loginUser;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormGurnal f1 = new FormGurnal();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Логин/пароль введены неверно", "Ошибка");
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
