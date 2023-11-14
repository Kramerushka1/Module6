using System.Drawing;
using System.Xml.Linq;

namespace Module6
    ///Задание 6.2.8
    ///Создайте класс Rectangle для представления прямоугольников удовлетворяющий следующим требованиям:
    ///- Класс должен содержать целочисленные поля для сторон a и b.
    ///- Класс должен содержать метод Square, возвращающий площадь прямоугольника(произведение сторон).
    ///- Класс должен содержать 3 конструктора: 
    ///  - с 2 параметрами, когда a != b, 
    ///  - с 1 параметром, когда a == b, 
    ///  - и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Rectangle
    {
        public int a;
        public int b;

        // Конструктор 1
        public Rectangle(int num1, int num2)
        {
            a = num1;
            b = num2;
        }
        
        // Конструктор 2
        public Rectangle(int num)
        {
            a = num;
            b = num;
        }
        
        // Конструктор 2
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public int Square()
        {
            return a * b;
        }

    }
}