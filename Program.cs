using System.Drawing;
using System.Xml.Linq;

namespace Module6
{
    //Задание 6.3.2
    //Для класса Bus реализуйте метод PrintStatus,
    //который будет сообщать о количестве пассажиров в автобусе, если они есть.
    //Или сообщать, что автобус пуст.

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }

    }
}