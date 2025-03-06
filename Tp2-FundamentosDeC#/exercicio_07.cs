using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_07
    {
        public void Main()
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Esse Numero é par");
            }
            else
            {
                Console.WriteLine("Esse Numero é impar");
            }
        }
    }
}
