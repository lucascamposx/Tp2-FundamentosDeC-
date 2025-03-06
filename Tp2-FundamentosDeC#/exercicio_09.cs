using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_09
    {
        public void Main()
        {
            Console.WriteLine("Digite seu salário bruto anual: ");
            float salarioAnual = float.Parse(Console.ReadLine());
            float aliquota = 0f;
            float deducao = 0f;

            if (salarioAnual > 64259.59f)
            {
                aliquota = 27.5f;
                deducao = 896.00f;
            }
            else if (salarioAnual >= 50148.26f)
            {
                aliquota = 22.5f;
                deducao = 662.77f;
            }
            else if (salarioAnual >= 37751.56f)
            {
                aliquota = 15f;
                deducao = 381.44f;
            }
            else if (salarioAnual >= 27870.41f)
            {
                aliquota = 7.5f;
                deducao = 169.44f;
            }

            float imposto = (salarioAnual * aliquota / 100) - deducao;
            float salarioLiquidoAnual = salarioAnual - imposto;

            if (imposto == 0f)
            {
                Console.WriteLine("Seu imposto de Renda foi isento");
            }

            else
            {
                Console.WriteLine($"Imposto de Renda: {imposto:F2}");
                Console.WriteLine($"Salario liquido Anual: {salarioLiquidoAnual:F2}");
            }
        }
    }
}
