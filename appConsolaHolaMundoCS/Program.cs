using System;

namespace appConsolaHolaMundoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            //Sumar
            int a = 3;
            int b = 5;
            int c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);
            //Multiplicar 
            int d = a * b;
            Console.WriteLine(a + "*" + b+ "=" + d);
            //Restar 
            int e = b - a;
            Console.WriteLine(b + "-" + a + "=" + e);
            Console.ReadKey();
        }
    }
}
