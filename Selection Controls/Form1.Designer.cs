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
            this.components = new System.ComponentModel.Container();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Major = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.FemaleRad = new System.Windows.Forms.RadioButton();
            this.MaleRad = new System.Windows.Forms.RadioButton();
            this.AddRecored = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LangCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.RandBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RandNum = new System.Windows.Forms.Label();
            this.Major.SuspendLayout();
            this.Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.Major.Location = new System.Drawing.Point(28, 140);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(860, 100);
            this.Major.TabIndex = 6;
            this.Major.TabStop = false;
            this.Major.Text = "Major";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First",
            "second",
            "Third",
            "Fourth"});
            this.comboBox1.Location = new System.Drawing.Point(593, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(340, 21);
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
            this.radioButton3.Location = new System.Drawing.Point(235, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CN";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(134, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.FemaleRad);
            this.Gender.Controls.Add(this.MaleRad);
            this.Gender.Location = new System.Drawing.Point(28, 257);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(263, 100);
            this.Gender.TabIndex = 7;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
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
            // 
            // AddRecored
            // 
            this.AddRecored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecored.Location = new System.Drawing.Point(28, 363);
            this.AddRecored.Name = "AddRecored";
            this.AddRecored.Size = new System.Drawing.Size(263, 120);
            this.AddRecored.TabIndex = 9;
            this.AddRecored.Text = "Add Record";
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
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.MajorsCol,
            this.genderCol,
            this.LangCol,
            this.YearCol,
            this.joined});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(310, 257);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 226);
            this.dataGridView1.TabIndex = 11;
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
            // joined
            // 
            this.joined.HeaderText = "Joined in";
            this.joined.MinimumWidth = 6;
            this.joined.Name = "joined";
            this.joined.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Right click to optional delete";
            // 
            // RandBtn
            // 
            this.RandBtn.Location = new System.Drawing.Point(770, 105);
            this.RandBtn.Name = "RandBtn";
            this.RandBtn.Size = new System.Drawing.Size(118, 35);
            this.RandBtn.TabIndex = 14;
            this.RandBtn.Text = "Create Random";
            this.RandBtn.UseVisualStyleBackColor = true;
            this.RandBtn.Click += new System.EventHandler(this.RandBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(770, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // RandNum
            // 
            this.RandNum.AutoSize = true;
            this.RandNum.Location = new System.Drawing.Point(767, 58);
            this.RandNum.Name = "RandNum";
            this.RandNum.Size = new System.Drawing.Size(94, 16);
            this.RandNum.TabIndex = 16;
            this.RandNum.Text = "Users Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.RandNum);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RandBtn);
            this.Controls.Add(this.label4);
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
            this.Major.ResumeLayout(false);
            this.Major.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn joined;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RandBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label RandNum;
    }
}

