using AutoServiceManager.Data;
using AutoServiceManager.Models;
using System.ComponentModel;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace AutoServiceManager
{
    // Partial class – виконання вимоги курсової (розділення класу на кілька файлів)
    public partial class Form1 : Form
    {
        
        bool isLoading = false;

        public Form1()
        {
            isLoading = true;

            InitializeComponent(); // GUI WinForms – виконання вимоги курсової

            // Робота з файлами – автоматичне завантаження JSON
            if (File.Exists("data.json"))
            {
                fileManager.Load("data.json");
                RefreshClients();
            }

            // Події GUI
            dataGridClients.SelectionChanged -= dataGridClients_SelectionChanged;
            dataGridCars.SelectionChanged -= dataGridCars_SelectionChanged;

            // Налаштування таблиць
            dataGridClients.AllowUserToAddRows = false;
            dataGridCars.AllowUserToAddRows = false;
            dataGridOrders.AllowUserToAddRows = false;

            dataGridClients.DataSource = null;
            dataGridCars.DataSource = null;
            dataGridOrders.DataSource = null;

            dataGridCars.MultiSelect = false;
            dataGridClients.MultiSelect = false;

            dataGridClients.SelectionChanged += dataGridClients_SelectionChanged;
            dataGridCars.SelectionChanged += dataGridCars_SelectionChanged;

            isLoading = false;

            if (File.Exists("data.json"))
            {
                fileManager.Load("data.json");
                RefreshClients();
            }
        }

        // Вимога до курсової - Агрегація – форма використовує об’єкт FileManager
        FileManager fileManager = new FileManager();

        // Оновлення клієнтів
        void RefreshClients()
        {
            dataGridClients.DataSource = null;
            dataGridClients.DataSource = fileManager.Clients;

            if (dataGridClients.Rows.Count > 0)
                dataGridClients_SelectionChanged(this, EventArgs.Empty);
        }

        // ДОДАТИ КЛІЄНТА
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            // Створення об'єкта класу Client
            Client client = new Client
            {
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            fileManager.Clients.Add(client); // Вимога до курсової - Узагальнена колекція List<Client>

            RefreshClients();

            int index = dataGridClients.Rows.Count - 1;

            if (index >= 0)
            {
                dataGridClients.ClearSelection();
                dataGridClients.Rows[index].Selected = true;
            }

            ClearClientFields();
        }

        // Видалення клієнта
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridClients.CurrentRow?.DataBoundItem is not Client client)
                return;

            DialogResult result = MessageBox.Show(
                "Delete selected client?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            fileManager.Clients.Remove(client);

            RefreshClients();
            dataGridCars.DataSource = null;
            dataGridOrders.DataSource = null;
        }

        // Збереження у файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            fileManager.Save("data.json");  // Вимога до курсової - Робота з файлами
        }

        // Оновлення машин
        void RefreshCars(Client? client)
        {
            isLoading = true;

            dataGridCars.DataSource = null;

            if (client != null && client.Cars != null)
            {
                dataGridCars.DataSource = client.Cars;
            }

            isLoading = false;
        }

        // ДОДАТИ МАШИНУ
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (dataGridClients.CurrentRow?.DataBoundItem is not Client client)
            {
                MessageBox.Show("Select client");
                return;
            }

            if (txtBrand.Text == "" || txtModel.Text == "" || txtPlate.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            Car car = new Car
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                PlateNumber = txtPlate.Text
            };

            // Агрегація – Client містить Cars
            client.Cars.Add(car);

            RefreshCars(client);

            int index = dataGridCars.Rows.Count - 1;

            if (index >= 0)
            {
                dataGridCars.ClearSelection();
                dataGridCars.Rows[index].Selected = true;
            }

            ClearCarFields();
        }

        // Видалення машини
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dataGridClients.CurrentRow?.DataBoundItem is not Client client)
                return;

            if (dataGridCars.CurrentRow?.DataBoundItem is not Car car)
                return;

            DialogResult result = MessageBox.Show(
                "Delete selected car?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            client.Cars.Remove(car);

            RefreshCars(client);
            dataGridOrders.DataSource = null;
        }

        // Оновлення замовлень
        void RefreshOrders(Car? car)
        {
            if (car == null) return;

            if (car.Orders == null)
                car.Orders = new BindingList<Order>(); // Вимога до курсової - Узагальнена колекція

            isLoading = true;

            dataGridOrders.DataSource = null;
            dataGridOrders.DataSource = car.Orders;

            isLoading = false;
        }

        // ДОДАТИ ЗАМОВЛЕННЯ
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "" || cmbServiceType.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            if (dataGridCars.CurrentRow?.DataBoundItem is not Car car)
            {
                MessageBox.Show("Select car");
                return;
            }

            Service service; // Поліморфізм – базовий тип

            // Обробка виняткових ситуацій через перевірку вводу
            bool isPriceValid = decimal.TryParse(txtPrice.Text, out decimal price);
            bool isHoursValid = int.TryParse(txtHours.Text, out int hours);

            if (!isPriceValid)
            {
                MessageBox.Show("Enter correct price");
                return;
            }

            if (cmbServiceType.Text.Contains("Repair"))
            {
                if (!isHoursValid)
                {
                    MessageBox.Show("Enter correct hours");
                    return;
                }

                // Наслідування + поліморфізм
                service = new RepairService
                {
                    Name = "Repair",
                    Type = "Repair",
                    BasePrice = price,
                    Hours = hours
                };
            }
            else
            {
                service = new MaintenanceService
                {
                    Name = "Maintenance",
                    Type = "Maintenance",
                    BasePrice = price
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
            ClearOrderFields();
        }

        // Видалення замовлення
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow?.DataBoundItem is not Car car)
                return;

            if (dataGridOrders.CurrentRow?.DataBoundItem is not Order order)
                return;

            DialogResult result = MessageBox.Show(
                "Delete selected order?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            car.Orders.Remove(order);
            RefreshOrders(car);
        }

        // Подія зміни клієнта
        private void dataGridClients_SelectionChanged(object? sender, EventArgs e)
        {
            if (isLoading) return;

            if (dataGridClients.CurrentRow?.DataBoundItem is Client selectedClient)
            {
                RefreshCars(selectedClient);

                dataGridOrders.DataSource = null;

                if (dataGridCars.Rows.Count > 0)
                {
                    dataGridCars.CurrentCell = dataGridCars.Rows[0].Cells[0];
                }
            }
        }

        // Подія зміни машини
        private void dataGridCars_SelectionChanged(object? sender, EventArgs e)
        {
            if (isLoading) return;

            if (dataGridCars.CurrentRow?.DataBoundItem is Car selectedCar)
            {
                RefreshOrders(selectedCar);
            }
            else
            {
                dataGridOrders.DataSource = null;
            }
        }

        // Пошук клієнта
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var filtered = (from c in fileManager.Clients
                            where c.Name.ToLower().Contains(searchText.ToLower()) // Вимога до курсової LINQ 
                            select c).ToList();

            dataGridClients.DataSource = null;
            dataGridClients.DataSource = filtered;
        }

        // Показати всіх
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshClients();
            txtSearch.Clear();
        }

        // Закриття форми
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to save changes?",
                "Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fileManager.Save("data.json");
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

