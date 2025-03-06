using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_05
    {
        public void Main()
        {
            // Desenvolva um programa que peça ao usuário um valor em graus Celsius e o converta para Fahrenheit e Kelvin. 
            // Utilize a fórmula: F = C * 9/5 + 32 e K = C + 273.15. 

            Console.WriteLine("Digite a temperatura em Graus Celsios: ");
            float tempC = float.Parse(Console.ReadLine());

            float tempF = tempC * 9/5f + 32f;

            float tempK = tempC + 273.15f;

            Console.WriteLine($"Temperatura em Fahrenheit: {tempF} F");
            Console.WriteLine($"Temperatura em Kelvin: {tempK} K");
        }
    }
}
