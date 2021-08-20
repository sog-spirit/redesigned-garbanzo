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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = DataAccessLayer.Instance.GetClasses();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
