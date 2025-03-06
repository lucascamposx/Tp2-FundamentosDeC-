using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_12
    {
        public void Main()
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, 101);
            int numDigitado;

            do
            {
                Console.WriteLine("Digite um numero entre 1 e 100: ");
                numDigitado = int.Parse(Console.ReadLine());

                if (numDigitado > numAleatorio)
                {
                    Console.WriteLine("O numero é menor que " + numDigitado);
                }
                else if (numDigitado < numAleatorio)
                {
                    Console.WriteLine("O numero é maior que " + numDigitado);
                }
                else
                {
                    Console.WriteLine("Parabens! Você acertou, o numero é " + numAleatorio);
                }

            } while (numAleatorio != numDigitado);
        }
    }
}
