using System;

internal class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Digite um número: ");

       
        numero = int.Parse(Console.ReadLine());

        
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é PAR.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ÍMPAR.");
        }

       
        Console.ReadKey();
    }
}
