using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoTrabalho.Entidades
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        public Contrato() { }

        public Contrato(DateTime data, double valorHora, int horas)
        {
            Data = data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorHora * Horas;
        }
    }
}