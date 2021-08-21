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
    public partial class Form1 : Form
    {
        private static Form1 _Instance;
        public static Form1 MainForm
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Form1();
                return _Instance;
            }
            private set { }
        }
        public Form1()
        {
            ProgramContext modelContext = new ProgramContext();
            
            InitializeComponent();
            LoadComboBox();
            RefreshDataGrid();
        }
        private void LoadComboBox()
        {
            comboBox_ListOfClass.Items.Clear();
            comboBox_ListOfClass.Items.Add(new ComboBoxItem()
            {
                Text = "Tat ca",
                Value = 0
            });
            foreach(Class @class in BusinessLogicLayer.Instance.GetClasses())
            {
                comboBox_ListOfClass.Items.Add(new ComboBoxItem()
                {
                    Text = @class.ClassName,
                    Value = @class.ClassID
                });
            }
            comboBox_ListOfClass.SelectedIndex = 0;

            comboBox_SortOrder.Items.AddRange(new ComboBoxItem[]
            {
                new ComboBoxItem{Text = "Sap xep theo ten tu A-Z", Value = 0},
                new ComboBoxItem{Text = "Sap xep theo ten tu Z-A", Value = 1},
                new ComboBoxItem{Text = "Sap xep tang dan theo ngay sinh", Value = 2},
                new ComboBoxItem{Text = "Sap xep giam dan theo ngay sinh", Value = 3}
            });
            comboBox_SortOrder.SelectedIndex = 0;
        }
        private void RefreshDataGrid()
        {
            int classID = ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value;
            string studentName = textBox_NameInput.Text;
            dataGridView1.DataSource = BusinessLogicLayer.Instance.GetStudents(studentName, classID);
        }
        private void button_Display_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            string studentID = "";
            form.Reciever(studentID);
            form.Show();
            RefreshDataGrid();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                Form2 form = new Form2();
                string studentID = dataGridView1.CurrentRow.Cells["StudentID"].Value.ToString();
                form.Reciever(studentID);
                form.Show();
                RefreshDataGrid();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                string studentID = dataGridView1.CurrentRow.Cells["StudentID"].Value.ToString();
                BusinessLogicLayer.Instance.DeleteStudent(studentID);
                RefreshDataGrid();
            }
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            int selectionIndex = ((ComboBoxItem)comboBox_SortOrder.SelectedItem).Value;
            switch(selectionIndex)
            {
                case 0:
                    dataGridView1.DataSource = BusinessLogicLayer.Instance.SortStudentViews(
                        StudentView.StudentNameASC, textBox_NameInput.Text, ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value);
                    break;
                case 1:
                    dataGridView1.DataSource = BusinessLogicLayer.Instance.SortStudentViews(
                        StudentView.StudentNameDES, textBox_NameInput.Text, ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value);
                    break;
                case 2:
                    dataGridView1.DataSource = BusinessLogicLayer.Instance.SortStudentViews(
                        StudentView.DOB_ASC, textBox_NameInput.Text, ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value);
                    break;
                case 3:
                    dataGridView1.DataSource = BusinessLogicLayer.Instance.SortStudentViews(
                        StudentView.DOB_DES, textBox_NameInput.Text, ((ComboBoxItem)comboBox_ListOfClass.SelectedItem).Value);
                    break;
                default:
                    break;
            }
        }
        private void button_ManageClass_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            RefreshDataGrid();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshDataGrid();
            LoadComboBox();
        }

    }
}
