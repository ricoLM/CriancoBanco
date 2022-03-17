using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoAbstractEArrumandoProgram.Funcionarios
{
    internal class Contador : Funcionaarios
    {
    
        public Contador ( string cpf  ) : base (3000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario = Salario + Salario * 0.15;
        }

        public override double GetBonificacao()
        {
           return Salario *= 0.5 ;
        }





    }
}
