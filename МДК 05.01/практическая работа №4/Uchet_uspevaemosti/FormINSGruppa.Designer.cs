
namespace Uchet_uspevaemosti
{
    partial class FormINSGruppa
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
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonINS = new System.Windows.Forms.Button();
            this.labelErrorINSUP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKurs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(165, 9);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(105, 56);
            this.buttonback.TabIndex = 51;
            this.buttonback.Text = "Вернуться в список групп";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonINS
            // 
            this.buttonINS.Location = new System.Drawing.Point(15, 80);
            this.buttonINS.Name = "buttonINS";
            this.buttonINS.Size = new System.Drawing.Size(100, 36);
            this.buttonINS.TabIndex = 50;
            this.buttonINS.Text = "Добавить группу";
            this.buttonINS.UseVisualStyleBackColor = true;
            this.buttonINS.Click += new System.EventHandler(this.buttonINS_Click);
            // 
            // labelErrorINSUP
            // 
            this.labelErrorINSUP.AutoSize = true;
            this.labelErrorINSUP.ForeColor = System.Drawing.Color.Red;
            this.labelErrorINSUP.Location = new System.Drawing.Point(12, 55);
            this.labelErrorINSUP.Name = "labelErrorINSUP";
            this.labelErrorINSUP.Size = new System.Drawing.Size(50, 13);
            this.labelErrorINSUP.TabIndex = 49;
            this.labelErrorINSUP.Text = "Ошибка!";
            this.labelErrorINSUP.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Название группы:";
            // 
            // textBoxKurs
            // 
            this.textBoxKurs.Location = new System.Drawing.Point(15, 22);
            this.textBoxKurs.Name = "textBoxKurs";
            this.textBoxKurs.Size = new System.Drawing.Size(100, 20);
            this.textBoxKurs.TabIndex = 47;
            this.textBoxKurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKurs_KeyPress);
            // 
            // FormINSGruppa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 129);
            this.ControlBox = false;
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonINS);
            this.Controls.Add(this.labelErrorINSUP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKurs);
            this.Name = "FormINSGruppa";
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.FormINSGruppa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonINS;
        private System.Windows.Forms.Label labelErrorINSUP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKurs;
    }
}