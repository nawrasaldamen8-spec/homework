using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Operations(string Number1, string op, string Number2) {
            try
            {
            DataTable dt = new DataTable();
              return Convert.ToDouble(dt.Compute(Number1 + op + Number2, null));

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private string OperationToStr(Button btn) {

            double Result = Operations(textBox1.Text, btn.Text, textBox2.Text);
            return Result.ToString();
        }


        private void Operation_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            textBox3.Text = OperationToStr(btn);
        }

        
    }
}
