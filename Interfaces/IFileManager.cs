using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Interfaces
{
    // Інтерфейс IFileManager задає "контракт"
    // Будь-який клас який його реалізує повинен мати методи Save і Load
    public interface IFileManager // Вимога курсової: Інтерфейс
    {
        // Метод збереження даних у файл
        void Save(string path);

        // Метод завантаження даних з файлу
        void Load(string path);
    }
}
