using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager
{
    public partial class Form1
    {
        // Метод очищення полів клієнта
        private void ClearClientFields()
        {
            txtName.Clear();
            txtPhone.Clear();
        }

        // Метод очищення полів авто
        private void ClearCarFields()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtPlate.Clear();
        }

        // Метод очищення полів замовлення
        private void ClearOrderFields()
        {
            txtPrice.Clear();
            txtHours.Clear();
            cmbServiceType.SelectedIndex = -1;
        }
    }
}
