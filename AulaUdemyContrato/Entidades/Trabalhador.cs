using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoTrabalho.Entidades.Enumeração;

namespace ContratoTrabalho.Entidades
{
    class Trabalhador
    {
        public Departamento Departamento { get; set; }
        public string Nome { get; private set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; private set; }        
        public List<Contrato> Contrato { get; private set; } = new List<Contrato>();

        public Trabalhador() { }

        public Trabalhador(Departamento departamento, string nome, NivelTrabalhador nivel, double salarioBase)
        {
            Departamento = departamento;
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
        }

        public void AddContrato(Contrato contract)
        {
            Contrato.Add(contract);
        }

        public void RemoverContrato(Contrato contract)
        {
            Contrato.Remove(contract);
        }

        public double ReceberMes(int mes, int ano)
        {
            var soma = SalarioBase;

            foreach (Contrato cada in Contrato)
            {
                if (ano == cada.Data.Year && mes == cada.Data.Month)
                {
                    soma += cada.ValorTotal();
                }
            }
            return soma;
        }

        public override string ToString()
        {
            return $"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nNome: {Nome}\nNível: {Nivel}\nDepartamento: {Departamento}";
        }
    }
}