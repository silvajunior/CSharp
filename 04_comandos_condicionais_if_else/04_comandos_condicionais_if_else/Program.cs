using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_comandos_condicionais_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Digite um numero menor e diferente de 5: ");
            x = int.Parse(Console.ReadLine());
            if (x < 5)
            {
                Console.Write("\nOk !");
            }
            else
            {
                Console.Write("Resposta Inválida!");
            }
            System.Threading.Thread.Sleep(10 * 1000);//Espera 10 segundos.
        }
    }
}
