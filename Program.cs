using System;

namespace ConsoleApp1
{
    internal class Program
    
    {
    static void zadanie1()
        {
            Console.WriteLine("Введите длину ребра куба a: ");
            string tmp = Console.ReadLine();
            int a = Int32.Parse(tmp);
            int V = a * a * a;
            int S = 6 * (a * a);
            Console.WriteLine("Объем куба = " + V);
            Console.WriteLine("Площадь поверхности куба = " + S);
        }
        static void Zadanie2()
        {
            
            
                Console.WriteLine("Введите радиус:");
                string tmp = Console.ReadLine();
                int r = Int32.Parse(tmp);
                int l = 2 * (int)3.14 * r;
                int s = (int)3.14 * r * r;
                Console.WriteLine("Длина окружности:" + l);
                Console.WriteLine("Площадь окружности:" + s);
            

        }
    
        static void Zadanie3()
        {
            Console.WriteLine("Введите два числа ");
            string tmp = Console.ReadLine();
            int a = Int32.Parse(tmp);
            string tm = Console.ReadLine();
            int b = Int32.Parse(tm);
            double c = Math.Sqrt(a * b);
            Console.WriteLine("Среднее геометрическое чисел  " + c);
        }

        static void Zadanie4()
        {
            Console.WriteLine("Введите два числа ");
            string tmp = Console.ReadLine();
            double a = Int32.Parse(tmp);
            string tm = Console.ReadLine();
            double b = Int32.Parse(tm);
            double sum = (a * a) + (b * b);
            double dif = (a * a) - (b * b);
            double prod = (a * a) * (b * b);
            double quo = (a * a) / (b * b);
            Console.WriteLine("Сумма квадратов = " + sum);
            Console.WriteLine("Разность квадратов = " + dif);
            Console.WriteLine("Произведение квадратов = " + prod);
            Console.WriteLine("Частное квадратов = " + quo);
        }
        static void Zadanie5()
        {
            Console.WriteLine("Введите число ");
            string tmp = Console.ReadLine();
            int a = Int32.Parse(tmp);
            if (a >= 0)
            {
                int b = a + 1;
                Console.WriteLine(+b);
            }
            else
            {
                int b = a - 2;
                Console.WriteLine(+b);
            }
        }
        




    }

}