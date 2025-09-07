using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Graphics
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmd;
        public Form1()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;
            conn = new SqlConnection(connStr);

            // Добавим всплывающую подсказку
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBoxProduct, "Изображение выбранного товара");
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //РАБОТА С МЕНЮ
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Отображение списка меню
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxActions.Items.Add("Покупатели");
            comboBoxActions.Items.Add("Товары");
            comboBoxActions.Items.Add("Склады");
            comboBoxActions.Items.Add("Заказы");
            comboBoxActions.Items.Add("Категории");
            comboBoxActions.Items.Add("Складские запасы");
            comboBoxActions.Items.Add("Товары по категориям");
            comboBoxActions.Items.Add("Статусы заказов");
            comboBoxActions.Items.Add("Содержимое заказов");
            comboBoxActions.Items.Add("История заказов");
            comboBoxActions.Items.Add("Выгрузить шаблон Excel(в разработке)");// Сделать!!!
            comboBoxActions.Items.Add("Загрузить шаблон Excel(в разработке)");// Сделать!!!
            // Пока не все
        }
        //*********************************************************************************

        //Отображение списка всех пользователей
        private void LoadBuyers()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Buyers", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Buyers");

                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = ds.Tables["Buyers"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке покупателей: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение списка всех Товаров
        private void LoadProducts()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Products", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Products");

                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = ds.Tables["Products"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке товаров: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение всех складов
        private void LoadWarehouses()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Warehouses", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Warehouses");
                dataGridView1.DataSource = ds.Tables["Warehouses"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке складов: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение всех категорий
        private void LoadCategories()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Categories", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Categories");
                dataGridView1.DataSource = ds.Tables["Categories"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке Категорий: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение остатков товаров на складах
        private void LoadWarehouseStock()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Warehouse_Stock", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Warehouse_Stock");
                dataGridView1.DataSource = ds.Tables["Warehouse_Stock"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке Остатков по складам: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение продуктов по категориям
        private void LoadProductCategories()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Products_categories", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Products_categories");
                dataGridView1.DataSource = ds.Tables["Products_categories"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке продуктов по категориям: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение статусов заказов
        private void LoadOrderStatuses()
        {
            try
            {
                da = new SqlDataAdapter("SELECT status_id AS 'ID', status_name AS 'Статус', description AS 'Описание' FROM Order_statuses", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Order_statuses");
                dataGridView1.DataSource = ds.Tables["Order_statuses"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке статусов заказов: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение всех заказов
        private void LoadOrders()
        {
            try
            {
                da = new SqlDataAdapter("SELECT order_id AS 'ID Заказа', user_id AS 'ID покупателя', order_date AS 'Дата покупки', TotalAmount AS 'Общая сумма', status_id AS 'ID статуса', delivery_address AS 'Адрес доставки' FROM Orders", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Orders");
                dataGridView1.DataSource = ds.Tables["Orders"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке заказов: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение заказов с продуктами, входящими в них
        private void LoadOrderProducts()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Orders_products", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Orders_products");
                dataGridView1.DataSource = ds.Tables["Orders_products"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке продуктов в заказе: " + ex.Message);
            }
        }
        //*********************************************************************************

        //Отображение истории заказов
        private void LoadOrderHistory()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Order_history", conn);
                cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Order_history");
                dataGridView1.DataSource = ds.Tables["Order_history"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке истории заказов: " + ex.Message);
            }
        }
        //*********************************************************************************


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //РАБОТА С dataGridView
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // Основная таблица dataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (comboBoxActions.SelectedItem?.ToString() != "Товары") return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["product_id"].Value);
            LoadProductImage(productId);

            //Решил добавить отобжаенеи имени выбранного товара в textBox - так наверняка видно, выбран товар или нет
            string name = dataGridView1.SelectedRows[0].Cells["Name"].Value?.ToString();
            textBoxSelectedProduct.Text = name;
        }
        //*********************************************************************************

        //Выпадающий список с командами рабочие
        private void comboBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxActions.SelectedItem?.ToString();

            switch (selected)
            {
                case "Покупатели":
                    LoadBuyers();
                    break;
                case "Товары":
                    LoadProducts();
                    break;
                case "Склады":
                    LoadWarehouses();
                    break;
                case "Категории":
                    LoadCategories();
                    break;
                case "Складские запасы":
                    LoadWarehouseStock();
                    break;
                case "Товары по категориям":
                    LoadProductCategories();
                    break;
                case "Статусы заказов":
                    LoadOrderStatuses();
                    break;
                case "Заказы":
                    LoadOrders();
                    break;
                case "Содержимое заказов":
                    LoadOrderProducts();
                    break;
                case "История заказов":
                    LoadOrderHistory();
                    break;

                //case "Выгрузить шаблон Excel":
                //    ExportBuyersTemplate(); // Метод выгрузки шаблона
                //    break;

                //case "Загрузить шаблон Excel":
                //    ImportBuyersFromExcel(); // Метод загрузки из Excel
                //    break;
            }
        }
        //*********************************************************************************


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //ДОБАВЛЕНИЕ ПОКУПАТЕЛЯ
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBuyerForm form = new AddBuyerForm();
            form.ShowDialog();

            // После закрытия формы перезагружаем список покупателей:
            if (comboBoxActions.SelectedItem?.ToString() == "Покупатели")
            {
                LoadBuyers();
            }
        }
        //*********************************************************************************


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //УДАЛЕНИЕ ПОКУПАТЕЛЯ
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Метод для удаление покупателя (пользователя)
        private void DeleteBuyer(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("BuyerDelete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Покупатель успешно удалён!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении покупателя: " + ex.Message);
                }
            }
        }
        


        //Удаление покупателя (пользователя) при нажатии на кнопку
        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Предполагаем, что ID покупателя находится в первом столбце (index 0)
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Подтверждение
                var result = MessageBox.Show("Вы действительно хотите удалить этого покупателя?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteBuyer(userId);
                    // Обновим таблицу покупателей после удаления
                    LoadBuyers();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите покупателя для удаления.");
            }
        }
        //*********************************************************************************


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //ИЗМЕНЕНИЕ ПОКУПАТЕЛЯ
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //Обработка события при нажатии кнопки "Изменить"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
               if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите покупателя для редактирования.");
                    return;
                }

                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                EditBuyerForm editForm = new EditBuyerForm(userId);
                editForm.ShowDialog();

                 LoadBuyers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при попытке редактирования: " + ex.Message);
            }
        }
        //*********************************************************************************


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //РАБОТА С КАРТИНКАМИ
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //Добавление картинки при нажатии на кнопку "Загрузить"
        private void btnAddProductImage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар для добавления изображения.");
                return;
            }

             int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Изображения | *.bmp; *.png; *.jpeg; *.jpg; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                byte[] imageBytes = CreateThumbnail(filename); 

                string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Products SET Picture = @picture WHERE product_id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = imageBytes;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Изображение успешно добавлено к товару.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении изображения: " + ex.Message);
                    }
                }
            }
        }

        //Метод для создания уменьшенного изображения
        private byte[] CreateThumbnail(string path)
        {
            try
            {
                Image img = Image.FromFile(path);
                int maxWidth = 300, maxHeight = 300;
                double ratioX = (double)maxWidth / img.Width;
                double ratioY = (double)maxHeight / img.Height;
                double ratio = Math.Min(ratioX, ratioY);
                int newWidth = (int)(img.Width * ratio);
                int newHeight = (int)(img.Height * ratio);

                Image thumbnail = new Bitmap(newWidth, newHeight);
                Graphics g = Graphics.FromImage(thumbnail);
                g.DrawImage(img, 0, 0, newWidth, newHeight);

                using (MemoryStream ms = new MemoryStream())
                {
                    thumbnail.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при обработке изображения.");
                return null;
            }
        }

        //Метод для отображения изображения

        private void LoadProductImage(int productId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Picture FROM Products WHERE product_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", productId);

                    object result = cmd.ExecuteScalar();

                    // Отладка: выводим сообщение, получили ли что-нибудь из базы
                    if (result == null)
                    {
                        MessageBox.Show("Значение из базы: null");
                    }
                    else if (result == DBNull.Value)
                    {
                        MessageBox.Show("Значение из базы: DBNull (пустое изображение)");
                    }
                    else if (result is byte[])
                    {
                        MessageBox.Show("Изображение получено из базы, начинаем загрузку...");

                        using (MemoryStream ms = new MemoryStream((byte[])result))
                        {
                            pictureBoxProduct.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Тип данных в базе не byte[]. Проверь структуру поля Picture.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }
        

        //Удаление изображения при нажатии на кнопку
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (comboBoxActions.SelectedItem?.ToString() != "Товары")
            {
                MessageBox.Show("Удаление доступно только для товаров.");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар.");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            DeleteProductImage(productId);
        }

        //Метод для удаления изображения
        private void DeleteProductImage(int productId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop_db"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DeleteProductImage", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_id", productId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Изображение удалено успешно!");

                    pictureBoxProduct.Image = null; // Очистить PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении изображения: " + ex.Message);
                }
            }
        }
        //*********************************************************************************






        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            this.Close();
            // Тут я просто закрываю форму
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            // Пока что тоже просто закрываем, но потом добавлю сохранение
            this.Close();
        }

    }
}
