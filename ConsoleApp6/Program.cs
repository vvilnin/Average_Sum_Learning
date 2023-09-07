using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static double average(int arg)
        {
            int[] array = new int [arg];
            double sum = 0;
            for (int i = 0; i < arg; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 0; i < arg; i++)
            {
                sum = sum + array[i];
            }
            double averageSum = sum / arg;
            return averageSum;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(average(n)+average(m));
        }
    }
}
