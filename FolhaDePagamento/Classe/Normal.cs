using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaDePagamento.Classe
{
    class Normal : Funcionarios
    {
        //Construtores
        public Normal() { }
        public Normal(string nome,int horas,double vhoras)
        {
            Nome = nome;
            Horas = horas;
            VHoras = vhoras;
        }
        //Função calculando o pagamento dos funcionarios comuns
        public override double Salario()
        {
            return Horas * VHoras;
        }
    }
}
