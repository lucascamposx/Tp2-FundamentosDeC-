using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_11
    {
        public void Main()
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
