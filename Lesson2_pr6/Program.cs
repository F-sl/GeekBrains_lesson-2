using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_pr6
{
    class Program
    {
        [Flags]
        enum DaysOfWeek
        {
            Понедельник = 0b0000001,
            Вторник = 0b0000010,
            Среда = 0b0000100,
            Четверг = 0b0001000,
            Пятница = 0b0010000,
            Суббота = 0b0100000,
            Воскресенье = 0b1000000,
        }
        static void Main(string[] args)
        {
            DaysOfWeek workDays = DaysOfWeek.Понедельник | DaysOfWeek.Вторник | DaysOfWeek.Среда
                | DaysOfWeek.Четверг | DaysOfWeek.Пятница | DaysOfWeek.Суббота | DaysOfWeek.Воскресенье;

            DaysOfWeek firm1 = (DaysOfWeek)0b0011110;
            DaysOfWeek firm2 = (DaysOfWeek)0b1111111;

            DaysOfWeek workDays1 = workDays & firm1;
            DaysOfWeek workDays2 = workDays & firm2;

            Console.WriteLine($"Расписание первого офиса: \n{workDays1}\n\nРасписание второго офиса: \n{workDays2}\n\n");
        }
    }
}
