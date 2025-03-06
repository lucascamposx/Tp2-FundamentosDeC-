using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_06
    {
        public void Main()
        { 
            Console.WriteLine("Digite seu peso em Kg: ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura em M: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine($"\nIMC: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Magreza");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Classificação: Normal");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
           
            else if (imc >= 30 && imc < 34.8)
            {
                Console.WriteLine("Classificação: Obesidade grau I");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Classificação: Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade grau III");
            }
               
        }
    }
}
