using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6_Construtores
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }
        public long CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string EstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        public long CNPJ { get; set; }
        public long IE { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        // construtor padrão - declação explicita
        public Pessoa() { }

        // Sobrecarga de Métodos (Method Overload)
        // Métodos que possuem a mesma assinatura, porém com diferentes parâmetros
        public Pessoa(string nome, double altura)
        {
            Nome = nome;
            Altura = altura;
        }

        public void Escrever()
        {
            Console.WriteLine("oi");
        }

        public void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa(); // utilizando construtor padrão
            Pessoa pessoa2 = new Pessoa("Vinicius", 1.88); // utilizando contrutor de sobrecarga

            Pessoa pessoa3 = new Pessoa
            {
                Nome = "João",
                Altura = 1.74,
                Sexo = "M"
            };

            // Utilizando os métodos com sobrecarga
            pessoa1.Escrever();

            pessoa1.Escrever("Olá Mundo");

            Console.WriteLine(pessoa3.Nome + " " + pessoa3.Altura + " " + pessoa3.Sexo);

            Console.ReadKey();

        }
    }
}
