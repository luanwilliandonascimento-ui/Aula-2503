using System;

internal class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero >= 10 && numero <= 50)
        {
            Console.WriteLine("O número está entre 10 e 50.");
        }
        else
        {
            Console.WriteLine("O número não está entre 10 e 50.");
        }

        Console.ReadKey();
    }
}