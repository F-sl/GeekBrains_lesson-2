using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_pr4
{
    class Program
    {
        public enum BuyList
        {
            Арахис,
            Бананы,
            Груши,
            Лук,
            Капуста,
            Помидоры,
        }
        public static void Main(string[] args)
        {
            string ooo = "ООО Ромашка";
            string adress = "г.Москва, ул. Большая полянка, 24";

            Console.SetCursorPosition(12, 0);
            Console.WriteLine($"{ooo} \n {adress}");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\nДата операции: {DateTime.Now}\nКАССИР: ПРИВАЛОВА А.А.");

            var rand = new Random();
            for (int ter = 0; ter <= 0; ter++)
                Console.Write("Термнал: {0,1:N0}", rand.Next(50000, 100000));
            Console.WriteLine();


            double arahis = 195.23;
            double banan = 56.48;
            double grush = 125.28;
            double look = 12.39;
            double kapusta = 35.48;
            double pomidor = 116.56;

            Console.WriteLine($"\n{(BuyList)0}                  {arahis} руб." +
                $"\n{(BuyList)1}                  {banan} руб." +
                $"\n{(BuyList)2}                   {grush} руб." +
                $"\n{(BuyList)3}                     {look} руб." +
                $"\n{(BuyList)4}                 {kapusta} руб." +
                $"\n{(BuyList)5}                {pomidor} руб.");
            Console.WriteLine();

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            double summ = arahis + banan + grush + look + kapusta + pomidor;
            Console.WriteLine($"ИТОГО:                  {summ} руб.\n\n");



        }
    }
}
