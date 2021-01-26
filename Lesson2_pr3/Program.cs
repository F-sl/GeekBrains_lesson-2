using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int ostatok = userNumber % 2;
            if (ostatok == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число");
            }
        }
    }
}
