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
    public partial class FormGurnal : Form
    {
        private SqlConnection sqlConnection = null;
        public FormGurnal()
        {
            InitializeComponent();
        }

        private void FormGurnal_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Student", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Специальность";
            dataGridView1.Columns[5].HeaderCell.Value = "Курс";
            dataGridView1.Columns[6].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[7].HeaderCell.Value = "Группа";
            dataGridView1.Columns[8].HeaderCell.Value = "Учебный год";

            comboBoxSearchGruppa.SelectedIndex = -1;
            comboBoxSearchName.SelectedIndex = -1;
            comboBoxUPDisciplStudent.SelectedIndex = -1;
            comboBoxUPGruppaStudent.SelectedIndex = -1;
            comboBoxUPKursStudent.SelectedIndex = -1;
            comboBoxUPSpecialStudent.SelectedIndex = -1;
            comboBoxUPUcheb_GodStudent.SelectedIndex = -1;
        }

        private void comboBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Student", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Специальность";
            dataGridView1.Columns[5].HeaderCell.Value = "Курс";
            dataGridView1.Columns[6].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[7].HeaderCell.Value = "Группа";
            dataGridView1.Columns[8].HeaderCell.Value = "Учебный год";

            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{comboBoxSearchName.Text}%'";
            //dataGridView1.DataSource = table;
        }

        private void comboBoxSearchGruppa_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Student", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Специальность";
            dataGridView1.Columns[5].HeaderCell.Value = "Курс";
            dataGridView1.Columns[6].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[7].HeaderCell.Value = "Группа";
            dataGridView1.Columns[8].HeaderCell.Value = "Учебный год";

            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Grup_ID LIKE '%{comboBoxSearchGruppa.Text}%'";
            //dataGridView1.DataSource = table;
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            comboBoxSearchGruppa.SelectedIndex = -1;
            comboBoxSearchName.SelectedIndex = -1;
        }

        private void buttonINSStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormINSStudent f1 = new FormINSStudent();
            f1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxIDDELStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonDELStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить данные студента?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (!string.IsNullOrEmpty(textBoxIDDELStudent.Text) && !string.IsNullOrWhiteSpace(textBoxIDDELStudent.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Student] WHERE [ID_stud]=@ID_stud", sqlConnection);

                command.Parameters.AddWithValue("ID_stud", textBoxIDDELStudent.Text);

                command.ExecuteNonQuery();
            }
            textBoxIDDELStudent.Clear();

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Student", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Специальность";
            dataGridView1.Columns[5].HeaderCell.Value = "Курс";
            dataGridView1.Columns[6].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[7].HeaderCell.Value = "Группа";
            dataGridView1.Columns[8].HeaderCell.Value = "Учебный год";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxUPFirstnameStudent.Enabled = true;
            textBoxUPNameStudent.Enabled = true;
            textBoxUPOtchestvoStudent.Enabled = true;
            comboBoxUPSpecialStudent.Enabled = true;
            comboBoxUPKursStudent.Enabled = true;
            comboBoxUPDisciplStudent.Enabled = true;
            comboBoxUPGruppaStudent.Enabled = true;
            comboBoxUPUcheb_GodStudent.Enabled = true;
            textBoxIDDELStudent.Enabled = true;
            buttonUPStudent.Enabled = true;
            textBoxIDDELStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxUPFirstnameStudent.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxUPNameStudent.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxUPOtchestvoStudent.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxUPSpecialStudent.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxUPKursStudent.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxUPDisciplStudent.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxUPGruppaStudent.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxUPUcheb_GodStudent.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonUP2XStudent_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxUPNameStudent.Text) && !string.IsNullOrWhiteSpace(textBoxUPNameStudent.Text) &&
                !string.IsNullOrEmpty(textBoxUPFirstnameStudent.Text) && !string.IsNullOrWhiteSpace(textBoxUPFirstnameStudent.Text) &&
                !string.IsNullOrEmpty(textBoxUPOtchestvoStudent.Text) && !string.IsNullOrWhiteSpace(textBoxUPOtchestvoStudent.Text) &&
                !string.IsNullOrEmpty(comboBoxUPSpecialStudent.Text) && !string.IsNullOrWhiteSpace(comboBoxUPSpecialStudent.Text) &&
                !string.IsNullOrEmpty(comboBoxUPKursStudent.Text) && !string.IsNullOrWhiteSpace(comboBoxUPKursStudent.Text) &&
                !string.IsNullOrEmpty(comboBoxUPDisciplStudent.Text) && !string.IsNullOrWhiteSpace(comboBoxUPDisciplStudent.Text) &&
                !string.IsNullOrEmpty(comboBoxUPGruppaStudent.Text) && !string.IsNullOrWhiteSpace(comboBoxUPGruppaStudent.Text) &&
                !string.IsNullOrEmpty(comboBoxUPUcheb_GodStudent.Text) && !string.IsNullOrWhiteSpace(comboBoxUPUcheb_GodStudent.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Student] SET [Name]=@Name, [Familiya]=@Familiya, [Otchestvo]=@Otchestvo, [Special_ID]=@Special_ID, [Kurs_ID]=@Kurs_ID, [Discipl_ID]=@Discipl_ID, [Grup_ID]=@Grup_ID, [Uch_god_ID]=@Uch_god_ID WHERE [ID_stud]=@ID_stud", sqlConnection);

                command.Parameters.AddWithValue("Familiya", textBoxUPFirstnameStudent.Text);
                command.Parameters.AddWithValue("Name", textBoxUPNameStudent.Text);
                command.Parameters.AddWithValue("Otchestvo", textBoxUPOtchestvoStudent.Text);
                command.Parameters.AddWithValue("Special_ID", comboBoxUPSpecialStudent.Text);
                command.Parameters.AddWithValue("Kurs_ID", comboBoxUPKursStudent.Text);
                command.Parameters.AddWithValue("Discipl_ID", comboBoxUPDisciplStudent.Text);
                command.Parameters.AddWithValue("Grup_ID", comboBoxUPGruppaStudent.Text);
                command.Parameters.AddWithValue("Uch_god_ID", comboBoxUPUcheb_GodStudent.Text);
                command.Parameters.AddWithValue("ID_stud", textBoxIDDELStudent.Text);
                command.ExecuteNonQuery();
            }

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Student", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Специальность";
            dataGridView1.Columns[5].HeaderCell.Value = "Курс";
            dataGridView1.Columns[6].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[7].HeaderCell.Value = "Группа";
            dataGridView1.Columns[8].HeaderCell.Value = "Учебный год";

            textBoxUPFirstnameStudent.Clear();
            textBoxUPNameStudent.Clear();
            textBoxUPOtchestvoStudent.Clear();
            comboBoxUPSpecialStudent.SelectedIndex = -1;
            comboBoxUPKursStudent.SelectedIndex = -1;
            comboBoxUPDisciplStudent.SelectedIndex = -1;
            comboBoxUPGruppaStudent.SelectedIndex = -1;
            comboBoxUPUcheb_GodStudent.SelectedIndex = -1;
            textBoxIDDELStudent.Clear();

            textBoxUPFirstnameStudent.Enabled = false;
            textBoxUPNameStudent.Enabled = false;
            textBoxUPOtchestvoStudent.Enabled = false;
            comboBoxUPSpecialStudent.Enabled = false;
            comboBoxUPKursStudent.Enabled = false;
            comboBoxUPDisciplStudent.Enabled = false;
            comboBoxUPGruppaStudent.Enabled = false;
            comboBoxUPUcheb_GodStudent.Enabled = false;
            textBoxIDDELStudent.Enabled = false;
            buttonUPStudent.Enabled = false;
        }

        private void comboBoxUPSpecialStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxUPKursStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxUPDisciplStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxUPGruppaStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxUPUcheb_GodStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Пожалуйста выберите данные из списка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxUPNameStudent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxUPFirstnameStudent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxUPOtchestvoStudent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonbackAvtorizacia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAvtorizacia f1 = new FormAvtorizacia();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonKurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKurs f1 = new FormKurs();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonSpecial_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpecialnost f1 = new FormSpecialnost();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonUcheb_God_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUcheb_God f1 = new FormUcheb_God();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonDiscipliny_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDiscipliny f1 = new FormDiscipliny();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonGruppa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGruppa f1 = new FormGruppa();
            f1.ShowDialog();
            this.Close();
        }
    }
}
