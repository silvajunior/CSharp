using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_quatro_operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.Write("Digite o 1º numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.Write("\nSoma: " + resultado);
            resultado = n1 - n2;
            Console.Write("\nSubtação: " + resultado);
            resultado = n1 * n2;
            Console.Write("\nMultiplicação: " + resultado);
            resultado = n1 / n2;
            Console.Write("\nDivisão: " + resultado);
            System.Threading.Thread.Sleep(10 * 1000);//Espera 10 segundos.
        }
    }
}
