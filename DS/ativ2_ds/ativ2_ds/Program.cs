using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ativ2_ds

{

    class Turma

    {

        // Atributos 

        public string Codigo { get; set; }

        public string Sala { get; set; }

        public string Periodo { get; set; }

        public bool Ativa { get; set; }



        // Métodos 

        public bool Ativar(int ativa)

        {

            return this.Ativa;

        }



        public bool AtribuirProfessor(Professor)

        {

            return true;

        }



        public bool AtribuirAluno(Aluno)

        {

            return true;

        }

    }



    class Aluno

    {

        public string Nome { get; set; }

        public int Matricula { get; set; }



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



    class Professor

    {

        public string Nome { get; set; }

        public string Titulacao { get; set; }





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
