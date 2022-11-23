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

namespace Uchet_uspevaemosti
{
    public partial class FormINSDiscipliny : Form
    {
        private SqlConnection sqlConnection = null;
        public FormINSDiscipliny()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDiscipliny f1 = new FormDiscipliny();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonINS_Click(object sender, EventArgs e)
        {
            if (labelErrorINSUP.Visible)
                labelErrorINSUP.Visible = false;

            if (!string.IsNullOrEmpty(textBoxKurs.Text) && !string.IsNullOrWhiteSpace(textBoxKurs.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Discipliny] (Name)VALUES(@Name)", sqlConnection);

                command.Parameters.AddWithValue("Name", textBoxKurs.Text);

                command.ExecuteNonQuery();
            }
            else
            {
                labelErrorINSUP.Visible = true;

                labelErrorINSUP.Text = "Поля не заполнены!";
            }
            textBoxKurs.Clear();

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();
        }

        private void textBoxKurs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == '-' || e.KeyChar == ':' || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormINSDiscipliny_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();
        }
    }
}
