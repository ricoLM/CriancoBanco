using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoAbstractEArrumandoProgram.Funcionarios
{
    internal abstract  class  Funcionaarios
    {

        public static double TotaldeFuncionarios { get; private set; }

        public Funcionaarios(double salario, string cpf)
        {

            Salario = salario;
            Cpf = cpf;

            TotaldeFuncionarios++;
        }

        public abstract void AumentarSalario();
        


        public double Salario { get; protected set; }
        public string Cpf { get; protected set; }





        public string Nome { get; set; }

        public abstract double GetBonificacao();
        




    }
}
