using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_03
    {
        public void Main()
        {
            Console.WriteLine("Digite uma Data: (dd/mm/aaaa)");
            DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Digite outra Data: (dd/mm/aaaa)");
            DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            if (data1 > data2)
            {
                Console.WriteLine("A primeira data deve ser menor que a segunda.");
                return;
            }

            int anos = data2.Year - data1.Year;
            int meses = data2.Month - data1.Month;
            int dias = data2.Day - data1.Day;


            if ((data2.Month < data1.Month) ||
                (data2.Month == data1.Month && data2.Day < data1.Day))
            {
                anos--;
            }

            if (meses < 0)
            {
                meses += 12;
            }
            
            if (dias < 0)
            {
                meses--;
                var ultimoMes = data2.AddMonths(-1);
                dias += DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month);
            }

            TimeSpan diferenca = data2 - data1;
            int diferencaDias = diferenca.Days;
            int totalMeses = (anos * 12) + meses;
            float diferencaAnos = totalMeses / 12f;
            float diferencaMeses = totalMeses + (dias / 30f);

            Console.Write("Diferença: ");
            Console.Write(anos != 0 ? anos + " Anos " : "");
            Console.Write(meses != 0 ? meses + " Meses " : "");
            Console.Write(dias != 0 ? dias + " Dias" : "");
            Console.WriteLine("");

            Console.WriteLine($"Diferença em Dias: {diferencaDias} dias");

            Console.WriteLine($"Diferença em Meses: {diferencaMeses:F2} meses");

            Console.WriteLine($"Diferença em Anos: {diferencaAnos:F2} anos");
        }
    }
}
