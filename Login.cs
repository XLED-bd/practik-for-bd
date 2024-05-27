using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace test
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Host=localhost:5432;Username=postgres;Password=root;Database=bank";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id_employee FROM public.employees WHERE email = @Email AND password = @Password";
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);

                    var result_employee = cmd.ExecuteScalar();
                    if (result_employee != null)
                    {
                        var mainForm = new MainFormEmployee();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        cmd.CommandText = "SELECT id_user FROM public.users WHERE email = @Email AND password = @Password";
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);

                        var result_user = cmd.ExecuteScalar();
                        var reader = cmd.ExecuteReader();

                        if (result_user != null)
                        {

                            var mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }

                    
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }
    }
}
