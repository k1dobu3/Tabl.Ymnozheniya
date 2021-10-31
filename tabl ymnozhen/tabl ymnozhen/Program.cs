using System;

namespace tabl_ymnozhen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите Start для вывода таблицы умножения!");
            string xx = Console.ReadLine();
            string zz = "Start";
            int sum;
            if (xx == zz)
            {
                for (int i = 2; i <= 6; i++)
                {
                    for (int e = 1; e <= 10; e++)
                    {
                        sum = i * e;
                        Console.WriteLine($"{i} x {e} = {sum}");
                    }
                }
            }
            else  Console.WriteLine("Подумайте над своим поведением и вернитесь позже :3");











            /* if (xx == zz)
            {
                while (a != 10)
                    {
                        a += 1;
                        sum = q * a;
                        Console.WriteLine($"{q} x {a} = {sum}");
                        
                    }
                
            } */
        }
    }
}
