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
            int A, B, C, D ;

            Console.WriteLine("Ingrese un numero entero: ");
            Console.WriteLine("hola gustavo ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero: ");
            Console.WriteLine("hola gustavo ");
            B = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un numero entero: ");
            Console.WriteLine("hola gustavo ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero: ");
            Console.WriteLine("hola gustavo ");
            D = int.Parse(Console.ReadLine());

            Console.Write((A+B)/(C+D));
            Console.ReadKey();
        }
    }
}
