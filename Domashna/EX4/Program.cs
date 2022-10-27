using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int a2 = b1;
            int b2 = a1;
            Console.Write($"Before: \n" + $"a = {a1} \n" + $"b = {b1} \n" + $"After: \n" + $"a = {a2} \n" + $"b = {b2}");

        }
    }
}
