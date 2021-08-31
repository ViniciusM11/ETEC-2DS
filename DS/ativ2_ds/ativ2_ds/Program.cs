using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ativ2_ds

{
    // Classe Turma

    class Turma

    {

        // Atributos 

        private string Codigo { get; set; }

        private string Sala { get; set; }

        private string Periodo { get; set; }

        private bool Ativa { get; set; }



        // Métodos 

        public bool Ativar(int ativa)

        {

            return this.Ativa;

        }



        public bool AtribuirProfessor(Professor Professor)

        {

            return true;

        }



        public bool AtribuirAluno(Aluno Aluno)

        {

            return true;

        }

    }


    // Classe Aluno

    class Aluno

    {
        // Atributos 

        private string Nome { get; set; }

        private int Matricula { get; set; }


        // Métodos

        public bool DefinirNome(string Nome)

        {

            return true;

        }



        public string ObterNome() 

        {

            return Nome;

        }



        public bool DefinirMatricula(int Matricula)

        {

            return true;

        }



    }

    // Classe Professor

    class Professor

    {
        // Atributos 

        private string Nome { get; set; }

        private string Titulacao { get; set; }


        // Métodos

        public bool DefinirNome(string Nome)

        {

            return true;

        }



        public string ObterNome()

        {

            return Nome;

        }



        public bool DefinirTitulacao(string Titulacao)

        {

            return true;

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

        }

    }

}
