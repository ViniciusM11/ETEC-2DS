using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpto.MeuProjeto
{
    // classe abstrata não permite a criação de objetos
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Nacionalidade { get; set; }

        // Para que um método possa ser sobrescrito (overriding)
        // precisa recever o comando virtual
        public virtual string DefinirNome(string nome)
        {
            Nome = nome;
            return $"Seu nome é: {Nome}";
        }

    }
}

