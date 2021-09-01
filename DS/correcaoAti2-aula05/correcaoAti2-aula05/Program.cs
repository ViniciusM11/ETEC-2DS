using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace correcaoAti2_aula05
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        // referência da classe Turma
        public Turma Turma { get; set; }

        // nome precisa de nome e sobrenome
        public bool DefinirNome(string nome)
        {
            // limpar a variável
            nome.Trim();

            // objeto para tratar expressões regulares
            Regex rgx = new Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");

            if (rgx.Match(nome).Success)
            {
                Nome = nome;
                return true;
            }

            return false;
        }

        public string ObterNome()
        {
            return $" O nome do aluno é {Nome}";
        }  

        public bool DefinirMatricula(int matricula)
        {
            Regex rgx = new Regex("^(?=.*\\d)[\\d]{4,6}$");

            if (rgx.Match(matricula.ToString()).Success)
            {
                Matricula = matricula;
                return true;
            }
           
            return false;
        }
    }
    class Turma
    {
        public string Codigo { get; set; }
        public string Sala { get; set; }
        public string Periodo { get; set; }
        public bool Ativa { get; set; }

        public bool Ativar(int estado)
        {
            if (estado == 1)
            {
                Ativa = true;
                return true;
            }
            Ativa = false;
            return false;
        }

        public bool AtribuirProfessor(Professor professor)
        {
            professor.Turma = this;
            if (professor.Turma.Codigo != string.Empty)
            {
                return true;
            }

            return false;
        }

        public bool AtribuirAluno(Aluno aluno)
        {
            aluno.Turma = this;
            if (aluno.Turma.Codigo != string.Empty)
            {
                return true;
            }

            return false;
        }

    }
    class Professor
    {
        public string Nome { get; set; }
        public string Titulacao { get; set; }
        public Turma Turma { get; set; }

        public bool DefinirNome(string nome)
        {
            // limpar a variável
            //nome.Trim();

            // objeto para tratar expressões regulares
            Regex rgx = new Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");

            if (rgx.Match(nome).Success)
            {
                Nome = nome;
                return true;
            }

            return false;
        }

        public string ObterNome()
        {
            return $" O nome do professor é {Nome}";
        }

        public bool DefinirTitulacao(string titulacao)
        {
            if(titulacao != string.Empty)
            {
                Titulacao = titulacao;
                return true;
            }
            
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // criar um aluno
            Aluno aluno = new Aluno();

            // definir um aluno 
            if (aluno.DefinirNome("Vinicius Martins"))
            {
                Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar aluno!");
            }

            // definir matricula, matricular aluno
            if (aluno.DefinirMatricula(1000))
            {
                Console.WriteLine($"Aluno {aluno.Nome} matriculado sob numero {aluno.Matricula}");
            }
            else
            {
                Console.WriteLine("Erro ao matricular aluno!");
            }


           

            // cadastrar professores
            Professor prof1 = new Professor();
            Professor prof2 = new Professor();

            if (prof1.DefinirNome("Cristiano Correa"))
            {
                Console.WriteLine($"Professor {prof1.Nome} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar Professor!");
            }


            if (prof2.DefinirNome("Wagner Barth"))
            {
                Console.WriteLine($"Professor {prof2.Nome} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar Professor!");
            }

            // definir titulacao prof
            if (prof1.DefinirTitulacao("Informática"))
            {
                Console.WriteLine($"Titulação {prof1.Titulacao} cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar titulação!");
            }

            if (prof1.DefinirTitulacao("Eletrônica"))
            {
                Console.WriteLine($"Titulação {prof2.Titulacao} cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar titulação!");
            }

            // criar duas turmas
            Turma turma1 = new Turma
            {
                Codigo = "Turma 1",
                Sala = "Sala 1",
                Periodo = "Noite",
                Ativa = true,
            };

            Turma turma2 = new Turma
            {
                Codigo = "Turma 2",
                Sala = "Sala 2",
                Periodo = "Matutino",
                Ativa = false,
            };

            

            // professor e aluno recebe turma 1
            prof1.Turma = turma1;
            aluno.Turma = turma1;

            //atribuir professor utilizando o metodo
            if (turma2.AtribuirProfessor(prof2))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("deu ruim");
            }

            Console.WriteLine($"O aluno: {aluno.Nome} está matriculado na turma: {aluno.Turma.Codigo}");

            Console.WriteLine($"O professor: {prof2.Nome} está cadastrado na turma: {prof2.Turma.Codigo}");


            Console.ReadKey();
        }
    }
}
