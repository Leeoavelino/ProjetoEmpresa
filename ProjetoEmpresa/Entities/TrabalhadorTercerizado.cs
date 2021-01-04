using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa.Entities
{
    class TrabalhadorTercerizado : Trabalhador
    {

        public double ValorAdicional { get; set; }

        public TrabalhadorTercerizado() { }

        public TrabalhadorTercerizado(string nome, int horas, double valorHora, double valorAdicional): base(nome, horas, valorHora)
        {
            ValorAdicional = valorAdicional;

        }

        public override double Pagamento()
        {
            return base.Pagamento() + ValorAdicional;
        }

    }
}
