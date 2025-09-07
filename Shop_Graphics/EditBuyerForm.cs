using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Graphics
{
    public partial class EditBuyerForm : Form
    {
        private int _userId; 

        // Конструктор с параметром
        public EditBuyerForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        // Метод загрузки данных покупателя
        private void EditBuyerForm_Load(object sender, EventArgs e)
        {
            // 1. Проверка логина
            if (string.IsNullOrWhiteSpace(txtLoginEdit.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин.");
                return;
            }

            // 2. Проверка пароля
            if (txtPasswordEdit.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов.");
                return;
            }

            // 3. Имя — только буквы
            if (!Regex.IsMatch(txtFirstNameEdit.Text, @"^[А-Яа-яA-Za-z\-]+$"))
            {
                MessageBox.Show("Имя должно содержать только буквы.");
                return;
            }

            // 4. Фамилия — только буквы
            if (!Regex.IsMatch(txtLastNameEdit.Text, @"^[А-Яа-яA-Za-z\-]+$"))
            {
                MessageBox.Show("Фамилия должна содержать только буквы.");
                return;
            }

            // 5. Email c проверкой
            if (!Regex.IsMatch(txtEmailEdit.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный Email.");
                return;
            }

            // 6. Телефон — только цифры
            if (!Regex.IsMatch(txtPhoneNumberEdit.Text, @"^\d+$"))
            {
                MessageBox.Show("Телефон должен содержать только цифры.");
                return;
            }
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(txtLoginEdit.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordEdit.Text) ||
                string.IsNullOrWhiteSpace(txtFirstNameEdit.Text) ||
                string.IsNullOrWhiteSpace(txtLastNameEdit.Text) ||
                string.IsNullOrWhiteSpace(txtEmailEdit.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumberEdit.Text))
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Buyers WHERE user_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", _userId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtLoginEdit.Text = reader["login"].ToString();
                        txtPasswordEdit.Text = reader["password"].ToString();
                        txtFirstNameEdit.Text = reader["first_name"].ToString();
                        txtLastNameEdit.Text = reader["last_name"].ToString();
                        txtEmailEdit.Text = reader["email"].ToString();
                        txtPhoneNumberEdit.Text = reader["phone_number"].ToString();
                        dtpRegistrationDateEdit.Value = Convert.ToDateTime(reader["registration_date"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных покупателя: " + ex.Message);
                }
            }
        }

        // Метод сохранения изменений
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("BuyerUpdate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user_id", _userId);
                    cmd.Parameters.AddWithValue("@login", txtLoginEdit.Text);
                    cmd.Parameters.AddWithValue("@password", txtPasswordEdit.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstNameEdit.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastNameEdit.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailEdit.Text);
                    cmd.Parameters.AddWithValue("@phone_number", txtPhoneNumberEdit.Text);
                    cmd.Parameters.AddWithValue("@registration_date", dtpRegistrationDateEdit.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Изменения сохранены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении покупателя: " + ex.Message);
                }
            }
        }
    }
}
