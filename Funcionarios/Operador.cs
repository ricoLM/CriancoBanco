using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoAbstractEArrumandoProgram.Funcionarios
{
    internal class Operador : Funcionaarios
    {
        public Operador(string cpf) : base(3300, cpf)
        {
        
        
        
        }


        public override void AumentarSalario()
        {

            Salario = Salario + Salario * 0.20;

        }

        public override double GetBonificacao()
        {
            return  Salario * 0.10;
        }




    }
}
