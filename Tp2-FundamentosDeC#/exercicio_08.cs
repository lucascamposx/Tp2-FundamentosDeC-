using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_08
    {
        public void Main()
        {
            Console.WriteLine("Digite sua Nota: ");
            float nota = float.Parse(Console.ReadLine());

            if (nota >= 0 && nota < 7)
            {
                Console.WriteLine("Insuficiente");
            }
            else if (nota >= 7 && nota < 8)
            {
                Console.WriteLine("Regular");
            }
            else if (nota >= 8 && nota < 9)
            {
                Console.WriteLine("Bom");
            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Excelente");
            }
            else
            {
                Console.WriteLine("Nota invalida, insira uma nota entre 0 e 10.");
            }

        }
    }
}
