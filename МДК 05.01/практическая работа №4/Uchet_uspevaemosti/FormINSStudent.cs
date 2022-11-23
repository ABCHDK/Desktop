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
    public partial class FormINSStudent : Form
    {
        private SqlConnection sqlConnection = null;
        public FormINSStudent()
        {
            InitializeComponent();
        }

        private void buttonINS_Click(object sender, EventArgs e)
        {
            if (labelErrorINSUP.Visible)
                labelErrorINSUP.Visible = false;

            if (!string.IsNullOrEmpty(textBoxNameUPINS.Text) && !string.IsNullOrWhiteSpace(textBoxNameUPINS.Text) &&
                !string.IsNullOrEmpty(textBoxFirstnameUPINS.Text) && !string.IsNullOrWhiteSpace(textBoxFirstnameUPINS.Text) &&
                !string.IsNullOrEmpty(textBoxOtchestvoUPINS.Text) && !string.IsNullOrWhiteSpace(textBoxOtchestvoUPINS.Text) &&
                !string.IsNullOrEmpty(comboBoxSpecialnostUPINS.Text) && !string.IsNullOrWhiteSpace(comboBoxSpecialnostUPINS.Text) &&
                !string.IsNullOrEmpty(comboBoxKursUPINS.Text) && !string.IsNullOrWhiteSpace(comboBoxKursUPINS.Text) &&
                !string.IsNullOrEmpty(comboBoxDisciplinaUPINS.Text) && !string.IsNullOrWhiteSpace(comboBoxDisciplinaUPINS.Text) &&
                !string.IsNullOrEmpty(comboBoxGruppaUPINS.Text) && !string.IsNullOrWhiteSpace(comboBoxGruppaUPINS.Text) &&
                !string.IsNullOrEmpty(comboBoxUchGodUPINS.Text) && !string.IsNullOrWhiteSpace(comboBoxUchGodUPINS.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Student] (Familiya, Name, Otchestvo, Special_ID, Kurs_ID, Discipl_ID, Grup_ID, Uch_god_ID)VALUES(@Familiya, @Name, @Otchestvo, @Special_ID, @Kurs_ID, @Discipl_ID, @Grup_ID, @Uch_god_ID)", sqlConnection);

                command.Parameters.AddWithValue("Familiya", textBoxFirstnameUPINS.Text);

                command.Parameters.AddWithValue("Name", textBoxNameUPINS.Text);

                command.Parameters.AddWithValue("Otchestvo", textBoxOtchestvoUPINS.Text);

                command.Parameters.AddWithValue("Special_ID", comboBoxSpecialnostUPINS.Text);

                command.Parameters.AddWithValue("Kurs_ID", comboBoxKursUPINS.Text);

                command.Parameters.AddWithValue("Discipl_ID", comboBoxDisciplinaUPINS.Text);

                command.Parameters.AddWithValue("Grup_ID", comboBoxGruppaUPINS.Text);

                command.Parameters.AddWithValue("Uch_god_ID", comboBoxUchGodUPINS.Text);

                command.ExecuteNonQuery();
            }
            else
            {
                labelErrorINSUP.Visible = true;

                labelErrorINSUP.Text = "Поля не заполнены!";
            }
            textBoxFirstnameUPINS.Clear();
            textBoxNameUPINS.Clear();
            textBoxOtchestvoUPINS.Clear();
            comboBoxSpecialnostUPINS.SelectedIndex = -1;
            comboBoxKursUPINS.SelectedIndex = -1;
            comboBoxDisciplinaUPINS.SelectedIndex = -1;
            comboBoxGruppaUPINS.SelectedIndex = -1;
            comboBoxUchGodUPINS.SelectedIndex = -1;

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();
        }

        private void FormINSStudent_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();
        }

        private void comboBoxSpecialnostUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxKursUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxDisciplinaUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxGruppaUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxUchGodUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxNameUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxFirstnameUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxOtchestvoUPINS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Вы вводите неверные символы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGurnal f1 = new FormGurnal();
            f1.ShowDialog();
            this.Close();
        }
    }
}
