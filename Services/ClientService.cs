using AutoServiceManager.Models;

namespace AutoServiceManager.Services
{
    public class ClientService
    {
        // Список клієнтів
        // Зберігає всі об'єкти Client
        public List<Client> Clients { get; set; } = new List<Client>();

        // Метод пошуку клієнта за ім'ям
        public Client? FindClient(string name)
        {
            // FirstOrDefault повертає перший елемент який підходить
            // або null якщо клієнт не знайдений

            // c => c.Name == name це лямбда-вираз
            // Він перевіряє ім'я кожного клієнта у списку
            return Clients.FirstOrDefault(c => c.Name == name);
        }
    }
}