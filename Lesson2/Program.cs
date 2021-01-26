using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру");
            int maxTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру");
            int minTemp = Convert.ToInt32(Console.ReadLine());

            int middleTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Средняя температура {middleTemp} градусов");
        }
    }
}
