using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoServiceManager.Models
{
    // Клас з полями та властивостями
    public class Client
    {
        public string Name { get; set; }

        // Вимога курсової:
        // private модифікатор доступу (інкапсуляція)
        private string phone;

        // Доступ до private поля через властивість
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Вимога курсової:
        // Узагальнена колекція BindingList<Car>
        // Агрегація: клієнт має автомобілі
        public BindingList<Car> Cars { get; set; } = new BindingList<Car>();
    }
}