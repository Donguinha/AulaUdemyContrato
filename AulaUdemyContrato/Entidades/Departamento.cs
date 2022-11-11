using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoTrabalho.Entidades
{
    class Departamento
    {
        public string NomeDepartamento { get; set; }

        public Departamento(string departamento)
        {
            NomeDepartamento = departamento;
        }
    }
}
