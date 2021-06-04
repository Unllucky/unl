using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конец диапазона от 1 до : ");
            int end = int.Parse(Console.ReadLine());
            Thread thread1 = new Thread(Fibanachi);
            Thread thread2 = new Thread(Simple);
            thread1.Start(end);
            thread2.Start(end);
            Console.WriteLine("Результат записан в result1.txt & result2.txt");
        }

        public static void Fibanachi(object end)
        {
            List<string> result = new List<string>();
            int j = 1;
            for (int i = 1; i <= (int)end; i += j)
            {
                Console.Write("{0} ", i);
                j = i - j;
                result.Add(j.ToString());
            }
            File.WriteAllLines("result1.txt", result);
        }

        public static void Simple(object b)
        {
            List<string> result = new List<string>();
            for (int i = 0; i <= (int)b; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i + "\n");
                    result.Add(i.ToString());
                }
            }
            File.WriteAllLines("result2.txt", result);
        }
        public static bool isSimple(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}