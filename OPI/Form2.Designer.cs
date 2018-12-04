namespace OPI
{
    partial class Form_inp_out
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.ComboBox();
            this.form_d = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datatime = new System.Windows.Forms.Label();
            this.form_dd = new System.Windows.Forms.Label();
            this.groupp = new System.Windows.Forms.Label();
            this.statuss = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество*:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(107, 23);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(134, 20);
            this.surname.TabIndex = 3;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(107, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 20);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(107, 94);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(134, 20);
            this.patronymic.TabIndex = 5;
            this.patronymic.TextChanged += new System.EventHandler(this.patronymic_TextChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(433, 231);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 6;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(539, 231);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 7;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения*:";
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "ИПО-16",
            "МН-16",
            "ЕЛ-16",
            "АКИТ-16",
            "ЕК-16"});
            this.group.Location = new System.Drawing.Point(421, 57);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(134, 21);
            this.group.TabIndex = 10;
            this.group.SelectedIndexChanged += new System.EventHandler(this.group_SelectedIndexChanged);
            // 
            // form_d
            // 
            this.form_d.FormattingEnabled = true;
            this.form_d.Items.AddRange(new object[] {
            "Студент",
            "Сотрудник кафедры",
            "Сотрудник и студент"});
            this.form_d.Location = new System.Drawing.Point(421, 23);
            this.form_d.Name = "form_d";
            this.form_d.Size = new System.Drawing.Size(134, 21);
            this.form_d.TabIndex = 11;
            this.form_d.SelectedIndexChanged += new System.EventHandler(this.form_d_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Форма деятельности*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Группа:";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Учащийся",
            "Отчислен"});
            this.status.Location = new System.Drawing.Point(421, 93);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(134, 21);
            this.status.TabIndex = 14;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Статус студента";
            // 
            // datatime
            // 
            this.datatime.AutoSize = true;
            this.datatime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datatime.Location = new System.Drawing.Point(107, 137);
            this.datatime.Name = "datatime";
            this.datatime.Size = new System.Drawing.Size(0, 13);
            this.datatime.TabIndex = 16;
            // 
            // form_dd
            // 
            this.form_dd.AutoSize = true;
            this.form_dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_dd.Location = new System.Drawing.Point(418, 26);
            this.form_dd.Name = "form_dd";
            this.form_dd.Size = new System.Drawing.Size(0, 13);
            this.form_dd.TabIndex = 17;
            // 
            // groupp
            // 
            this.groupp.AutoSize = true;
            this.groupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupp.Location = new System.Drawing.Point(418, 60);
            this.groupp.Name = "groupp";
            this.groupp.Size = new System.Drawing.Size(0, 13);
            this.groupp.TabIndex = 18;
            // 
            // statuss
            // 
            this.statuss.AutoSize = true;
            this.statuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuss.Location = new System.Drawing.Point(418, 97);
            this.statuss.Name = "statuss";
            this.statuss.Size = new System.Drawing.Size(0, 13);
            this.statuss.TabIndex = 19;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(328, 231);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form_inp_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 266);
            this.Controls.Add(this.add);
            this.Controls.Add(this.statuss);
            this.Controls.Add(this.groupp);
            this.Controls.Add(this.form_dd);
            this.Controls.Add(this.datatime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.form_d);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_inp_out";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox surname;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox patronymic;
        public System.Windows.Forms.Button edit;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox group;
        public System.Windows.Forms.ComboBox form_d;
        public System.Windows.Forms.ComboBox status;
        public System.Windows.Forms.Label datatime;
        public System.Windows.Forms.Label form_dd;
        public System.Windows.Forms.Label groupp;
        public System.Windows.Forms.Label statuss;
        public System.Windows.Forms.Button add;
    }
}