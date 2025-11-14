using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Even__Odd__Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private long Factorial(decimal N1) {
            long result = 1;
            for (long i = 1; i <= N1; i++)
            {
                result *= i;
            }
            return result;
        }

        private bool Check(decimal Number) {
            if (Number % 2 == 0) { 
                return true;
            }
            return false;
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Factorial(numSet.Value)).ToString();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            if (Check(numSet.Value))
            {
                txtResult.Text = "Even";
            }
            else {
                txtResult.Text = "Not Even";
            }
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            if (!Check(numSet.Value))
            {
                txtResult.Text = "Odd";
            }
            else
            {
                txtResult.Text = "Not Odd";
            }
        }
    }
}
