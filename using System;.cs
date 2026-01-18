using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese los números ganadores de la lotería primitiva.");
        Console.WriteLine("Cuando termine, escriba 0 para finalizar.");

        int numero;

        do
        {
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }

        } while (numero != 0);

        numeros.Sort();

        Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");

        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}
