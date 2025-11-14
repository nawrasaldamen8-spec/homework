namespace Even__Odd__Factorial
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.numSet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(276, 312);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(227, 41);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(276, 373);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(100, 41);
            this.btnEven.TabIndex = 4;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(403, 373);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(100, 41);
            this.btnOdd.TabIndex = 5;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(276, 207);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(227, 37);
            this.txtResult.TabIndex = 7;
            // 
            // numSet
            // 
            this.numSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSet.Location = new System.Drawing.Point(276, 143);
            this.numSet.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numSet.Name = "numSet";
            this.numSet.Size = new System.Drawing.Size(227, 38);
            this.numSet.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numSet);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnFactorial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.NumericUpDown numSet;
    }
}

