using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    
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
        
        static void Zadanie6()
        {
            Console.WriteLine("Введите 3 числа"); 
           
            string tmp = Console.ReadLine();
            string tmi = Console.ReadLine();
            string tmk = Console.ReadLine();
            int a = Int32.Parse(tmp);
            int b = Int32.Parse(tmi);
            int c = Int32.Parse(tmk);
            int n = 0;
            if(a > 0) ++n;
            if(b > 0) ++n;
            if(c > 0) ++n;
            Console.WriteLine("Положительные числа"+n);

        }

        static void Zadanie7()
        {
            Console.WriteLine("Введите 2 числа");
            string tmp = Console.ReadLine();
            string tmi = Console.ReadLine();
            int a=Int32.Parse(tmp);
            int b = Int32.Parse(tmi);
            if (a > b) ;
            Console.WriteLine("Меньший " + Math.Min(a, b));
            
            
            
        }

        static void Zadanie8()
        {
            Console.WriteLine("Введите 2 числа");
            string tmp = Console.ReadLine();
            string tmi = Console.ReadLine();
            double a = Double.Parse(tmp);
            double b = Double.Parse(tmi);
            if (a >b) 
            {
                double temp = a;
                a=b;
                b= temp;
            }
            Console.WriteLine("Новое значение A" + a);
            Console.WriteLine("Новое значение B" + b);
           
         

        }
       


        static void Main(string[] args)
        {
            Zadanie8();
        }

//https://github.com/blockin90/Programming_PIB/blob/master/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D1%8B%D0%B5%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D1%8B/%D0%9B%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%207%20-%20Unit%20%D1%82%D0%B5%D1%81%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5.docx

    }

}
