using AutoServiceManager.Data;
using AutoServiceManager.Interfaces;
using AutoServiceManager.Models;
using AutoServiceManager.Services;

// Головний простір імен програми
namespace AutoServiceManager
{
    // partial означає що клас розділений на 2 файли:
    // Form1.cs (логіка)
    // Form1.Designer.cs (інтерфейс)
    public partial class Form1 : Form
    {
        // Конструктор форми
        // Викликається при запуску програми
        public Form1()
        {
            InitializeComponent(); // створює всі кнопки та елементи GUI
        }

        // Об'єкт який відповідає за збереження та завантаження даних
        FileManager fileManager = new FileManager();

        // Сервіс для роботи з клієнтами (поки використовується мало)
        ClientService clientService = new ClientService();

        // Метод оновлення таблиці клієнтів
        // Перезавантажує DataGridView
        void RefreshClients()
        {
            // Скидаємо джерело даних
            dataGridClients.DataSource = null;

            // Прив'язуємо список клієнтів до таблиці
            dataGridClients.DataSource = fileManager.Clients;
        }

        // Кнопка додавання клієнта
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Enter data");

                return;
            }
            // Створюємо нового клієнта
            Client client = new Client
            {
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            // Додаємо клієнта у список
            fileManager.Clients.Add(client);

            // Оновлюємо таблицю
            RefreshClients();

            // Очищаємо текстові поля
            txtName.Clear();
            txtPhone.Clear();
        }

        // Кнопка збереження у файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Викликаємо метод Save з FileManager
            // data.json створиться у папці bin/debug
            fileManager.Save("data.json");
        }

        // Кнопка завантаження
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Завантажуємо список клієнтів із файлу
            fileManager.Load("data.json");

            // Оновлюємо таблицю
            RefreshClients();
        }

        // Просто оновлення таблиці
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshClients();
        }

       
    }
}