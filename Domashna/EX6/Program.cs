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
            int repeats = int.Parse(Console.ReadLine());
            int c = 0;
            int[] arr = new int[2];
            for (int i = 0; i < repeats; i++)
            {
                Console.WriteLine();
                arr[0] = int.Parse(Console.ReadLine());
                arr[1] = int.Parse(Console.ReadLine());
                c = (arr[0] % arr[1] + c);
            }
            Console.WriteLine(c);
        }
    }
}

