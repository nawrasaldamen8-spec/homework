using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string AddIdUser(TextBox TextID) { 
            string studentId = TextID.Text.Trim();
            if (string.IsNullOrEmpty(Idtxt.Text))
            {
                MessageBox.Show("Please enter a Student ID.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            return studentId;
        }
        private string AddLang(CheckBox cSharp, CheckBox Java, CheckBox python) {
            string Language = "";
            if (cSharp.Checked) Language += cSharp.Text + " / ";
            if (Java.Checked) Language += Java.Text + " / ";
            if (python.Checked) Language += python.Text + " / ";
          
            Language = Language.TrimEnd(' ', '/');


            return Language;
        }
        private string AddMajor(RadioButton cs, RadioButton cn, RadioButton cys) {
            
            string MajorStr = "";
            if (cs.Checked) MajorStr = cs.Text;
            if (cn.Checked) MajorStr = cn.Text;
            if (cys.Checked) MajorStr = cys.Text;
            
            return MajorStr;
        }

        private string AddGender(RadioButton Male, RadioButton Female) {

            string GenderStr = "";
            if(Male.Checked) GenderStr = Male.Text;
            if (Female.Checked) GenderStr = Female.Text;
           

            return GenderStr;
        }

        private string AddYear(ComboBox choice) {
            if(choice.SelectedIndex == -1)             {
                return "Not Specified";
            }
            return choice.SelectedItem.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Major_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddRecored_Click(object sender, EventArgs e)
        {
            AddIdUser(Idtxt);
            if (Idtxt.Text != string.Empty ) { 
                dataGridView1.Rows.Add(Idtxt.Text,
                    AddMajor(radioButton1,radioButton2,radioButton3),
                    AddGender(MaleRad,FemaleRad),
                    AddLang(checkBox1, checkBox2, checkBox3),
                    AddYear(comboBox1));
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            MaleRad.Checked = false;
            FemaleRad.Checked = false;
            comboBox1.SelectedIndex = -1;

            Idtxt.Clear();

            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
