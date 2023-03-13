using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica1
{
    public class Check
    {
        public string Nickname { get; set; }
        public string Breed { get; set; }
        public float Age { get; set; }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Check с помощью конструктора с параметрами
            Check check = new Check();

            // Выводим информацию о чеке
            Console.WriteLine("Nickname: " + check.Nickname);
            Console.WriteLine("Breed: " + check.Breed);
            Console.WriteLine("Age: " + check.Age);

            // Ожидаем нажатия любой клавиши
            Console.ReadKey();
        }
    }
}