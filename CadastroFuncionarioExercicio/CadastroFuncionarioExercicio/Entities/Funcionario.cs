using System;
using System.Collections.Generic;
using CadastroFuncionarioExercicio.Entities.Enum;

namespace CadastroFuncionarioExercicio.Entities
{
    public class Funcionario
    {
        public string Name { get; set; }
        public Classificacao Nivel { get; set; }
        public double Salario { get; set; }
        public List<ContratoHora> Contratos { get; private set; } = new List<ContratoHora>();
        public Departamento departamento { get; set; }
        public Funcionario()
        {
        }

        public Funcionario(string name, Classificacao nivel, double salario, Departamento departamento)
        {
            Name = name;
            Nivel = nivel;
            Salario = salario;
            this.departamento = departamento;
        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Income(int ano, int mes)
        {
            double soma = Salario;
            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Date.Year == ano && contrato.Date.Month == mes )
                {
                    soma += contrato.ValorTotal();

                }
            }
            return soma;
        }
    }
}
