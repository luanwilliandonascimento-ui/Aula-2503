using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, antecessor, sucessor;
            Console.WriteLine("Digite o numero: ");
            numero  = int.Parse(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;
            Console.WriteLine("o sucessor de " + numero + " é " + antecessor);
            Console.WriteLine("o sucessor de " + numero + " é " + sucessor);


        }
    }
}
