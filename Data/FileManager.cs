using System.Text.Json;
using AutoServiceManager.Models;
using AutoServiceManager.Interfaces;

namespace AutoServiceManager.Data
{
    // Клас FileManager відповідає за збереження і завантаження даних з файлу
    // Реалізує інтерфейс IFileManager (контракт методів Save та Load)
    public class FileManager : IFileManager
    {
        // Список всіх клієнтів автосервісу
        // Саме цей список буде зберігатись у файл
        public List<Client> Clients { get; set; } = new List<Client>();

        // Метод збереження даних у файл
        public void Save(string path)
        {
            try
            {
                // Перетворюємо список клієнтів у JSON текст
                string json = JsonSerializer.Serialize(Clients);

                // Записуємо JSON у файл за вказаним шляхом
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                // Якщо виникла помилка — показуємо повідомлення
                MessageBox.Show(ex.Message);
            }
        }

        // Метод завантаження даних з файлу
        public void Load(string path)
        {
            try
            {
                string json = File.ReadAllText(path);

                var clients = JsonSerializer.Deserialize<List<Client>>(json) ?? new List<Client>();

                foreach (var client in clients)
                {
                    foreach (var car in client.Cars)
                    {
                        foreach (var order in car.Orders)
                        {
                            if (order.Service == null)
                                continue;

                            // Перетворюємо object → JSON → конкретний клас
                            var jsonService = JsonSerializer.Serialize(order.Service);

                            if (jsonService.Contains("Repair"))
                            {
                                order.Service = JsonSerializer.Deserialize<RepairService>(jsonService);
                            }
                            else
                            {
                                order.Service = JsonSerializer.Deserialize<MaintenanceService>(jsonService);
                            }
                        }
                    }
                }

                Clients = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}