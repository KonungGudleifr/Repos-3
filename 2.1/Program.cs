using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChernogorApp2._1
{
    class Program //Средний уровень
    {
        static double s = 0.05d, p = 0.10d; //скидка
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите стоимость покупки: ");
                double salary = double.Parse(Console.ReadLine());
                if (salary > 1000 & salary < 2001)
                {
                    salary -= salary * s;
                }
                else if (salary > 2000 & salary < 5001)
                {
                    salary -= salary * p;
                }
                else
                {
                    salary = salary;
                }
                Console.WriteLine($"Стоимость покупки со скидкой в гривнах составляет: {salary}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}