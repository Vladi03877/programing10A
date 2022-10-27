using System;

namespace Rectangle_Properties
{
    public class Rectangle_Properties
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(2 * (width + height));
            Console.WriteLine(width * height);
            Console.WriteLine((decimal)Math.Sqrt(width * width + height * height));
        }
    }
}
