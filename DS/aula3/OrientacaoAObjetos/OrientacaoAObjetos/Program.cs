using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    // classes de modelagem
    class Usuario
    {
        // Atributos
        public string Nome { get; set; } // getters e setters auto implementados
                                         // metodo antigo
                                         //private string _nome;
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        // construtor default não precisa ser declarado
        public Usuario() { }

        // Método Getters Setters Tradicional
        /*Getters
        public string GetNome()
        {
        // atribuir o valor do parametro "nome" ao atributo "nome"
        return this.Nome;
        }

         // Setters
        public void SetNome(string nome)
        {
        // regra de proteção
        if (nome != "")
        {
        this.Nome = nome;
        }
        else
        {
        this.Nome = "Nome não foi preenchido";
        }
        }
        */

        // metodo antigo de getter e setter
        /*public string nome
        {
        get { return _nome; }
        set { _nome = value; }
        }
        */

        public void SetNome(string nome)
        {
            if (nome != "")
            {
                this.Nome = nome;
            }
            else
            {
                this.Nome = "Nome não foi preenchido";
            }
        }

        // Métodos
        public void ProvarExistencia()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // instanciar um objeto a partir da classe Usuario
            Usuario usuario = new Usuario();

            usuario.SetNome("");

            Console.WriteLine(usuario.Nome);

            Console.ReadKey();

        }
    }
}
