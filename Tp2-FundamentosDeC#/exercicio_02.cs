using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_02
    {
        public void Main()
        {
            Console.WriteLine("Digite sua Data de Nascimento: (dd/mm/aaaa)");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Now;

                DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

                // Se o aniversario ja passou neste ano
                if (proximoAniversario < dataAtual)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                int diasAteAniversario = (proximoAniversario - dataAtual).Days;

                Console.WriteLine("Faltam " + diasAteAniversario + " Dias para o seu proximo aniversario.");
            }
            else
            {
                Console.WriteLine("Formato invalido, use (dd/mm/aaaa)");
            }
        }
    }
}
