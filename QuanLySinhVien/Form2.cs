using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form2 : Form
    {
        public delegate void Del(string input);
        public Del Reciever;
        string studentID = "";
        private void RecieveData(string input)
        {
            studentID = input;
        }
        public Form2()
        {
            Reciever = new Del(RecieveData);
            InitializeComponent();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            foreach (Class @class in BusinessLogicLayer.Instance.GetClasses())
            {
                comboBox_ListOfClass.Items.Add(new ComboBoxItem()
                {
                    Text = @class.ClassName,
                    Value = @class.ClassID
                });
            }
            comboBox_ListOfClass.SelectedIndex = 0;
            radioButton_Male.Checked = true;
        }
        private void SetForm()
        {
            Student s = BusinessLogicLayer.Instance.GetStudent(studentID);
            List<Class> classes = BusinessLogicLayer.Instance.GetClasses();
            string className = "";

            foreach (Class @class in classes)
            {
                if (@class.ClassID == s.ClassID)
                    className = @class.ClassName;
            }
            textBox_StudentID.Text = s.StudentID;
            textBox_StudentName.Text = s.StudentName;
            dateTimePicker1.Value = s.DOB;
            if (s.Gender)
                radioButton_Male.Checked = true;
            else
                radioButton_Female.Checked = true;
            comboBox_ListOfClass.SelectedIndex = comboBox_ListOfClass.FindString(className);
        }
        private Student ReturnStudent()
        {
            Student student = new Student();
            student.StudentID = textBox_StudentID.Text;
            student.StudentName = textBox_StudentName.Text;
            if (radioButton_Male.Checked)
                student.Gender = true;
            else
                student.Gender = false;
            student.DOB = dateTimePicker1.Value;
            student.ClassID = ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value;
            return student;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (studentID == "")
            {
                if (textBox_StudentID.Text == "" || textBox_StudentName.Text == "")
                {
                    MessageBox.Show("Vui long nhap du thong tin", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (BusinessLogicLayer.Instance.StudentIsExist(textBox_StudentID.Text))
                {
                    MessageBox.Show("Sinh vien " + textBox_StudentID.Text + " da ton tai trong CSDL", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                BusinessLogicLayer.Instance.AddStudent(ReturnStudent());
            }
            else
            {
                BusinessLogicLayer.Instance.EditStudent(ReturnStudent());
            }
            this.Dispose();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(studentID != "")
            {
                SetForm();
                textBox_StudentID.Enabled = false;
            }
        }
    }
}
