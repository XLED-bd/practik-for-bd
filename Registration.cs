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
    public partial class RegForm : Form
    {
        private string connectionString = "Host=localhost:5432;Username=postgres;Password=root;Database=bank2";
        public RegForm()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string first_name = txt_firstName.Text;
            string second_name = txt_secondName.Text;
            string birth_date = txt_date.Text;
            string phone = txt_phone.Text;
            string passport = txt_passport.Text;
            string snils = txt_snils.Text;
            string inn = txt_inn.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try { 
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO public.users(first_name, second_name, birth_date, phone, passport, snils, inn, email, password) VALUES (@First_name , @Second_name , CAST( @Birth_date AS DATE), @Phone , @Passport , @Snils , @Inn , @Email , @Password)";


                        cmd.Parameters.AddWithValue("first_name", first_name);
                        cmd.Parameters.AddWithValue("second_name", second_name);
                        cmd.Parameters.AddWithValue("birth_date", birth_date);
                        cmd.Parameters.AddWithValue("phone", phone);
                        cmd.Parameters.AddWithValue("passport", passport);
                        cmd.Parameters.AddWithValue("snils", snils);
                        cmd.Parameters.AddWithValue("inn", inn);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);

                        var result_add_user = cmd.ExecuteScalar();
                        MessageBox.Show("Пользователь добавлен");
                        var loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();

                    } catch {

                        MessageBox.Show("Некорректные данные");

                    }


                }
            }

        }
    }
}
