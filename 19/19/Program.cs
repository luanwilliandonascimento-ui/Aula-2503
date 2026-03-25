using System;

internal class Program
{
    static void Main(string[] args)
    {
        double km, litros, consumoMedio;

        Console.Write("Digite a distância percorrida (km): ");
        km = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de litros gastos: ");
        litros = double.Parse(Console.ReadLine());

        if (litros > 0)
        {
            consumoMedio = km / litros;
            Console.WriteLine("O consumo médio é de: " + consumoMedio.ToString("F2") + " km/l");
        }
        else
        {
            Console.WriteLine("A quantidade de litros deve ser maior que zero.");
        }

       
    }
}