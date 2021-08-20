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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_ClassIDInput.Text == "" || textBox_ClassNameInput.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (BusinessLogicLayer.Instance.ClassIsExist(Convert.ToInt32(textBox_ClassIDInput.Text), textBox_ClassNameInput.Text.ToLower()))
            {
                MessageBox.Show("Lop da ton tai. Ten lop va ma lop phai khong trung lap danh sach!", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void textBox_ClassIDInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
