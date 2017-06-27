using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_soma_de_dois_numeros
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int n1, n2, soma;
            Console.Write("Digite o 1º numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.Write("Soma: "+soma);
            System.Threading.Thread.Sleep(5 * 1000);//Espera 5 segundos.

        }
    }
}
