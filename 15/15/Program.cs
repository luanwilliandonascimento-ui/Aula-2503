using System;

internal class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 100)
        {
            Console.WriteLine("O número " + numero + " é maior que 100.");
        }
        else if (numero == 100)
        {
            Console.WriteLine("O número é exatamente 100.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não é maior que 100.");
        }

        Console.ReadKey();
    }
}