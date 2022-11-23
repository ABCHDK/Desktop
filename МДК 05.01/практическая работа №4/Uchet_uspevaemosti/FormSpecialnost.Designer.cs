
namespace Uchet_uspevaemosti
{
    partial class FormSpecialnost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonbackAvtorizacia = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDELStudent = new System.Windows.Forms.Button();
            this.textBoxIDDELStudent = new System.Windows.Forms.TextBox();
            this.buttonUPStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUPFirstnameStudent = new System.Windows.Forms.TextBox();
            this.buttonINSStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uchet_uspevaemDataSet = new Uchet_uspevaemosti.Uchet_uspevaemDataSet();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialnostTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter();
            this.iDspecialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbackAvtorizacia
            // 
            this.buttonbackAvtorizacia.Location = new System.Drawing.Point(16, 413);
            this.buttonbackAvtorizacia.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbackAvtorizacia.Name = "buttonbackAvtorizacia";
            this.buttonbackAvtorizacia.Size = new System.Drawing.Size(100, 28);
            this.buttonbackAvtorizacia.TabIndex = 78;
            this.buttonbackAvtorizacia.Text = "Вернуться";
            this.buttonbackAvtorizacia.UseVisualStyleBackColor = true;
            this.buttonbackAvtorizacia.Click += new System.EventHandler(this.buttonbackAvtorizacia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1195, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "номер специальности:";
            // 
            // buttonDELStudent
            // 
            this.buttonDELStudent.Location = new System.Drawing.Point(1198, 258);
            this.buttonDELStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDELStudent.Name = "buttonDELStudent";
            this.buttonDELStudent.Size = new System.Drawing.Size(133, 48);
            this.buttonDELStudent.TabIndex = 76;
            this.buttonDELStudent.Text = "Удалить данные специальности";
            this.buttonDELStudent.UseVisualStyleBackColor = true;
            this.buttonDELStudent.Click += new System.EventHandler(this.buttonDELStudent_Click);
            // 
            // textBoxIDDELStudent
            // 
            this.textBoxIDDELStudent.Enabled = false;
            this.textBoxIDDELStudent.Location = new System.Drawing.Point(1195, 229);
            this.textBoxIDDELStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDDELStudent.Name = "textBoxIDDELStudent";
            this.textBoxIDDELStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxIDDELStudent.TabIndex = 75;
            // 
            // buttonUPStudent
            // 
            this.buttonUPStudent.Enabled = false;
            this.buttonUPStudent.Location = new System.Drawing.Point(1204, 76);
            this.buttonUPStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUPStudent.Name = "buttonUPStudent";
            this.buttonUPStudent.Size = new System.Drawing.Size(116, 76);
            this.buttonUPStudent.TabIndex = 74;
            this.buttonUPStudent.Text = "Подтвердить изменения данных специальности";
            this.buttonUPStudent.UseVisualStyleBackColor = true;
            this.buttonUPStudent.Click += new System.EventHandler(this.buttonUPStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1201, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Специальность:";
            // 
            // textBoxUPFirstnameStudent
            // 
            this.textBoxUPFirstnameStudent.Enabled = false;
            this.textBoxUPFirstnameStudent.Location = new System.Drawing.Point(1201, 33);
            this.textBoxUPFirstnameStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUPFirstnameStudent.Name = "textBoxUPFirstnameStudent";
            this.textBoxUPFirstnameStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxUPFirstnameStudent.TabIndex = 72;
            this.textBoxUPFirstnameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUPFirstnameStudent_KeyPress);
            // 
            // buttonINSStudent
            // 
            this.buttonINSStudent.Location = new System.Drawing.Point(17, 356);
            this.buttonINSStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonINSStudent.Name = "buttonINSStudent";
            this.buttonINSStudent.Size = new System.Drawing.Size(200, 49);
            this.buttonINSStudent.TabIndex = 71;
            this.buttonINSStudent.Text = "Добавить данные специальности";
            this.buttonINSStudent.UseVisualStyleBackColor = true;
            this.buttonINSStudent.Click += new System.EventHandler(this.buttonINSStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDspecialDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specialnostBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 326);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // uchet_uspevaemDataSet
            // 
            this.uchet_uspevaemDataSet.DataSetName = "Uchet_uspevaemDataSet";
            this.uchet_uspevaemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // iDspecialDataGridViewTextBoxColumn
            // 
            this.iDspecialDataGridViewTextBoxColumn.DataPropertyName = "ID_special";
            this.iDspecialDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iDspecialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDspecialDataGridViewTextBoxColumn.Name = "iDspecialDataGridViewTextBoxColumn";
            this.iDspecialDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDspecialDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 800;
            // 
            // FormSpecialnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 448);
            this.ControlBox = false;
            this.Controls.Add(this.buttonbackAvtorizacia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDELStudent);
            this.Controls.Add(this.textBoxIDDELStudent);
            this.Controls.Add(this.buttonUPStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUPFirstnameStudent);
            this.Controls.Add(this.buttonINSStudent);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSpecialnost";
            this.Text = "Список специальностей";
            this.Load += new System.EventHandler(this.FormSpecialnost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbackAvtorizacia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDELStudent;
        private System.Windows.Forms.TextBox textBoxIDDELStudent;
        private System.Windows.Forms.Button buttonUPStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUPFirstnameStudent;
        private System.Windows.Forms.Button buttonINSStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Uchet_uspevaemDataSet uchet_uspevaemDataSet;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDspecialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}