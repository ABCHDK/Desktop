
namespace Uchet_uspevaemosti
{
    partial class FormGurnal
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
            this.buttonINSStudent = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSearchGruppa = new System.Windows.Forms.ComboBox();
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchet_uspevaemDataSet = new Uchet_uspevaemosti.Uchet_uspevaemDataSet();
            this.comboBoxSearchName = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxUPFirstnameStudent = new System.Windows.Forms.TextBox();
            this.textBoxUPOtchestvoStudent = new System.Windows.Forms.TextBox();
            this.textBoxUPNameStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUPStudent = new System.Windows.Forms.Button();
            this.comboBoxUPSpecialStudent = new System.Windows.Forms.ComboBox();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUPUcheb_GodStudent = new System.Windows.Forms.ComboBox();
            this.uchebgodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUPGruppaStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxUPDisciplStudent = new System.Windows.Forms.ComboBox();
            this.disciplinyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUPKursStudent = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxIDDELStudent = new System.Windows.Forms.TextBox();
            this.buttonDELStudent = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.StudentTableAdapter();
            this.gruppaTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.GruppaTableAdapter();
            this.ucheb_godTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.Ucheb_godTableAdapter();
            this.disciplinyTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.DisciplinyTableAdapter();
            this.kursTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.KursTableAdapter();
            this.specialnostTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter();
            this.buttonbackAvtorizacia = new System.Windows.Forms.Button();
            this.buttonKurs = new System.Windows.Forms.Button();
            this.buttonGruppa = new System.Windows.Forms.Button();
            this.buttonDiscipliny = new System.Windows.Forms.Button();
            this.buttonUcheb_God = new System.Windows.Forms.Button();
            this.buttonSpecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebgodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonINSStudent
            // 
            this.buttonINSStudent.Location = new System.Drawing.Point(22, 504);
            this.buttonINSStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonINSStudent.Name = "buttonINSStudent";
            this.buttonINSStudent.Size = new System.Drawing.Size(200, 49);
            this.buttonINSStudent.TabIndex = 33;
            this.buttonINSStudent.Text = "Добавить данные студента";
            this.buttonINSStudent.UseVisualStyleBackColor = true;
            this.buttonINSStudent.Click += new System.EventHandler(this.buttonINSStudent_Click);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Location = new System.Drawing.Point(898, 539);
            this.buttonClearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(100, 46);
            this.buttonClearSearch.TabIndex = 32;
            this.buttonClearSearch.Text = "Очистить поиск";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(904, 500);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Поиск:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1006, 546);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "По группе:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1006, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "По имени:";
            // 
            // comboBoxSearchGruppa
            // 
            this.comboBoxSearchGruppa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Grup_ID", true));
            this.comboBoxSearchGruppa.DataSource = this.studentBindingSource;
            this.comboBoxSearchGruppa.DisplayMember = "Grup_ID";
            this.comboBoxSearchGruppa.FormattingEnabled = true;
            this.comboBoxSearchGruppa.Location = new System.Drawing.Point(1010, 566);
            this.comboBoxSearchGruppa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchGruppa.Name = "comboBoxSearchGruppa";
            this.comboBoxSearchGruppa.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSearchGruppa.TabIndex = 28;
            this.comboBoxSearchGruppa.ValueMember = "Grup_ID";
            this.comboBoxSearchGruppa.TextChanged += new System.EventHandler(this.comboBoxSearchGruppa_TextChanged);
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "Gruppa";
            this.gruppaBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // uchet_uspevaemDataSet
            // 
            this.uchet_uspevaemDataSet.DataSetName = "Uchet_uspevaemDataSet";
            this.uchet_uspevaemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSearchName
            // 
            this.comboBoxSearchName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Name", true));
            this.comboBoxSearchName.DataSource = this.studentBindingSource;
            this.comboBoxSearchName.DisplayMember = "Name";
            this.comboBoxSearchName.FormattingEnabled = true;
            this.comboBoxSearchName.Location = new System.Drawing.Point(1010, 517);
            this.comboBoxSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchName.Name = "comboBoxSearchName";
            this.comboBoxSearchName.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSearchName.TabIndex = 27;
            this.comboBoxSearchName.ValueMember = "Name";
            this.comboBoxSearchName.TextChanged += new System.EventHandler(this.comboBoxSearchName_TextChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 164);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // textBoxUPFirstnameStudent
            // 
            this.textBoxUPFirstnameStudent.Enabled = false;
            this.textBoxUPFirstnameStudent.Location = new System.Drawing.Point(1239, 38);
            this.textBoxUPFirstnameStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUPFirstnameStudent.Name = "textBoxUPFirstnameStudent";
            this.textBoxUPFirstnameStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxUPFirstnameStudent.TabIndex = 35;
            this.textBoxUPFirstnameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUPFirstnameStudent_KeyPress);
            // 
            // textBoxUPOtchestvoStudent
            // 
            this.textBoxUPOtchestvoStudent.Enabled = false;
            this.textBoxUPOtchestvoStudent.Location = new System.Drawing.Point(1239, 134);
            this.textBoxUPOtchestvoStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUPOtchestvoStudent.Name = "textBoxUPOtchestvoStudent";
            this.textBoxUPOtchestvoStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxUPOtchestvoStudent.TabIndex = 41;
            this.textBoxUPOtchestvoStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUPOtchestvoStudent_KeyPress);
            // 
            // textBoxUPNameStudent
            // 
            this.textBoxUPNameStudent.Enabled = false;
            this.textBoxUPNameStudent.Location = new System.Drawing.Point(1239, 86);
            this.textBoxUPNameStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUPNameStudent.Name = "textBoxUPNameStudent";
            this.textBoxUPNameStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxUPNameStudent.TabIndex = 42;
            this.textBoxUPNameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUPNameStudent_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1239, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1235, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Учебный год:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1235, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1239, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Дисциплина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1239, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Курс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1239, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Специальность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1239, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Отчество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1239, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Имя:";
            // 
            // buttonUPStudent
            // 
            this.buttonUPStudent.Enabled = false;
            this.buttonUPStudent.Location = new System.Drawing.Point(1248, 406);
            this.buttonUPStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUPStudent.Name = "buttonUPStudent";
            this.buttonUPStudent.Size = new System.Drawing.Size(116, 76);
            this.buttonUPStudent.TabIndex = 51;
            this.buttonUPStudent.Text = "Подтвердить изменения данных студента";
            this.buttonUPStudent.UseVisualStyleBackColor = true;
            this.buttonUPStudent.Click += new System.EventHandler(this.buttonUP2XStudent_Click);
            // 
            // comboBoxUPSpecialStudent
            // 
            this.comboBoxUPSpecialStudent.DataSource = this.specialnostBindingSource;
            this.comboBoxUPSpecialStudent.DisplayMember = "Name";
            this.comboBoxUPSpecialStudent.Enabled = false;
            this.comboBoxUPSpecialStudent.FormattingEnabled = true;
            this.comboBoxUPSpecialStudent.Location = new System.Drawing.Point(1239, 181);
            this.comboBoxUPSpecialStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUPSpecialStudent.Name = "comboBoxUPSpecialStudent";
            this.comboBoxUPSpecialStudent.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUPSpecialStudent.TabIndex = 52;
            this.comboBoxUPSpecialStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUPSpecialStudent_KeyPress);
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // comboBoxUPUcheb_GodStudent
            // 
            this.comboBoxUPUcheb_GodStudent.DataSource = this.uchebgodBindingSource;
            this.comboBoxUPUcheb_GodStudent.DisplayMember = "Name";
            this.comboBoxUPUcheb_GodStudent.Enabled = false;
            this.comboBoxUPUcheb_GodStudent.FormattingEnabled = true;
            this.comboBoxUPUcheb_GodStudent.Location = new System.Drawing.Point(1239, 374);
            this.comboBoxUPUcheb_GodStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUPUcheb_GodStudent.Name = "comboBoxUPUcheb_GodStudent";
            this.comboBoxUPUcheb_GodStudent.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUPUcheb_GodStudent.TabIndex = 53;
            this.comboBoxUPUcheb_GodStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUPUcheb_GodStudent_KeyPress);
            // 
            // uchebgodBindingSource
            // 
            this.uchebgodBindingSource.DataMember = "Ucheb_god";
            this.uchebgodBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // comboBoxUPGruppaStudent
            // 
            this.comboBoxUPGruppaStudent.DataSource = this.gruppaBindingSource;
            this.comboBoxUPGruppaStudent.DisplayMember = "Name";
            this.comboBoxUPGruppaStudent.Enabled = false;
            this.comboBoxUPGruppaStudent.FormattingEnabled = true;
            this.comboBoxUPGruppaStudent.Location = new System.Drawing.Point(1239, 326);
            this.comboBoxUPGruppaStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUPGruppaStudent.Name = "comboBoxUPGruppaStudent";
            this.comboBoxUPGruppaStudent.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUPGruppaStudent.TabIndex = 54;
            this.comboBoxUPGruppaStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUPGruppaStudent_KeyPress);
            // 
            // comboBoxUPDisciplStudent
            // 
            this.comboBoxUPDisciplStudent.DataSource = this.disciplinyBindingSource;
            this.comboBoxUPDisciplStudent.DisplayMember = "Name";
            this.comboBoxUPDisciplStudent.Enabled = false;
            this.comboBoxUPDisciplStudent.FormattingEnabled = true;
            this.comboBoxUPDisciplStudent.Location = new System.Drawing.Point(1239, 277);
            this.comboBoxUPDisciplStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUPDisciplStudent.Name = "comboBoxUPDisciplStudent";
            this.comboBoxUPDisciplStudent.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUPDisciplStudent.TabIndex = 55;
            this.comboBoxUPDisciplStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUPDisciplStudent_KeyPress);
            // 
            // disciplinyBindingSource
            // 
            this.disciplinyBindingSource.DataMember = "Discipliny";
            this.disciplinyBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // comboBoxUPKursStudent
            // 
            this.comboBoxUPKursStudent.DataSource = this.kursBindingSource;
            this.comboBoxUPKursStudent.DisplayMember = "Name";
            this.comboBoxUPKursStudent.Enabled = false;
            this.comboBoxUPKursStudent.FormattingEnabled = true;
            this.comboBoxUPKursStudent.Location = new System.Drawing.Point(1239, 230);
            this.comboBoxUPKursStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUPKursStudent.Name = "comboBoxUPKursStudent";
            this.comboBoxUPKursStudent.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUPKursStudent.TabIndex = 56;
            this.comboBoxUPKursStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUPKursStudent_KeyPress);
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // textBoxIDDELStudent
            // 
            this.textBoxIDDELStudent.Enabled = false;
            this.textBoxIDDELStudent.Location = new System.Drawing.Point(1239, 517);
            this.textBoxIDDELStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDDELStudent.Name = "textBoxIDDELStudent";
            this.textBoxIDDELStudent.Size = new System.Drawing.Size(132, 22);
            this.textBoxIDDELStudent.TabIndex = 57;
            // 
            // buttonDELStudent
            // 
            this.buttonDELStudent.Location = new System.Drawing.Point(1238, 547);
            this.buttonDELStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDELStudent.Name = "buttonDELStudent";
            this.buttonDELStudent.Size = new System.Drawing.Size(133, 48);
            this.buttonDELStudent.TabIndex = 58;
            this.buttonDELStudent.Text = "Удалить данные студента";
            this.buttonDELStudent.UseVisualStyleBackColor = true;
            this.buttonDELStudent.Click += new System.EventHandler(this.buttonDELStudent_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1239, 497);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "номер студента:";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // ucheb_godTableAdapter
            // 
            this.ucheb_godTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinyTableAdapter
            // 
            this.disciplinyTableAdapter.ClearBeforeFill = true;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // buttonbackAvtorizacia
            // 
            this.buttonbackAvtorizacia.Location = new System.Drawing.Point(20, 562);
            this.buttonbackAvtorizacia.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbackAvtorizacia.Name = "buttonbackAvtorizacia";
            this.buttonbackAvtorizacia.Size = new System.Drawing.Size(100, 28);
            this.buttonbackAvtorizacia.TabIndex = 60;
            this.buttonbackAvtorizacia.Text = "Вернуться";
            this.buttonbackAvtorizacia.UseVisualStyleBackColor = true;
            this.buttonbackAvtorizacia.Click += new System.EventHandler(this.buttonbackAvtorizacia_Click);
            // 
            // buttonKurs
            // 
            this.buttonKurs.Location = new System.Drawing.Point(230, 504);
            this.buttonKurs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKurs.Name = "buttonKurs";
            this.buttonKurs.Size = new System.Drawing.Size(119, 49);
            this.buttonKurs.TabIndex = 61;
            this.buttonKurs.Text = "Список курсов";
            this.buttonKurs.UseVisualStyleBackColor = true;
            this.buttonKurs.Click += new System.EventHandler(this.buttonKurs_Click);
            // 
            // buttonGruppa
            // 
            this.buttonGruppa.Location = new System.Drawing.Point(755, 503);
            this.buttonGruppa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGruppa.Name = "buttonGruppa";
            this.buttonGruppa.Size = new System.Drawing.Size(123, 38);
            this.buttonGruppa.TabIndex = 62;
            this.buttonGruppa.Text = "Список групп";
            this.buttonGruppa.UseVisualStyleBackColor = true;
            this.buttonGruppa.Click += new System.EventHandler(this.buttonGruppa_Click);
            // 
            // buttonDiscipliny
            // 
            this.buttonDiscipliny.Location = new System.Drawing.Point(632, 503);
            this.buttonDiscipliny.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiscipliny.Name = "buttonDiscipliny";
            this.buttonDiscipliny.Size = new System.Drawing.Size(115, 49);
            this.buttonDiscipliny.TabIndex = 63;
            this.buttonDiscipliny.Text = "Список дисциплин";
            this.buttonDiscipliny.UseVisualStyleBackColor = true;
            this.buttonDiscipliny.Click += new System.EventHandler(this.buttonDiscipliny_Click);
            // 
            // buttonUcheb_God
            // 
            this.buttonUcheb_God.Location = new System.Drawing.Point(495, 504);
            this.buttonUcheb_God.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUcheb_God.Name = "buttonUcheb_God";
            this.buttonUcheb_God.Size = new System.Drawing.Size(129, 58);
            this.buttonUcheb_God.TabIndex = 64;
            this.buttonUcheb_God.Text = "Список учебных годов";
            this.buttonUcheb_God.UseVisualStyleBackColor = true;
            this.buttonUcheb_God.Click += new System.EventHandler(this.buttonUcheb_God_Click);
            // 
            // buttonSpecial
            // 
            this.buttonSpecial.Location = new System.Drawing.Point(356, 504);
            this.buttonSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSpecial.Name = "buttonSpecial";
            this.buttonSpecial.Size = new System.Drawing.Size(131, 49);
            this.buttonSpecial.TabIndex = 65;
            this.buttonSpecial.Text = "Список специальностей";
            this.buttonSpecial.UseVisualStyleBackColor = true;
            this.buttonSpecial.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // FormGurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 602);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSpecial);
            this.Controls.Add(this.buttonUcheb_God);
            this.Controls.Add(this.buttonDiscipliny);
            this.Controls.Add(this.buttonGruppa);
            this.Controls.Add(this.buttonKurs);
            this.Controls.Add(this.buttonbackAvtorizacia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDELStudent);
            this.Controls.Add(this.textBoxIDDELStudent);
            this.Controls.Add(this.comboBoxUPKursStudent);
            this.Controls.Add(this.comboBoxUPDisciplStudent);
            this.Controls.Add(this.comboBoxUPGruppaStudent);
            this.Controls.Add(this.comboBoxUPUcheb_GodStudent);
            this.Controls.Add(this.comboBoxUPSpecialStudent);
            this.Controls.Add(this.buttonUPStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUPNameStudent);
            this.Controls.Add(this.textBoxUPOtchestvoStudent);
            this.Controls.Add(this.textBoxUPFirstnameStudent);
            this.Controls.Add(this.buttonINSStudent);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSearchGruppa);
            this.Controls.Add(this.comboBoxSearchName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGurnal";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.FormGurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebgodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonINSStudent;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSearchGruppa;
        private System.Windows.Forms.ComboBox comboBoxSearchName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxUPFirstnameStudent;
        private System.Windows.Forms.TextBox textBoxUPOtchestvoStudent;
        private System.Windows.Forms.TextBox textBoxUPNameStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUPStudent;
        private System.Windows.Forms.ComboBox comboBoxUPSpecialStudent;
        private System.Windows.Forms.ComboBox comboBoxUPUcheb_GodStudent;
        private System.Windows.Forms.ComboBox comboBoxUPGruppaStudent;
        private System.Windows.Forms.ComboBox comboBoxUPDisciplStudent;
        private System.Windows.Forms.ComboBox comboBoxUPKursStudent;
        private System.Windows.Forms.TextBox textBoxIDDELStudent;
        private System.Windows.Forms.Button buttonDELStudent;
        private System.Windows.Forms.Label label10;
        private Uchet_uspevaemDataSet uchet_uspevaemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.GruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.BindingSource uchebgodBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.Ucheb_godTableAdapter ucheb_godTableAdapter;
        private System.Windows.Forms.BindingSource disciplinyBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.DisciplinyTableAdapter disciplinyTableAdapter;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.KursTableAdapter kursTableAdapter;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.Button buttonbackAvtorizacia;
        private System.Windows.Forms.Button buttonKurs;
        private System.Windows.Forms.Button buttonGruppa;
        private System.Windows.Forms.Button buttonDiscipliny;
        private System.Windows.Forms.Button buttonUcheb_God;
        private System.Windows.Forms.Button buttonSpecial;
    }
}