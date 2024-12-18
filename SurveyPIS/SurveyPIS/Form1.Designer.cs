namespace SurveyPIS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMed = new System.Windows.Forms.Button();
            this.buttonPolis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxPolis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMed
            // 
            this.buttonMed.Location = new System.Drawing.Point(256, 96);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(175, 78);
            this.buttonMed.TabIndex = 0;
            this.buttonMed.Text = "Медицинское освидетельствование";
            this.buttonMed.UseVisualStyleBackColor = true;
            this.buttonMed.Click += new System.EventHandler(this.buttonMed_Click);
            // 
            // buttonPolis
            // 
            this.buttonPolis.Location = new System.Drawing.Point(256, 207);
            this.buttonPolis.Name = "buttonPolis";
            this.buttonPolis.Size = new System.Drawing.Size(175, 77);
            this.buttonPolis.TabIndex = 1;
            this.buttonPolis.Text = "Полис";
            this.buttonPolis.UseVisualStyleBackColor = true;
            this.buttonPolis.Click += new System.EventHandler(this.buttonPolis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заполните данные и выберите нужный вариант";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Items.AddRange(new object[] {
            "Трудоустройство",
            "Длительное пребывание(более 90 дней)",
            "Иная цель"});
            this.comboBoxPurpose.Location = new System.Drawing.Point(15, 150);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPurpose.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите дату въезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 96);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите цель пребывания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите Вашу страну";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Азербайджан",
            "Таджикистан",
            "Узбекистан ",
            "Молдова",
            "Украина",
            "Киргизия",
            "Казахстан",
            "Армения",
            "Другая"});
            this.comboBoxCountry.Location = new System.Drawing.Point(15, 207);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // comboBoxPolis
            // 
            this.comboBoxPolis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolis.FormattingEnabled = true;
            this.comboBoxPolis.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxPolis.Location = new System.Drawing.Point(15, 260);
            this.comboBoxPolis.Name = "comboBoxPolis";
            this.comboBoxPolis.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPolis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "У вас имеется полис?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPolis);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPolis);
            this.Controls.Add(this.buttonMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMed;
        private System.Windows.Forms.Button buttonPolis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxPolis;
        private System.Windows.Forms.Label label5;
    }
}

