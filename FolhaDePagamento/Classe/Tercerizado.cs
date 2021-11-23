
namespace FolhaDePagamento.Classe
{
    class Tercerizado : Funcionarios
    {
        //Declaração da Variavel que guarda o valor das despesas
        public double Adicional { get; set; }

        //Construtores
        public Tercerizado() { }
        public Tercerizado (string nome, int horas,double vhoras, double adicional):base(nome,horas,vhoras)
        {
            Nome = nome;
            Horas = horas;
            VHoras = vhoras;
            Adicional = adicional;
        }
        //Função calculando o pagamento de funcionarios tercerizados
        public override double Salario()
        {
            Adicional = Adicional * 110 / 100;
            return Horas * VHoras + Adicional;
        }
    }
}
