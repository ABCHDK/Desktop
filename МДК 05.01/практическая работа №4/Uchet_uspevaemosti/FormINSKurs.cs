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
    public partial class FormINSKurs : Form
    {
        private SqlConnection sqlConnection = null;
        public FormINSKurs()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKurs f1 = new FormKurs();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonINS_Click(object sender, EventArgs e)
        {
            if (labelErrorINSUP.Visible)
                labelErrorINSUP.Visible = false;

            if (!string.IsNullOrEmpty(textBoxKurs.Text) && !string.IsNullOrWhiteSpace(textBoxKurs.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Kurs] (Name)VALUES(@Name)", sqlConnection);

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
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormINSKurs_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();
        }
    }
}
