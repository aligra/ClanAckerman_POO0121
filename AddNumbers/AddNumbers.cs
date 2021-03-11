using System;

namespace Opt 
{
    class Method
    {
        static void Main (string [] args)
        {
            Console.WriteLine ("Ingrese dos numeros enteros: ");
            int a = 0, b = 0;

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine ($"Resta: {AddNumbers (a, b)}");
        }

        static int AddNumbers (int a, int b)
        {
            return a-b;
        }
    }
}