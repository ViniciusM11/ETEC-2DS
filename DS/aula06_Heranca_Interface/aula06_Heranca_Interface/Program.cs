using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importar namespace
using Xpto.MeuProjeto;

namespace aula6_Heranca_Interface
{


    class Program
    {
        static void Main(string[] args)
        {
            // não é possível criar objtos a partir de uma classe abstrata
            // Pessoa p1 = new Pessoa();

            PessoaFisica pf = new PessoaFisica();

            PessoaJuridica pj = new PessoaJuridica
            {
                NomeFantasia = "JJ GAMES",
                CNPJ = 761235430001
            };

            Console.WriteLine(pf.DefinirNome("Vinicius"));
            Console.WriteLine(pj.DefinirNome("Vinicius") + " " + pj.NomeFantasia);

            IRecursos pf2 = new PessoaFisica();

            Console.WriteLine(pf2.Andar());

            Console.ReadKey();
        }
    }
}

