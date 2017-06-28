using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_comando_de_repeticao_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
            System.Threading.Thread.Sleep(5 * 1000);//Espera 5 segundos.
        }
    }
}
