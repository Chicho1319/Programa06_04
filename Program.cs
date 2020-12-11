using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND - && - Y
            // Solo es verdadero cuando los dos son verdaderos
            // A B | R
            // F F | F
            // F V | F
            // V F | F
            // V V | V

            // Este programa imprime la suma, solo cuando los dos números sean menores a 10

            // Variables

            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // Pedimos los números

            Console.WriteLine("Dame el primer número");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("Dame el segundo número");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // Verificamos que a sea menor que 10 y b sea menor que 10

            if (a < 10 && b <10)
            {
                // Hacemos la suma
                suma = a + b;

                // Mostramos resultado
                Console.WriteLine("La suma es: {0}", suma);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Los dos números no son menores a 10");
                Console.ReadKey();
            }
        }
    }
}
