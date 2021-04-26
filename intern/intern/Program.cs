using System;

namespace intern
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Please give a number as 1st variable: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give a number as 2st variable: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write("The value of the 1st variable: {0} \n", a);

            Console.Write("The value of the 1st variable: {0}", b);



            Console.ReadKey();
        }
    }
}
