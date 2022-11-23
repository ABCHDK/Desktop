
namespace Uchet_uspevaemosti
{
    partial class FormINSStudent
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
            this.buttonback = new System.Windows.Forms.Button();
            this.comboBoxSpecialnostUPINS = new System.Windows.Forms.ComboBox();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchet_uspevaemDataSet = new Uchet_uspevaemosti.Uchet_uspevaemDataSet();
            this.textBoxNameUPINS = new System.Windows.Forms.TextBox();
            this.buttonINS = new System.Windows.Forms.Button();
            this.textBoxOtchestvoUPINS = new System.Windows.Forms.TextBox();
            this.labelErrorINSUP = new System.Windows.Forms.Label();
            this.textBoxFirstnameUPINS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxUchGodUPINS = new System.Windows.Forms.ComboBox();
            this.uchebgodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxKursUPINS = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGruppaUPINS = new System.Windows.Forms.ComboBox();
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDisciplinaUPINS = new System.Windows.Forms.ComboBox();
            this.disciplinyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.specialnostTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter();
            this.kursTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.KursTableAdapter();
            this.disciplinyTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.DisciplinyTableAdapter();
            this.gruppaTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.GruppaTableAdapter();
            this.ucheb_godTableAdapter = new Uchet_uspevaemosti.Uchet_uspevaemDataSetTableAdapters.Ucheb_godTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebgodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(483, 4);
            this.buttonback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(100, 58);
            this.buttonback.TabIndex = 40;
            this.buttonback.Text = "Вернуться в журнал";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // comboBoxSpecialnostUPINS
            // 
            this.comboBoxSpecialnostUPINS.FormattingEnabled = true;
            this.comboBoxSpecialnostUPINS.Items.AddRange(new object[] {
            "08.01.25 Мастер отделочных строительных и декоративных работ",
            "08.02.01 Строительство и эксплуатация зданий и сооружений",
            "08.02.09 Монтаж, наладка и эксплуатация электрооборудования промышленных и гражда" +
                "нских зданий",
            "09.02.07 Информационные системы и программирование",
            "13.01.10 Электромонтер по ремонту и обслуживанию электрооборудования",
            "15.01.05 Сварщик",
            "15.01.30 Слесарь",
            "15.02.08 Технология машиностроения",
            "22.01.08 Оператор прокатного производства",
            "22.02.01 Металлургия черных металлов"});
            this.comboBoxSpecialnostUPINS.Location = new System.Drawing.Point(195, 36);
            this.comboBoxSpecialnostUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpecialnostUPINS.Name = "comboBoxSpecialnostUPINS";
            this.comboBoxSpecialnostUPINS.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSpecialnostUPINS.TabIndex = 25;
            this.comboBoxSpecialnostUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSpecialnostUPINS_KeyPress);
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // uchet_uspevaemDataSet
            // 
            this.uchet_uspevaemDataSet.DataSetName = "Uchet_uspevaemDataSet";
            this.uchet_uspevaemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxNameUPINS
            // 
            this.textBoxNameUPINS.Location = new System.Drawing.Point(16, 36);
            this.textBoxNameUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameUPINS.Name = "textBoxNameUPINS";
            this.textBoxNameUPINS.Size = new System.Drawing.Size(132, 22);
            this.textBoxNameUPINS.TabIndex = 22;
            this.textBoxNameUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameUPINS_KeyPress);
            // 
            // buttonINS
            // 
            this.buttonINS.Location = new System.Drawing.Point(16, 201);
            this.buttonINS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonINS.Name = "buttonINS";
            this.buttonINS.Size = new System.Drawing.Size(133, 44);
            this.buttonINS.TabIndex = 39;
            this.buttonINS.Text = "Добавить судента";
            this.buttonINS.UseVisualStyleBackColor = true;
            this.buttonINS.Click += new System.EventHandler(this.buttonINS_Click);
            // 
            // textBoxOtchestvoUPINS
            // 
            this.textBoxOtchestvoUPINS.Location = new System.Drawing.Point(16, 126);
            this.textBoxOtchestvoUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtchestvoUPINS.Name = "textBoxOtchestvoUPINS";
            this.textBoxOtchestvoUPINS.Size = new System.Drawing.Size(132, 22);
            this.textBoxOtchestvoUPINS.TabIndex = 23;
            this.textBoxOtchestvoUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOtchestvoUPINS_KeyPress);
            // 
            // labelErrorINSUP
            // 
            this.labelErrorINSUP.AutoSize = true;
            this.labelErrorINSUP.ForeColor = System.Drawing.Color.Red;
            this.labelErrorINSUP.Location = new System.Drawing.Point(380, 45);
            this.labelErrorINSUP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorINSUP.Name = "labelErrorINSUP";
            this.labelErrorINSUP.Size = new System.Drawing.Size(64, 17);
            this.labelErrorINSUP.TabIndex = 38;
            this.labelErrorINSUP.Text = "Ошибка!";
            this.labelErrorINSUP.Visible = false;
            // 
            // textBoxFirstnameUPINS
            // 
            this.textBoxFirstnameUPINS.Location = new System.Drawing.Point(16, 81);
            this.textBoxFirstnameUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstnameUPINS.Name = "textBoxFirstnameUPINS";
            this.textBoxFirstnameUPINS.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstnameUPINS.TabIndex = 24;
            this.textBoxFirstnameUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstnameUPINS_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Группа:";
            // 
            // comboBoxUchGodUPINS
            // 
            this.comboBoxUchGodUPINS.FormattingEnabled = true;
            this.comboBoxUchGodUPINS.Items.AddRange(new object[] {
            "2018-2022",
            "2019-2023",
            "2020-2024",
            "2021-2022",
            "2021-2025"});
            this.comboBoxUchGodUPINS.Location = new System.Drawing.Point(195, 217);
            this.comboBoxUchGodUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUchGodUPINS.Name = "comboBoxUchGodUPINS";
            this.comboBoxUchGodUPINS.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUchGodUPINS.TabIndex = 26;
            this.comboBoxUchGodUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUchGodUPINS_KeyPress);
            // 
            // uchebgodBindingSource
            // 
            this.uchebgodBindingSource.DataMember = "Ucheb_god";
            this.uchebgodBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Учебный год:";
            // 
            // comboBoxKursUPINS
            // 
            this.comboBoxKursUPINS.FormattingEnabled = true;
            this.comboBoxKursUPINS.Items.AddRange(new object[] {
            "1 курс",
            "2 курс",
            "3 курс",
            "4 курс"});
            this.comboBoxKursUPINS.Location = new System.Drawing.Point(195, 81);
            this.comboBoxKursUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKursUPINS.Name = "comboBoxKursUPINS";
            this.comboBoxKursUPINS.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKursUPINS.TabIndex = 27;
            this.comboBoxKursUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKursUPINS_KeyPress);
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Имя:";
            // 
            // comboBoxGruppaUPINS
            // 
            this.comboBoxGruppaUPINS.FormattingEnabled = true;
            this.comboBoxGruppaUPINS.Items.AddRange(new object[] {
            "18-А",
            "18-МиТОМ",
            "19-Ис",
            "19-ТМ",
            "19-Э",
            "20-Б",
            "20-МОСиДР",
            "20-Сл",
            "20-ТМ",
            "20-Эл"});
            this.comboBoxGruppaUPINS.Location = new System.Drawing.Point(195, 171);
            this.comboBoxGruppaUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGruppaUPINS.Name = "comboBoxGruppaUPINS";
            this.comboBoxGruppaUPINS.Size = new System.Drawing.Size(160, 24);
            this.comboBoxGruppaUPINS.TabIndex = 28;
            this.comboBoxGruppaUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGruppaUPINS_KeyPress);
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "Gruppa";
            this.gruppaBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Отчество:";
            // 
            // comboBoxDisciplinaUPINS
            // 
            this.comboBoxDisciplinaUPINS.FormattingEnabled = true;
            this.comboBoxDisciplinaUPINS.Items.AddRange(new object[] {
            "Английский язык",
            "Астрономия",
            "История",
            "Литература",
            "Математика",
            "Русский язык",
            "Физика",
            "Физ-ра",
            "Философия",
            "Химия"});
            this.comboBoxDisciplinaUPINS.Location = new System.Drawing.Point(193, 126);
            this.comboBoxDisciplinaUPINS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDisciplinaUPINS.Name = "comboBoxDisciplinaUPINS";
            this.comboBoxDisciplinaUPINS.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDisciplinaUPINS.TabIndex = 29;
            this.comboBoxDisciplinaUPINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDisciplinaUPINS_KeyPress);
            // 
            // disciplinyBindingSource
            // 
            this.disciplinyBindingSource.DataMember = "Discipliny";
            this.disciplinyBindingSource.DataSource = this.uchet_uspevaemDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дисциплина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Курс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Фамилие:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Специальность:";
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinyTableAdapter
            // 
            this.disciplinyTableAdapter.ClearBeforeFill = true;
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // ucheb_godTableAdapter
            // 
            this.ucheb_godTableAdapter.ClearBeforeFill = true;
            // 
            // FormINSStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 249);
            this.ControlBox = false;
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.comboBoxSpecialnostUPINS);
            this.Controls.Add(this.textBoxNameUPINS);
            this.Controls.Add(this.buttonINS);
            this.Controls.Add(this.textBoxOtchestvoUPINS);
            this.Controls.Add(this.labelErrorINSUP);
            this.Controls.Add(this.textBoxFirstnameUPINS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxUchGodUPINS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxKursUPINS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGruppaUPINS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDisciplinaUPINS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormINSStudent";
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.FormINSStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchet_uspevaemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebgodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ComboBox comboBoxSpecialnostUPINS;
        private System.Windows.Forms.TextBox textBoxNameUPINS;
        private System.Windows.Forms.Button buttonINS;
        private System.Windows.Forms.TextBox textBoxOtchestvoUPINS;
        private System.Windows.Forms.Label labelErrorINSUP;
        private System.Windows.Forms.TextBox textBoxFirstnameUPINS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUchGodUPINS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxKursUPINS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGruppaUPINS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDisciplinaUPINS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Uchet_uspevaemDataSet uchet_uspevaemDataSet;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.KursTableAdapter kursTableAdapter;
        private System.Windows.Forms.BindingSource disciplinyBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.DisciplinyTableAdapter disciplinyTableAdapter;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.GruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.BindingSource uchebgodBindingSource;
        private Uchet_uspevaemDataSetTableAdapters.Ucheb_godTableAdapter ucheb_godTableAdapter;
    }
}