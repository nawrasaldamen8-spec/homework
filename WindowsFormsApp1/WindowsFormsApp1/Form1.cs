using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int _labelCount = 0;
        private int _nextLabelY = 5;
        Label newLabel;

        enum TokenType
        {
            Number,
            Operator,
            UnaryOperator
        }

        class Token
        {
            public TokenType Type;
            public string Value;

            public Token(TokenType type, string value)
            {
                Type = type;
                Value = value;
            }
        }

        class Calculator
        {
            private List<Token> Tokenize(string expr) { 
                List<Token> tokens = new List<Token>();
                string temp = "";

                for (int i = 0; i < expr.Length; i++) {

                    char c = expr[i];

                    if(char.IsDigit(c) || c == '.')
                        temp += c;
                    else
                    {
                        if (temp != "") { 
                            tokens.Add(new Token(TokenType.Number, temp));
                            temp = "";
                        }

                        if (c == '√')
                        {
                            if (tokens.Count > 0 && tokens[tokens.Count - 1].Type == TokenType.Number)
                                tokens.Add(new Token(TokenType.Operator, "*")); // الضرب الضمني
                            tokens.Add(new Token(TokenType.UnaryOperator, "√"));
                        }
                        else if (c == '²')
                        {
                            tokens.Add(new Token(TokenType.UnaryOperator, "²"));
                        }
                        else { 
                            tokens.Add(new Token(TokenType.Operator, c.ToString()));
                        }
                    }
                }
                if (temp != "") {
                    tokens.Add(new Token(TokenType.Number, temp));
                }
                return tokens;
            }

            private double ApplyOperator( string op, double a, double b) {
                switch (op) {
                    case "+": return a + b;
                    case "-": return a - b;
                    case "*": return a * b;
                    case "/": return a / b;
                    default: throw new Exception("Invalid operator");
                }
            }

            private double ApplyUnaryOperator(double a, string op) {
                switch (op) {
                    case "√": return Math.Sqrt(a);
                    case "²": return a * a;
                    default: throw new Exception("Invalid unary operator");
                }
            }

            private void ProcessUnary(List<Token> tokens) {
                int i = 0;
                while (i < tokens.Count)
                {

                    if (tokens[i].Type == TokenType.UnaryOperator)
                    {
                        if (tokens[i].Value == "√")
                        {
                            double num = double.Parse(tokens[i + 1].Value, CultureInfo.InvariantCulture);
                            double res = Math.Sqrt(num);

                            tokens[i] = new Token(TokenType.Number, res.ToString(CultureInfo.InvariantCulture));
                            tokens.RemoveAt(i + 1);
                        }

                        else if (tokens[i].Value == "²")
                        {
                            double num = double.Parse(tokens[i - 1].Value, CultureInfo.InvariantCulture);
                            double res = num * num;

                            tokens[i - 1] = new Token(TokenType.Number, res.ToString(CultureInfo.InvariantCulture));
                            tokens.RemoveAt(i);
                            i--;
                        }
                    }

                    i++;
                }
            }

            private void ProcessMulDiv(List<Token> tokens) {
                for (int i = 0; i < tokens.Count; i++)
                {
                    if (tokens[i].Type == TokenType.Operator &&
                        (tokens[i].Value == "*" || tokens[i].Value == "/")) { 
                        
                        double left = double.Parse(tokens[i - 1].Value, CultureInfo.InvariantCulture);
                        double right = double.Parse(tokens[i + 1].Value, CultureInfo.InvariantCulture);

                        double result = ApplyOperator(tokens[i].Value, left, right);
                        
                        tokens[i - 1] = new Token(TokenType.Number, result.ToString(CultureInfo.InvariantCulture));
                        tokens.RemoveAt(i);
                        tokens.RemoveAt(i);
                        i--;
                    }
                }
            }

            private double ProcessAddSub(List<Token> tokens) {
                double result = double.Parse(tokens[0].Value, CultureInfo.InvariantCulture);
                for (int i = 1; i < tokens.Count; i += 2)
                {
                    string op = tokens[i].Value;
                    double nextNumber = double.Parse(tokens[i + 1].Value, CultureInfo.InvariantCulture);
                    result = ApplyOperator(op, result, nextNumber);
                }
                return result;
            }

            public double Evaluate(string expression) { 
                var tokens = Tokenize(expression);
                ProcessUnary(tokens);
                ProcessMulDiv(tokens);
                return ProcessAddSub(tokens);
            }
        }
        
        public void CreateNewOperationLabel(string operationDetails, ref string Expression)
        {

            newLabel = new Label();
            Label titleLable = new Label();

            titleLable.Text = "History";
            titleLable.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            titleLable.AutoSize = true;
            titleLable.Location = new System.Drawing.Point(360, 5);
            this.Controls.Add(titleLable);

                string trimmedExpression = operationDetails.Length > 7 ? operationDetails.Substring(0, 7) : operationDetails;
            if (!(operationDetails == Expression || operationDetails + "." == Expression))
            {


                newLabel.Text = $"{Expression} =\n {trimmedExpression}";
                newLabel.AutoSize = true;
                newLabel.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                newLabel.BorderStyle = BorderStyle.FixedSingle;
                newLabel.Name = $"Historylbl_{_labelCount}";
              
                
                this.historyPanel.Width = 300;
                newLabel.Location = new System.Drawing.Point(
                    5,
                    _nextLabelY
                );


                if (double.TryParse(operationDetails, out double resultValue))
                {
                    newLabel.Tag = resultValue;
                }
                newLabel.Click += new System.EventHandler(this.Historylbl_Click);
                if (this.historyPanel != null)
                {
                    this.historyPanel.Controls.Add(newLabel);
                    newLabel.AutoSize = true;
                    _nextLabelY += newLabel.Height + 5;
                    this.historyPanel.ScrollControlIntoView(newLabel);
                }
                else
                {
                    this.Controls.Add(newLabel);
                }

                _labelCount++;

            }

        }
        private void Historylbl_Click(object sender, EventArgs e)
        {
            int index = newLabel.Text.IndexOf('=');
            if (index > 0)
            {
                Results.Text = newLabel.Text.Substring(0, index - 1);
            }

        }

        private void sendNumbersAndOperations_Click(object sender, EventArgs e) {
            if (sender is Button btn) {
                if (Results.Text == "0") 
                    Results.Text = "";
                Results.Text += btn.Text;
            }
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Results.Text = "0";
        }

        private void ersbtn_Click(object sender, EventArgs e)
        {
            if (Results.Text.Length > 1)
                Results.Text = Results.Text.Remove(Results.Text.Length - 1);
            else
                Results.Text = "0";
            
        }

        private void Eqlbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string preExpression = Results.Text.ToString();
                Results.Text = new Calculator().Evaluate(Results.Text).ToString();
                this.CreateNewOperationLabel(Results.Text, ref preExpression);

            }
            catch (Exception)
            {
                Results.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Results.Text == "") {
                Results.Text = "";
            }
            else { 
                Results.Text += "²";
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            if (Results.Text == "0") {
                Results.Text = "√";
            }
            else { 
                Results.Text += "√";   
            }
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            if (Results.Text == "0")
            {
                Results.Text = "0.";
                return;
            }

            string lastNumber = Results.Text.Split(new char[] { '+', '-', '*', '/' }).Last();
            if (!lastNumber.Contains("."))
            {
                Results.Text += ".";
            }
        }
    }
}
