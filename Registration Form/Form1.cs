using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool validateElement(TextBox text, string msg) { 
        
            if (string.IsNullOrEmpty(text.Text)) {
                    errorProvider1.SetError(text,msg);
                return false;
            }
            errorProvider1.SetError(text, "");
            return true;
        }
        private bool validation() {
            errorProvider1.Clear();
        bool isValid = true;
          isValid &=  validateElement(txtName,"Name is required");
          isValid &=  validateElement(txtEmail,"Email is required");
          isValid &= validateElement(txtPassword, "Password is required");
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validation()) {
                string phone = txtPhone.Text == string.Empty ? "- - -" : txtPhone.Text;
                string Address = txtAddress.Text == string.Empty ? "- - -" : txtAddress.Text;
                string details = $"Name: {txtName.Text}\nEmail: {txtEmail.Text}\nPassword: {txtPassword.Text}\nPhone: {phone}\nAddress: {Address}";
                MessageBox.Show(details, "Data is submited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fills required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            lblOptional1.BackColor = Color.Green;
            lblCountry.Visible = true;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            lblOptional1.BackColor = Color.FromArgb(26, 26, 26);
            
            lblCountry.Visible = false;
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            lblOptional2.BackColor = Color.Green;

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            lblOptional2.BackColor = Color.FromArgb(26, 26, 26);
        }
    }
}
