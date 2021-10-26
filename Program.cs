using System;

namespace TrabajoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;

            Console.WriteLine("Ingrese un numero entero: ");
            a = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                Console.Write( i + " x " + a + "=" + i * a +"\n" );
            }
        }
    }
}
