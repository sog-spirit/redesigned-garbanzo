
namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_SortOrder = new System.Windows.Forms.ComboBox();
            this.comboBox_ListOfClass = new System.Windows.Forms.ComboBox();
            this.textBox_NameInput = new System.Windows.Forms.TextBox();
            this.button_ManageClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lop";
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(426, 414);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(75, 23);
            this.button_Sort.TabIndex = 30;
            this.button_Sort.Text = "Sap xep";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(327, 414);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 29;
            this.button_Delete.Text = "Xoa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(221, 414);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(83, 23);
            this.button_Edit.TabIndex = 28;
            this.button_Edit.Text = "Chinh sua";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(120, 414);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 27;
            this.button_Add.Text = "Them";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(12, 414);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(75, 23);
            this.button_Display.TabIndex = 26;
            this.button_Display.Text = "Hien thi";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 366);
            this.dataGridView1.TabIndex = 25;
            // 
            // comboBox_SortOrder
            // 
            this.comboBox_SortOrder.FormattingEnabled = true;
            this.comboBox_SortOrder.Location = new System.Drawing.Point(552, 414);
            this.comboBox_SortOrder.Name = "comboBox_SortOrder";
            this.comboBox_SortOrder.Size = new System.Drawing.Size(236, 24);
            this.comboBox_SortOrder.TabIndex = 24;
            // 
            // comboBox_ListOfClass
            // 
            this.comboBox_ListOfClass.FormattingEnabled = true;
            this.comboBox_ListOfClass.Location = new System.Drawing.Point(74, 12);
            this.comboBox_ListOfClass.Name = "comboBox_ListOfClass";
            this.comboBox_ListOfClass.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ListOfClass.TabIndex = 23;
            // 
            // textBox_NameInput
            // 
            this.textBox_NameInput.Location = new System.Drawing.Point(552, 12);
            this.textBox_NameInput.Name = "textBox_NameInput";
            this.textBox_NameInput.Size = new System.Drawing.Size(236, 22);
            this.textBox_NameInput.TabIndex = 22;
            // 
            // button_ManageClass
            // 
            this.button_ManageClass.Location = new System.Drawing.Point(210, 12);
            this.button_ManageClass.Name = "button_ManageClass";
            this.button_ManageClass.Size = new System.Drawing.Size(115, 23);
            this.button_ManageClass.TabIndex = 33;
            this.button_ManageClass.Text = "Manage Class";
            this.button_ManageClass.UseVisualStyleBackColor = true;
            this.button_ManageClass.Click += new System.EventHandler(this.button_ManageClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ManageClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_SortOrder);
            this.Controls.Add(this.comboBox_ListOfClass);
            this.Controls.Add(this.textBox_NameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_SortOrder;
        private System.Windows.Forms.ComboBox comboBox_ListOfClass;
        private System.Windows.Forms.TextBox textBox_NameInput;
        private System.Windows.Forms.Button button_ManageClass;
    }
}

