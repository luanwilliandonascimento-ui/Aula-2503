using System;

class Program
{
    static void Main()
    {
        // 1. Solicita o primeiro número
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        // 2. Solicita o segundo número
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        // 3. Realiza a multiplica
        double resultado = num1 * num2;

        // 4. Exibe o resultado
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");

        // Mantém o console aberto até você apertar uma tecla
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}