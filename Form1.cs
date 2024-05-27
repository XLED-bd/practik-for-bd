using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class ClientsForm : Form
    {
        private string connectionString = "Host=localhost:5432;Username=postgres;Password=root;Database=bank";
        private int status = 0;

        public ClientsForm()
        {
            InitializeComponent();
            LoadDataWithIndex();
        }

        private void LoadDataWithIndex()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM users;", conn);
                var reader = cmd.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void LoadDataWithoutIndex()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT first_name, second_name, birth_date, phone, passport, snils, inn, email, password FROM users;", conn);
                var reader = cmd.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                LoadDataWithoutIndex(); button1.Text = "Показать индексы"; ++status;
            }
            else { LoadDataWithIndex(); button1.Text = "Убрать индексы"; --status; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainForm = new MainFormEmployee();
            mainForm.Show();
            this.Hide();
        }
    }
}
