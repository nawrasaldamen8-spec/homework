using System;
using System.Windows.Forms;

namespace Selection_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        class Student
        {
            public string Id, Major, Gender, Language, Year, Date;

            public Student(string id, string major, string gender, string language, string year)
            {
                Id = id;
                Major = major;
                Gender = gender;
                Language = language;
                Year = year;
                Date = DateTime.Now.ToString("yyyy/MM/dd");
            }

            
            public static Student FromForm(Form1 frm)
            {
                string major = frm.radioButton1.Checked ? "CS" :
                               frm.radioButton2.Checked ? "CN" :
                               frm.radioButton3.Checked ? "CYS" : "Not Entered";

                string gender = frm.MaleRad.Checked ? "Male" :
                                frm.FemaleRad.Checked ? "Female" : "Not Entered";

                string language = "";
                if (frm.checkBox1.Checked) language += frm.checkBox1.Text + " / ";
                if (frm.checkBox2.Checked) language += frm.checkBox2.Text + " / ";
                if (frm.checkBox3.Checked) language += frm.checkBox3.Text + " / ";
                language = string.IsNullOrEmpty(language) ? "Not Entered" : language.TrimEnd(' ', '/');

                string year = frm.comboBox1.SelectedIndex == -1 ? "Not Entered" : frm.comboBox1.SelectedItem.ToString();

                return new Student(frm.Idtxt.Text, major, gender, language, year);
            }
        }

        class StudentGenerator
        {
            private Random rand = new Random();
            private string[] majors = { "CS", "CN", "CYS" };
            private string[] languages = { "C#", "Java", "Python" };
            private string[] years = { "First", "Second", "Third", "Fourth" };

            public Student Generate(int orderId)
            {
                return new Student(
                    orderId.ToString(),
                    majors[rand.Next(majors.Length)],
                    rand.Next(2) == 0 ? "Male" : "Female",
                    languages[rand.Next(languages.Length)],
                    years[rand.Next(years.Length)]
                );
            }
        }

        private StudentGenerator generator = new StudentGenerator();
        private bool showDetails = true;

        private bool IsIdValid()
        {
            if (string.IsNullOrWhiteSpace(Idtxt.Text))
            {
                MessageBox.Show("Please enter a Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AddStudentToGrid(Student s)
        {
            dataGridView1.Rows.Add(s.Id, s.Major, s.Gender, s.Language, s.Year, s.Date);
        }

        private void ShowSuccess(Student s)
        {
            if (!showDetails) return;

            DialogResult result = MessageBox.Show($@"Record Added Successfully
Id: {s.Id}
Major: {s.Major}
Gender: {s.Gender}
Language(s): {s.Language}
Year: {s.Year}
Date: {s.Date}",
                "Success",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                showDetails = false;
            }
        }

        private void AddRecored_Click(object sender, EventArgs e)
        {
            if (!IsIdValid()) return;

            Student s = Student.FromForm(this);
            AddStudentToGrid(s);
            ShowSuccess(s);
            ResetForm();
            countLbl.Text = "Count: " + dataGridView1.RowCount.ToString();
        }

        private void ResetForm()
        {
            Idtxt.Clear();
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            MaleRad.Checked = false;
            FemaleRad.Checked = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            countLbl.Text = "Count: ";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void AddRandomUsers()
        {
            int orderId = dataGridView1.Rows.Count + 1;
            Student s = generator.Generate(orderId);
            AddStudentToGrid(s);
            ShowSuccess(s);
        }

        private void RandBtn_Click(object sender, EventArgs e)
        {
            showDetails = true;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                AddRandomUsers();
            }
            countLbl.Text = "Count: " + dataGridView1.RowCount.ToString();
        }

    }
}
