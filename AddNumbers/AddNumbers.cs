using System;

namespace Opt 
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine ("\nIngrese dos numeros enteros: ");
            int a = 0, b = 0;

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine ($"\nLa multiplicacion es: {AddNumbers (a, b)}");
        }

        static int AddNumbers (int a, int b)
        {
            return a*b;
        }
    }
}