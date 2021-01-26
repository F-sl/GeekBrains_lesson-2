using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_pr2
{
    public class Program
    {
        public enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int userMonth = Convert.ToInt32(Console.ReadLine());
            int currentMonth = DateTime.Now.Month;

            var a = (Month)currentMonth;

            if (userMonth == currentMonth)
            {
                Console.WriteLine($"Текущий месяц {a}");
            }
            else
            {
                Console.WriteLine("Порядковый номер текущего месяца задан неправильно");
            }

        }
    }
}
