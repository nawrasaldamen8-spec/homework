namespace Selection_Controls
{
    partial class Form1
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
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Major = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.MaleRad = new System.Windows.Forms.RadioButton();
            this.FemaleRad = new System.Windows.Forms.RadioButton();
            this.AddRecored = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major.SuspendLayout();
            this.Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(78, 44);
            this.Idtxt.MaxLength = 7;
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(154, 22);
            this.Idtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Favurate Language:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(217, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(323, 102);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 20);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "JAVA";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(484, 105);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 20);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Python";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Major
            // 
            this.Major.Controls.Add(this.comboBox1);
            this.Major.Controls.Add(this.label3);
            this.Major.Controls.Add(this.radioButton2);
            this.Major.Controls.Add(this.radioButton3);
            this.Major.Controls.Add(this.radioButton1);
            this.Major.Location = new System.Drawing.Point(28, 168);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(843, 100);
            this.Major.TabIndex = 6;
            this.Major.TabStop = false;
            this.Major.Text = "Major";
            this.Major.Enter += new System.EventHandler(this.Major_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(158, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(364, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CYS";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(259, 43);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CN";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(658, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.FemaleRad);
            this.Gender.Controls.Add(this.MaleRad);
            this.Gender.Location = new System.Drawing.Point(28, 288);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(263, 100);
            this.Gender.TabIndex = 7;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.Gender_Enter);
            // 
            // MaleRad
            // 
            this.MaleRad.AutoSize = true;
            this.MaleRad.Location = new System.Drawing.Point(50, 43);
            this.MaleRad.Name = "MaleRad";
            this.MaleRad.Size = new System.Drawing.Size(58, 20);
            this.MaleRad.TabIndex = 8;
            this.MaleRad.TabStop = true;
            this.MaleRad.Text = "Male";
            this.MaleRad.UseVisualStyleBackColor = true;
            this.MaleRad.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // FemaleRad
            // 
            this.FemaleRad.AutoSize = true;
            this.FemaleRad.Location = new System.Drawing.Point(139, 43);
            this.FemaleRad.Name = "FemaleRad";
            this.FemaleRad.Size = new System.Drawing.Size(74, 20);
            this.FemaleRad.TabIndex = 9;
            this.FemaleRad.TabStop = true;
            this.FemaleRad.Text = "Female";
            this.FemaleRad.UseVisualStyleBackColor = true;
            // 
            // AddRecored
            // 
            this.AddRecored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecored.Location = new System.Drawing.Point(28, 418);
            this.AddRecored.Name = "AddRecored";
            this.AddRecored.Size = new System.Drawing.Size(263, 53);
            this.AddRecored.TabIndex = 9;
            this.AddRecored.Text = "AddRecord";
            this.AddRecored.UseVisualStyleBackColor = true;
            this.AddRecored.Click += new System.EventHandler(this.AddRecored_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(789, 489);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 36);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.MajorsCol,
            this.genderCol,
            this.LangCol,
            this.YearCol});
            this.dataGridView1.Location = new System.Drawing.Point(338, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 193);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdCol
            // 
            this.IdCol.FillWeight = 75F;
            this.IdCol.HeaderText = "ID";
            this.IdCol.MinimumWidth = 6;
            this.IdCol.Name = "IdCol";
            this.IdCol.Width = 125;
            // 
            // MajorsCol
            // 
            this.MajorsCol.HeaderText = "Majors";
            this.MajorsCol.MinimumWidth = 6;
            this.MajorsCol.Name = "MajorsCol";
            this.MajorsCol.Width = 125;
            // 
            // genderCol
            // 
            this.genderCol.HeaderText = "Gender";
            this.genderCol.MinimumWidth = 6;
            this.genderCol.Name = "genderCol";
            this.genderCol.Width = 125;
            // 
            // LangCol
            // 
            this.LangCol.HeaderText = "Languages";
            this.LangCol.MinimumWidth = 6;
            this.LangCol.Name = "LangCol";
            this.LangCol.Width = 125;
            // 
            // YearCol
            // 
            this.YearCol.HeaderText = "Years";
            this.YearCol.MinimumWidth = 6;
            this.YearCol.Name = "YearCol";
            this.YearCol.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddRecored);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Idtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Major.ResumeLayout(false);
            this.Major.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox Major;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton MaleRad;
        private System.Windows.Forms.RadioButton FemaleRad;
        private System.Windows.Forms.Button AddRecored;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LangCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCol;
    }
}

