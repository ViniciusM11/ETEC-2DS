using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importar namespace
using aula6_Heranca_Interface;

namespace Xpto.MeuProjeto
{
    class PessoaFisica : Pessoa, IRecursos
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public long CPF { get; set; }
        public string RG { get; set; }

        // para sobrescrever o método da classe pai
        // precisa do comando override
        public override string DefinirNome(string nome)
        {
            Nome = nome;
            return $"Seu nome é: {Nome}, e é uma Pessoa Física";
        }

        // adicionar recursos obrigatórios da interface IRecursos
        string IRecursos.Andar()
        {
            return $"Estou andando.";
        }

        string IRecursos.Falar(string falar)
        {
            return $"Estou andando.";
        }

        void IRecursos.Parar()
        {

        }


    }

}
