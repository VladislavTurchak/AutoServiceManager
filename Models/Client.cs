using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас Client описує клієнта автосервісу
    public class Client
    {
        // Ім'я клієнта
        public string Name { get; set; }

        // Приватне поле телефону (інкапсуляція)
        private string phone;

        // Властивість для доступу до телефону
        // Через get/set можна контролювати доступ до поля
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Список автомобілів клієнта
        // Це агрегація: клієнт має автомобілі
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
