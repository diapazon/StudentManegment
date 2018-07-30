namespace SchoolManagment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddClasses = new System.Windows.Forms.Button();
            this.ShowClasses = new System.Windows.Forms.Button();
            this.AddTeachers = new System.Windows.Forms.Button();
            this.ShowTeachers = new System.Windows.Forms.Button();
            this.myDBDataSet = new SchoolManagment.MyDBDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new SchoolManagment.MyDBDataSetTableAdapters.TeachersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDBDataSet1 = new SchoolManagment.MyDBDataSet1();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new SchoolManagment.MyDBDataSet1TableAdapters.ClassesTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Count of Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name of Teachers";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(495, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.teacherIDDataGridViewTextBoxColumn,
            this.studentCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.teachersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(363, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // AddClasses
            // 
            this.AddClasses.Location = new System.Drawing.Point(37, 176);
            this.AddClasses.Name = "AddClasses";
            this.AddClasses.Size = new System.Drawing.Size(75, 23);
            this.AddClasses.TabIndex = 10;
            this.AddClasses.Text = "Add";
            this.AddClasses.UseVisualStyleBackColor = true;
            this.AddClasses.Click += new System.EventHandler(this.AddClasses_Click);
            // 
            // ShowClasses
            // 
            this.ShowClasses.Location = new System.Drawing.Point(154, 176);
            this.ShowClasses.Name = "ShowClasses";
            this.ShowClasses.Size = new System.Drawing.Size(75, 23);
            this.ShowClasses.TabIndex = 11;
            this.ShowClasses.Text = "Show";
            this.ShowClasses.UseVisualStyleBackColor = true;
            // 
            // AddTeachers
            // 
            this.AddTeachers.Location = new System.Drawing.Point(363, 176);
            this.AddTeachers.Name = "AddTeachers";
            this.AddTeachers.Size = new System.Drawing.Size(75, 23);
            this.AddTeachers.TabIndex = 12;
            this.AddTeachers.Text = "Add";
            this.AddTeachers.UseVisualStyleBackColor = true;
            this.AddTeachers.Click += new System.EventHandler(this.AddTeachers_Click);
            // 
            // ShowTeachers
            // 
            this.ShowTeachers.Location = new System.Drawing.Point(512, 176);
            this.ShowTeachers.Name = "ShowTeachers";
            this.ShowTeachers.Size = new System.Drawing.Size(75, 23);
            this.ShowTeachers.TabIndex = 13;
            this.ShowTeachers.Text = "Show";
            this.ShowTeachers.UseVisualStyleBackColor = true;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.myDBDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // myDBDataSet1
            // 
            this.myDBDataSet1.DataSetName = "MyDBDataSet1";
            this.myDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.myDBDataSet1;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "teacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "teacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // studentCountDataGridViewTextBoxColumn
            // 
            this.studentCountDataGridViewTextBoxColumn.DataPropertyName = "studentCount";
            this.studentCountDataGridViewTextBoxColumn.HeaderText = "studentCount";
            this.studentCountDataGridViewTextBoxColumn.Name = "studentCountDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 433);
            this.Controls.Add(this.ShowTeachers);
            this.Controls.Add(this.AddTeachers);
            this.Controls.Add(this.ShowClasses);
            this.Controls.Add(this.AddClasses);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddClasses;
        private System.Windows.Forms.Button ShowClasses;
        private System.Windows.Forms.Button AddTeachers;
        private System.Windows.Forms.Button ShowTeachers;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MyDBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private MyDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private MyDBDataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCountDataGridViewTextBoxColumn;
    }
}

