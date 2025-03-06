using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_FundamentosDeC_
{
    class exercicio_04
    {
        public void Main()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n#########################");
            Console.WriteLine("### Dados Cadastrados ###");
            Console.WriteLine("#########################\n");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-mail: {email}");
        }
    }
}
