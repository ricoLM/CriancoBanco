using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoAbstractEArrumandoProgram.Funcionarios
{
    internal class Designer : Funcionaarios
    {
    
        public Designer ( string cpf) : base (4000, cpf)
        {

        }
        
        public override void AumentarSalario()
        {
            Salario = Salario + Salario * 0.28;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.10;
        }




    }
}   
