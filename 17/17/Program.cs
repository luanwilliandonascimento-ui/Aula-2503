using System;

internal class Program
{
    static void Main(string[] args)
    {
        double salario;

        Console.Write("Digite o salário: ");
        salario = double.Parse(Console.ReadLine());

        if (salario < 2000)
        {
            salario = salario * 1.10;
            Console.WriteLine("Novo salário com 10% de aumento: " + salario);
        }
        else
        {
            Console.WriteLine("Salário sem aumento: " + salario);
        }

       }
}