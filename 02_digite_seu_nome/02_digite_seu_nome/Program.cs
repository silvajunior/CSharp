using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_digite_seu_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Seja bem-vindo " +nome+" !");
            System.Threading.Thread.Sleep(5 * 1000);//Espera 5 segundos.
        }
    }
}
