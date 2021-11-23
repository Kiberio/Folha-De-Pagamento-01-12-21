using System;

namespace FolhaDePagamento.Classe
{
    abstract class Funcionarios
    {
        //Declaração das variantes base para os funcionarios
        public String Nome { get; set; }
        public int Horas { get; set; }
        public double VHoras { get; set; }

        //Construtores
        public Funcionarios() { }
        public Funcionarios (string nome, int horas, double vhoras)
        {
            Nome = nome;
            Horas = horas;
            VHoras = vhoras;
        }

        //Função Salario que guarda o valor do pagamento
        public abstract double Salario();
    }
}
