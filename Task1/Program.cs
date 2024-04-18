using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует калькулятор!");
            Console.Write("Ввведите целое число Х=");
            double result = 0;

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввведите целое число У=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите код операции:\n"
              + $"\t 1 - сложение\n"
               + $"\t 2 - вычетание\n"
                + $"\t 3 - произведение\n"
                 + $"\t 4 - частное\n"
              );

                Console.Write("Ваш выбор=");
                int actionNumber = Convert.ToInt32(Console.ReadLine());
                switch (actionNumber)
                {
                    case 1:
                        result = x + y;
                        break;
                    case 2:
                        result = x - y;
                        break;
                    case 3:
                        result = x * y;
                        break;
                    case 4:
                        result = x / (double)y;
                        break;
                    default: throw new Exception("Нет операции с указанным номером");

                }
                Console.WriteLine($"Результат = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();








        }
    }
}
