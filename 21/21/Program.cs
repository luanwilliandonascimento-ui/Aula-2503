using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n, menor;

        Console.Write("Digite o 1º número: ");
        n = int.Parse(Console.ReadLine());
        menor = n;

        Console.Write("Digite o 2º número: ");
        n = int.Parse(Console.ReadLine());
        if (n < menor) menor = n;

        Console.Write("Digite o 3º número: ");
        n = int.Parse(Console.ReadLine());
        if (n < menor) menor = n;

        Console.Write("Digite o 4º número: ");
        n = int.Parse(Console.ReadLine());
        if (n < menor) menor = n;

        Console.Write("Digite o 5º número: ");
        n = int.Parse(Console.ReadLine());
        if (n < menor) menor = n;

        Console.WriteLine("O menor número digitado foi: " + menor);
        Console.ReadKey();
    }
}