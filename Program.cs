using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsandoAbstractEArrumandoProgram.Funcionarios;
namespace UsandoAbstractEArrumandoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            totaldebonificacao();
            Console.ReadLine();
        }
    
    public static void totaldebonificacao ()
        {

            GerenciadorDeBonus gerenciadordebonificacao = new GerenciadorDeBonus();

            Funcionaarios arthur = new Contador("342.233.555-32");
            arthur.Nome = "Arthur";

            Funcionaarios enrico = new Diretor("424.625.658-76");
            enrico.Nome = "Enrico";

            Funcionaarios pedro = new Designer("234.221.345-56");
            pedro.Nome = "Pedro";


            Funcionaarios jorge = new Operador("444.657.435-43");
            jorge.Nome = "Jorge";

            gerenciadordebonificacao.Registrar(jorge);
            gerenciadordebonificacao.Registrar(pedro);
            gerenciadordebonificacao.Registrar(enrico);
            gerenciadordebonificacao.Registrar(arthur);

            Console.WriteLine("A bonificação geral é: " + gerenciadordebonificacao.totaldeBonificacao());
        }
    
    
    
    }
}
