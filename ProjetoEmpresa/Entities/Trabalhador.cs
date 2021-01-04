using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Trabalhador() { }

        public Trabalhador(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
           return ValorHora * Horas;
        }


    }
}
