using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoAbstractEArrumandoProgram.Funcionarios
{
    internal class Diretor : Funcionaarios
    {
        public Diretor( string Cpf) : base(6000, Cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario = Salario + Salario * 0.15;
        }



        public override double GetBonificacao()
        {

            return Salario * 0.30;
        }

    }
}
