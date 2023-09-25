using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA___3bim.classes
{
    internal class Medico : Funcionario
    {
        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico() { }

        public Medico (string crm, double valorHoraExtra, string especialidade,string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario):base(nome,cpf, matricula, dataNasc, sexo, salario)
        {
            Crm = crm;
            ValorHoraExtra = valorHoraExtra;
            Especialidade = especialidade;
        }

        public override void CalculoSalario()
        {
            double valorAuxilio = (Salario * 20) / 100;
            
            Salario = Salario + valorAuxilio + valorAuxilio;
            Console.WriteLine($"Valor do salário com todos os acréscimos: {Salario}");
        }

    }
}
