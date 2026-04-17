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
            fileManager.Load("data.json");

            RefreshClients();

            dataGridCars.DataSource = null;
            dataGridOrders.DataSource = null;

            if (dataGridClients.Rows.Count > 0)
            {
                dataGridClients.Rows[0].Selected = true;

                var client = dataGridClients.Rows[0].DataBoundItem as Client;

                if (client != null)
                {
                    RefreshCars(client);

                    if (client.Cars.Count > 0)
                    {
                        RefreshOrders(client.Cars[0]);
                    }
                }
            }
        }

        // оновлення таблиці
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshClients();
        }

        void RefreshCars(Client? client)
        {
            if (client == null) return;

            dataGridCars.DataSource = null;
            dataGridCars.DataSource = client.Cars;
        }

        private void dataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridClients.CurrentRow == null)
                return;

            Client client = (Client)dataGridClients.CurrentRow.DataBoundItem;

            RefreshCars(client);
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (dataGridClients.CurrentRow == null)
            {
                MessageBox.Show("Select client");

                return;
            }

            if (txtBrand.Text == "" || txtModel.Text == "" || txtPlate.Text == "")
            {
                MessageBox.Show("Enter data");

                return;
            }

            Client client = (Client)dataGridClients.CurrentRow.DataBoundItem;

            Car car = new Car
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                PlateNumber = txtPlate.Text
            };

            client.Cars.Add(car);

            RefreshCars(client);
            MessageBox.Show($"Додано! Зараз у клієнта  авто");
            txtBrand.Clear();
            txtModel.Clear();
            txtPlate.Clear();
        }

        void RefreshOrders(Car? car)
        {
            if (car == null) return;
            dataGridOrders.DataSource = null;
            dataGridOrders.DataSource = car.Orders;

            dataGridOrders.Refresh(); 
        }

        private void dataGridCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow == null)
                return;

            Car car = (Car)dataGridCars.CurrentRow.DataBoundItem;

            RefreshOrders(car);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            if (txtPrice.Text == "" || cmbServiceType.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            if (dataGridCars.CurrentRow?.DataBoundItem == null)
                return;

            Car car = (Car)dataGridCars.CurrentRow.DataBoundItem;

            Service service;

            if (cmbServiceType.Text.Contains("Repair"))
            {
                service = new RepairService
                {
                    Name = "Repair",
                    Type = "Repair", 
                    BasePrice = decimal.Parse(txtPrice.Text),
                    Hours = int.Parse(txtHours.Text)
                };
            }
            else
            {
                service = new MaintenanceService
                {
                    Name = "Maintenance",
                    Type = "Maintenance", 
                    BasePrice = decimal.Parse(txtPrice.Text)
                };
            }

            Order order = new Order
            {
                Id = car.Orders.Count + 1,
                Date = DateTime.Now,
                Service = service
            };

            car.Orders.Add(order);

            RefreshOrders(car);

            txtPrice.Clear();
            txtHours.Clear();
        }



    }
}