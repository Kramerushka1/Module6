using System.Drawing;
using System.Xml.Linq;

namespace Module6
{
    /// Задание 6.3.1
    /// Напишите такой код, который бы при типе компании, равному типу "Банк", и городе "Санкт-Петербург" выводил в консоль сообщение 
    /// "У банка ??? есть отделение в Санкт-Петербурге", где вместо "???" выводилось бы название компании.
    ///Если у компании нет названия, вместо него должно быть "Неизвестная компания".

    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }

        static Department GetCurrentDepartment()
        {
            // logic
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }


}