using System;
using ProjetoEmpresa.Entities;
using System.Collections.Generic;

namespace ProjetoEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Trabalhador> lista = new List<Trabalhador>();


            Console.Write("Bom dia, Digite o numero de funcionarios consultados: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionario #{i}: ");

                Console.Write("É tercerizado (s/n): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Quanto ganha por hora trabalhada: ");
                double horaTrabalhada = double.Parse(Console.ReadLine());

               
                if(ch == 's')
                {
                    Console.Write("Valor Adicional do serviço tercerizado: ");
                    double valorAdicional = double.Parse(Console.ReadLine());

                    lista.Add(new TrabalhadorTercerizado(nome, horas, horaTrabalhada, valorAdicional));

                }

                else
                {
                    lista.Add(new Trabalhador(nome, horas, horaTrabalhada));

                }


            }

            Console.WriteLine();

            Console.WriteLine("PAGAMENTOS: ");

            foreach(Trabalhador trabalhador in lista)
            {
                Console.WriteLine(trabalhador.Nome + " - R$ " + trabalhador.Pagamento().ToString("F2"));
            }



        }
    }
}
