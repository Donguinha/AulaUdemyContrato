using ContratoTrabalho.Entidades;
using ContratoTrabalho.Entidades.Enumeração;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace ContratoTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Departamento departamento1 = new Departamento();
            Console.Write("Departamento: ");
            var dep = Console.ReadLine();
            
            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nDados do trabalhador\nNome: ");
            var nome = Console.ReadLine();

            Console.Write("Nível (Junior/Nível médio/ Senior): ");
            var nivel = Console.ReadLine();
            NivelTrabalhador nivelenum = Enum.Parse<NivelTrabalhador>(nivel);

            Console.Write("Salário base: ");
            var salario = double.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(dep);
            Trabalhador trabalhador1 = new Trabalhador(departamento, nome ,nivelenum, salario);


            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nQuantidade dos contratos de trabalho: ");
            var qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtde; i++)
            {
                Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nData: ");
                var data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor hora do trabalho: ");
                var valorporhora = double.Parse(Console.ReadLine());

                Console.Write("Duração: ");
                var horas = int.Parse(Console.ReadLine());

                Contrato contratonovo = new Contrato(data, valorporhora, horas);

                trabalhador1.AddContrato(contratonovo);
            }

            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nData para buscar valores dos contratos (MM/AAAA): ");
            var datas = Console.ReadLine().Split('/');
            var ano = int.Parse(datas[1]);
            var mes = int.Parse(datas[0]);

            Console.Write($"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nNome: {trabalhador1.Nome}\nDepartamento: {trabalhador1.Departamento.NomeDepartamento}\nValor recebido na data {mes}/{ano}: {trabalhador1.ReceberMes(mes, ano)} ");
        }
    }
}

