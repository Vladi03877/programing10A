using System;

namespace _07.ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            string temp = c;
            string temp2 = a;
            a = temp;
            c = temp2;


            Console.WriteLine(a + b + c);

        }
    }
}
