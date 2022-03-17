using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsandoAbstractEArrumandoProgram.Funcionarios;
namespace UsandoAbstractEArrumandoProgram
{
    internal class GerenciadorDeBonus
    {

        private double Totaldebonificacao;
       
    
        public void Registrar (Funcionaarios funcionaarios)
        {
            Totaldebonificacao += funcionaarios.GetBonificacao ();
        }

        public double totaldeBonificacao()
        {
            return Totaldebonificacao;
        }
       

    }
}
