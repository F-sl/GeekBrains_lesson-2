using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_pr5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру");
            int maxTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру");
            int minTemp = Convert.ToInt32(Console.ReadLine());

            int middleTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"\nСредняя температура {middleTemp} градусов");
                        
            if (numberOfMonth == 1)
            {
                if (middleTemp > 0)
                {
                    Console.WriteLine("\nДождливая зима\n\n");
                }
            }
            else if (numberOfMonth == 2)
            {
                if (middleTemp > 0)
                {
                    Console.WriteLine("\nДождливая зима\n\n");
                }
            }
            else if (numberOfMonth == 12)
            {
                if (middleTemp > 0)
                {
                    Console.WriteLine("\nДождливая зима\n\n");
                }
            }
            else Console.WriteLine();

        }
    }
}
