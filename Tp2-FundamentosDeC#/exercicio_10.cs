using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_10
    {
        public void Main()
        {
            Console.WriteLine("Digite um Numero para começar a contagem: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Contagem :"); 

            for (int i = num; i >= 0; i--)
            {
                Console.Write(i);

                if (i > 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
    }
}
