using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpto.MeuProjeto
{
    class PessoaJuridica : Pessoa
    {
        public long CNPJ { get; set; }
        public long IE { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        // para sobrescrever o método da classe pai
        // precisa do comando override
        public override string DefinirNome(string nome)
        {
            Nome = nome;
            return $"Seu nome é: {Nome}, e é uma Pessoa Juridica";
        }
    }
}

