using AutoServiceManager.Data;
using AutoServiceManager.Models;
using System.ComponentModel;

namespace AutoServiceManager
{
    public partial class Form1 : Form
    {
        // прапорець щоб блокувати події під час оновлення таблиць
        bool isLoading = false;

        public Form1()
        {
            isLoading = true;

            InitializeComponent();

            //  ВІДКЛЮЧАЄМО події
            dataGridClients.SelectionChanged -= dataGridClients_SelectionChanged;
            dataGridCars.SelectionChanged -= dataGridCars_SelectionChanged;

            // налаштування таблиць
            dataGridClients.AllowUserToAddRows = false;
            dataGridCars.AllowUserToAddRows = false;
            dataGridOrders.AllowUserToAddRows = false;

            // можна навіть почистити
            dataGridClients.DataSource = null;
            dataGridCars.DataSource = null;
            dataGridOrders.DataSource = null;

            dataGridCars.MultiSelect = false;
            dataGridClients.MultiSelect = false;
            // ВКЛЮЧАЄМО назад
            dataGridClients.SelectionChanged += dataGridClients_SelectionChanged;
            dataGridCars.SelectionChanged += dataGridCars_SelectionChanged;

            isLoading = false;
        }

        // менеджер для роботи з файлом
        FileManager fileManager = new FileManager();


        // оновлення клієнтів
        void RefreshClients()
        {
            dataGridClients.DataSource = null;
            dataGridClients.DataSource = fileManager.Clients;
            if (dataGridClients.Rows.Count > 0) 
    dataGridClients_SelectionChanged(this, EventArgs.Empty);
        }

        //  ДОДАТИ КЛІЄНТА
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            Client client = new Client
            {
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            fileManager.Clients.Add(client);

            RefreshClients();

            // автоматично вибираємо нового клієнта
            int index = dataGridClients.Rows.Count - 1;

            if (index >= 0)
            {
                dataGridClients.ClearSelection();
                dataGridClients.Rows[index].Selected = true;
            }

            txtName.Clear();
            txtPhone.Clear();
        }

        // SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            fileManager.Save("data.json");
        }

        // LOAD
        private void btnLoad_Click(object sender, EventArgs e)
        {
            fileManager.Load("data.json");
            RefreshClients();

            // ПРИМУСОВО вибираємо першого клієнта після завантаження
            if (dataGridClients.Rows.Count > 0)
            {
                isLoading = false; // переконайтесь, що прапорець дозволяє події
                dataGridClients.Rows[0].Selected = true;

                // Викликаємо метод оновлення вручну, якщо подія не спрацювала
                if (dataGridClients.Rows[0].DataBoundItem is Client firstClient)
                {
                    RefreshCars(firstClient);
                }
            }
        }

        // оновлення машин
        void RefreshCars(Client? client)
        {
            isLoading = true; // Блокуємо зайві події
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

            client.Cars.Add(car);

            RefreshCars(client);

            // вибираємо нову машину
            int index = dataGridCars.Rows.Count - 1;

            if (index >= 0)
            {
                dataGridCars.ClearSelection();
                dataGridCars.Rows[index].Selected = true;
            }

            txtBrand.Clear();
            txtModel.Clear();
            txtPlate.Clear();
        }

        // оновлення замовлень
        void RefreshOrders(Car? car)
        {
            if (car == null) return;

            
            if (car.Orders == null)
                car.Orders = new BindingList<Order>();

            isLoading = true;

            dataGridOrders.DataSource = null;
            dataGridOrders.DataSource = car.Orders;

            isLoading = false;
        }

        //  ДОДАТИ ЗАМОВЛЕННЯ
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

        //  зміна клієнта
        private void dataGridClients_SelectionChanged(object? sender, EventArgs e)
        {
            if (isLoading) return;

            // Отримуємо поточний вибраний об'єкт клієнта
            if (dataGridClients.CurrentRow?.DataBoundItem is Client selectedClient)
            {
                RefreshCars(selectedClient);

                // Одразу після зміни клієнта і завантаження машин — 
                // скидаємо таблицю замовлень, бо машину ще не вибрано
                dataGridOrders.DataSource = null;

                // Автоматично вибираємо першу машину клієнта, щоб замовлення теж підтягнулися
                if (dataGridCars.Rows.Count > 0)
                {
                    dataGridCars.CurrentCell = dataGridCars.Rows[0].Cells[0];
                }
            }
        }


        //  зміна машини
        private void dataGridCars_SelectionChanged(object? sender, EventArgs e)
        {
            if (isLoading) return;

            // Отримуємо поточний вибраний об'єкт машини
            if (dataGridCars.CurrentRow?.DataBoundItem is Car selectedCar)
            {
                RefreshOrders(selectedCar);
            }
            else
            {
                dataGridOrders.DataSource = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var filtered = fileManager.Clients
                .Where(c => c.Name.ToLower().Contains(searchText))
                .ToList();

            dataGridClients.DataSource = null;
            dataGridClients.DataSource = filtered;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshClients();
            txtSearch.Clear();
        }
    }
}