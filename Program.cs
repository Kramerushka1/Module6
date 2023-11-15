using System.Drawing;
using System.Xml.Linq;

namespace Module6
{
    ///<summary>
    ///Задание 6.6.2
    ///</summary>
    ///</summary>
    ///Добавьте в класс User из примера выше свойства для логина и почты:
    ///     Поле логина должно быть не менее 3 символов длиной.
    ///     Поле почты должно содержать знак @.
    ///О том, как узнать длину строки и содержит ли она определенный символ, постарайтесь найти информацию сами. 
    ///Если же у вас не получается — смотрите подсказку.



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class User
    {
        private int age;
        private string login;
        private string mail; 

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Поле логина должно быть не менее 3 символов длиной");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Поле почты должно содержать знак @");
                }
                else
                {
                    mail = value;
                }
            }
        }
    }

}