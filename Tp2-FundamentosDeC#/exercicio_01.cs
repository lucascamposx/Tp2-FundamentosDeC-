using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_.Exercicio_01
{
    public class exercicio_01
    {
        public void Main()
        {
            Console.WriteLine("Digite sua Data de Nascimento: (dd/mm/aaaa)");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Now;

                int anos = dataAtual.Year - dataNascimento.Year;
                int meses = dataAtual.Month - dataNascimento.Month;
                int dias = dataAtual.Day - dataNascimento.Day;

                
                if ((dataAtual.Month < dataNascimento.Month) || 
                    (dataAtual.Month == dataNascimento.Month && dataAtual.Day < dataNascimento.Day))
                {
                    anos--;
                }

                if (meses < 0)
                {
                    meses += 12;
                }

                if (dias < 0)
                {
                    meses --;
                    var ultimoMes = dataAtual.AddMonths(-1);
                    dias += DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month);
                }

                Console.Write("Você tem ");
                Console.Write(anos != 0 ? anos + " Anos " : "");
                Console.Write(meses != 0 ? meses + " Meses " : "");
                Console.Write(dias != 0 ? dias + " Dias" : "");

            }
            else
            {
                Console.WriteLine("Formato invalido, use (dd/mm/aaaa)");
            }

        }
        
    }
}
