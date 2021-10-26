using System;

namespace TrabajoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ingrese un numero entero: ");
            a = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                Console.Write( i + " x " + a + "=" + i * a +"\n" );    
            }

            Console.WriteLine("hola gustavo ");
            int A, B, C, D, result;

            Console.WriteLine("Ingrese un numero entero: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero: ");
            B = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un numero entero: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero: ");
            D = int.Parse(Console.ReadLine());


            result = A + B / C + D ;
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
