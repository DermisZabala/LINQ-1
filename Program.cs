using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] valoresNumericos = new int[10];
            valoresNumericos[0] = 1;
            valoresNumericos[1] = 2;
            valoresNumericos[2] = 3;
            valoresNumericos[3] = 4;
            valoresNumericos[4] = 5;
            valoresNumericos[5] = 6;
            valoresNumericos[6] = 7;
            valoresNumericos[7] = 8;
            valoresNumericos[8] = 9;
            valoresNumericos[9] = 10;

            Console.WriteLine("Numeros Impares: ");
            IEnumerable<int> numerosImpares = from numeros in valoresNumericos where numeros%2==1 select numeros;
            

            foreach (int val in numerosImpares)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("\nNumeros Pares: ");
            IEnumerable<int> numerosPares = from numeros in valoresNumericos where numeros % 2 == 0 select numeros;

            foreach (int val in numerosPares)
            {
                Console.WriteLine(val);
            }

            
        }
    }
}
