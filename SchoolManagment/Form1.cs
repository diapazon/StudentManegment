using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddClasses_Click(object sender, EventArgs e)
        {
            var _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c: \users\toshiba\documents\visual studio 2017\Projects\SchoolManagment\SchoolManagment\DB\MyDB.mdf;Integrated Security=True";
            var _connect = new SqlConnection(_connectionString);
            _connect.Open();
            var _className = textBox1.Text;
            var _studentCount = textBox2.Text;
            var _teacher = comboBox1.Text;
            var _insertQuery = "INSERT INTO Classes(name,studentCount,teacherID) VALUES ('" + _className +"','"+ _studentCount + "',(select Id from Teachers where name ='"+ _teacher +"'))";
            var _insertCommand = new SqlCommand(_insertQuery, _connect);
            if (_insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("new category added");

            }
            _connect.Close();
        }

        private void AddTeachers_Click(object sender, EventArgs e)
        {
            var _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c: \users\toshiba\documents\visual studio 2017\Projects\SchoolManagment\SchoolManagment\DB\MyDB.mdf;Integrated Security=True";
            var _connect = new SqlConnection(_connectionString);
            _connect.Open();
            var _teacherName = textBox3.Text;
           
            
            var _insertQuery = "INSERT INTO Teachers(name) VALUES ('" + _teacherName + "')";
            var _insertCommand = new SqlCommand(_insertQuery, _connect);
            _insertCommand.ExecuteNonQuery();
          
            _connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.myDBDataSet1.Classes);
            // TODO: This line of code loads data into the 'myDBDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.myDBDataSet.Teachers);

        }
    }
}
