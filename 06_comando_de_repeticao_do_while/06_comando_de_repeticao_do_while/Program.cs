using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_comando_de_repeticao_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.WriteLine("Deseja executar novamente sim(Qualquer tecla) não(0): ");
                op = Console.ReadLine();
            } while (op != "0");
            
        }
    }
}
