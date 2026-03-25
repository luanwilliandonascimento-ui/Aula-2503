using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite a sua idade atual: ");

        int idadeAtual = int.Parse(Console.ReadLine());

        int idadeFutura = idadeAtual + 10;

        Console.WriteLine($"Daqui a 10 anos, você terá {idadeFutura} anos.");

        Console.ReadKey();
    }
}