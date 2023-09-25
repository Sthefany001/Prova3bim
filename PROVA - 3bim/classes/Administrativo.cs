using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA___3bim.classes
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo() { }

        public Administrativo (string funcao, string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario) : base(nome, cpf, matricula, dataNasc, sexo, salario)
        {
            Funcao = funcao;
        }

        public override void CalculoSalario()
        {
            double valeTransporte = 150;
            double valeAlimento = (Salario * 15) / 100;

            Salario = Salario + valeTransporte + valeAlimento;

            Console.WriteLine($"Valor do Salário com todos os acréscimos: {Salario}");
        }
    }
}
