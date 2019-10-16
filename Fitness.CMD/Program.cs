using Fitness.LB.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем!");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();
            Console.WriteLine("Дату рождения");
            var birthDate = DateTime.Parse(Console.ReadLine());//TODO: TryParse
            Console.WriteLine("Введите вес");
            var weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            var height = Double.Parse(Console.ReadLine());
            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
