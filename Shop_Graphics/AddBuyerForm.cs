using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Shop_Graphics
{
    public partial class AddBuyerForm : Form
    {
        public AddBuyerForm()
        {
            InitializeComponent();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            // Проверка логина
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин.");
                return;
            }

            // Проверка пароля
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов.");
                return;
            }

            // Имя — только буквы
            if (!Regex.IsMatch(txtFirstName.Text, @"^[А-Яа-яA-Za-z\-]+$"))
            {
                MessageBox.Show("Имя должно содержать только буквы.");
                return;
            }

            // Фамилия — только буквы
            if (!Regex.IsMatch(txtLastName.Text, @"^[А-Яа-яA-Za-z\-]+$"))
            {
                MessageBox.Show("Фамилия должна содержать только буквы.");
                return;
            }

            // Email c проверкой
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный Email.");
                return;
            }

            // Телефон — только цифры
            if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Телефон должен содержать только цифры.");
                return;
            }

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddBuyer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@registration_date", dtpRegistrationDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Покупатель успешно добавлен!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении покупателя: " + ex.Message);
                }
            }
        }
    }
}
