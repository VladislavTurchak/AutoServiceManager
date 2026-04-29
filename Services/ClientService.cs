using AutoServiceManager.Models;

namespace AutoServiceManager.Services
{
    public class ClientService
    {
        // Узагальнена колекція List<Client>
        public List<Client> Clients { get; set; } = new List<Client>();

        public Client? FindClient(string name)
        {
            // Вимога курсової:
            // LINQ + Lambda вираз
            return Clients.FirstOrDefault(c => c.Name == name);
        }
    }
}