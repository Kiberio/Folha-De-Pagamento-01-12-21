using System;
using System.Collections.Generic;
using System.Globalization;

namespace FolhaDePagamento.Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista
            List<Funcionarios> list = new List<Funcionarios>();
            //Solicitar o numero de funcionarios
            Console.WriteLine("Entre com o número de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //Informações dos funcionarios
                Console.WriteLine($"Funcionario#{i}: ");
                Console.Write("Tercerizado (S/N): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double vhoras = double.Parse(Console.ReadLine());
                //Informações adicionais para Tercerizados
                if (ch == 'S' || ch == 's')
                {
                    Console.WriteLine("Adicional Despesas: ");
                    double adicional = double.Parse(Console.ReadLine());
                    list.Add(new Tercerizado(nome, horas, vhoras, adicional));
                }
                //Adicionar a lista o funcionario normal
                if (ch == 'n' || ch == 'N')
                {
                    list.Add(new Normal(nome,horas,vhoras));
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine();
            //Imprimir o pagamento de todos os funcionarios
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionarios forma in list)
            {
                Console.WriteLine(forma.Nome+ " - " + forma.Salario().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
