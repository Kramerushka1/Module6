using System.Drawing;
using System.Xml.Linq;

namespace Module6
    ///Задание 6.2.2
    ///Добавьте в класс Pen, указанный ниже, 2 конструктора:
    /// - без параметров, когда поля color и cost заполняются значениями Черный и 100.
    /// - с 2 параметрами: penColor и penCost.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Pen
    {
        public string color;
        public int cost;

        // Конструктор 1
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        // Конструктор 2
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
}