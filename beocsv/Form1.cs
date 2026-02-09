using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.IO;


namespace beocsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           

        }
        List<Student> students = new List<Student>();
        string connStr = "Server=localhost;Port=3307;Database=schooldb;Uid=root;Pwd=;";


        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    students = csv.GetRecords<Student>().ToList();
                    dataGridView1.DataSource = students;
                }
            }
        }

        private void buttonSaveToDb_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                foreach (var s in students)
                {
                    string query = @"INSERT INTO Students (Id, Name, Email, Age)
                         VALUES (?Id, ?Name, ?Email, ?Age)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("?Id", s.Id);
                    cmd.Parameters.AddWithValue("?Name", s.Name);
                    cmd.Parameters.AddWithValue("?Email", s.Email);
                    cmd.Parameters.AddWithValue("?Age", s.Age);

                    cmd.ExecuteNonQuery();
                }
            }


            LoadFromDatabase();
        }
        private void LoadFromDatabase()
        {
            List<Student> dbStudents = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dbStudents.Add(new Student
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Email = reader.GetString("Email"),
                            Age = reader.GetInt32("Age")
                        });
                    }
                }
            }

            dataGridView1.DataSource = dbStudents;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = @"INSERT INTO Students (Name, Email, Age)
                         VALUES (@Name, @Email, @Age)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxAge.Text));

                cmd.ExecuteNonQuery();
            }
            try
            {
                // adatbázis / CSV művelet
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            LoadFromDatabase();
        }



    }
}
