using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) /3;
           
            Console.WriteLine("a media é " + media);


        }
    }
}
