using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n1, n2;

        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 == n2)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine("Os números são diferentes.");
        }

        Console.ReadKey();
    }
}