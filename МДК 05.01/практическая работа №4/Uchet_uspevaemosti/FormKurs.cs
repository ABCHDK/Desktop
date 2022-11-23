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
    public partial class FormKurs : Form
    {
        private SqlConnection sqlConnection = null;
        public FormKurs()
        {
            InitializeComponent();
        }

        private void FormKurs_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Kurs", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Курс";

           
        }

        private void buttonINSStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormINSKurs f1 = new FormINSKurs();
            f1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxIDDELStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonDELStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить данные курса?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (!string.IsNullOrEmpty(textBoxIDDELStudent.Text) && !string.IsNullOrWhiteSpace(textBoxIDDELStudent.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Kurs] WHERE [ID_kurs]=@ID_kurs", sqlConnection);

                command.Parameters.AddWithValue("ID_kurs", textBoxIDDELStudent.Text);

                command.ExecuteNonQuery();
            }
            textBoxIDDELStudent.Clear();

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Kurs", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Курс";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxUPFirstnameStudent.Enabled = true;
            textBoxIDDELStudent.Enabled = true;
            buttonUPStudent.Enabled = true;
            textBoxIDDELStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxUPFirstnameStudent.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttonUPStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUPFirstnameStudent.Text) && !string.IsNullOrWhiteSpace(textBoxUPFirstnameStudent.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Kurs] SET [Name]=@Name WHERE [ID_kurs]=@ID_kurs", sqlConnection);

                command.Parameters.AddWithValue("Name", textBoxUPFirstnameStudent.Text);
                command.Parameters.AddWithValue("ID_stud", textBoxIDDELStudent.Text);
                command.ExecuteNonQuery();
            }

            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-BE5REM0B;Initial Catalog=Uchet_uspevaem;Integrated Security=True");
            sqlConnection.Open();

            textBoxUPFirstnameStudent.Clear();
            textBoxIDDELStudent.Clear();

            textBoxUPFirstnameStudent.Enabled = false;
            textBoxIDDELStudent.Enabled = false;
            buttonUPStudent.Enabled = false;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT * FROM Kurs", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[1].HeaderCell.Value = "Курс";
        }

        private void textBoxUPFirstnameStudent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonbackAvtorizacia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGurnal f1 = new FormGurnal();
            f1.ShowDialog();
            this.Close();
        }
    }
}
