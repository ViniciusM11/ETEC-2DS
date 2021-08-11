using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            int num1; //explicita
            var num2 = 10.2; //implicita (inferência de dados)

            //atribuir valores a variáveis
            num1 = 2;

            //imprimir na tela
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //conversão de dados
            //Conversão Implicita, onde não há perda de dados
            int ano = 2020;
            double ano2 = ano;

            Console.WriteLine(ano2);

            //Conversão Implicita, onde há perda de dados
            decimal taxa = 12.98m;
            int taxa2 = (int)taxa;

            Console.WriteLine(taxa2);

            //Conversão de valores textuais em numéricos
            string resposta = "12";
            int idade = int.Parse(resposta);

            int idade2 = Convert.ToInt32(resposta);

            //Concatennação de Strings
            string nome = "Joel";
            string sobrenome = "Miller";
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine(nomeCompleto);

            //Concatenação usando interpolaçao de Strings
            string nomeCompleto2 = $"O seu nome é: {nome} {sobrenome}";
            Console.WriteLine(nomeCompleto2);

            //Métodos adicionais para Strings
            string fruta = "abacaxi";
            string frutaModif = fruta.ToUpper(); //tudo maiusculo
            string frutaModif2 = frutaModif.ToLower(); //tudo minusculo
            string frutaModif3 = fruta.Substring(2,4);

            //IndexOf = posicação de uma letra
            //Contains = verifiicar se contém a letra na string

            Console.WriteLine(frutaModif3);

            //Manipulação de datas usando tipos de dados DateTime
            DateTime hoje = DateTime.Now; //DateTime é um tipo 
            Console.WriteLine(hoje);

            //passar valores de datas para objetos
            DateTime data = new DateTime(2021, 08, 10, 21, 27, 55);
            Console.WriteLine(data.Year);

            //converter data em string para DateTime
            data = DateTime.Parse("14/09/2009 12:12:12");
            Console.WriteLine(data.ToShortDateString());

            //Vetores (Arreys)
            int[] numeros = new int[3];
            numeros[0] = 11;
            numeros[1] = 12;
            numeros[2] = 13;

            Console.WriteLine(numeros[1]);

            int[] numeros2 = new int[3] { 1, 2, 3 };
            Console.WriteLine(numeros2[1]);

            int[] numeros3 = new int[] { 5, 6, 7, 8 };
            Console.WriteLine(numeros3[3]);

            //criar um vetor com as novas versões do C#
            int[] num = { 99, 98, 97 };
            Console.WriteLine(num[2]);

            //criar um vetor por inferência de dados
            var cidades = new[] { "SP", "RJ", "MG" };
            Console.WriteLine(cidades[0]);


            //O método ReadKey() fica aguardando uma tecla ser pressionada e está 
            //é armazenada, se necessário em uma variável.
            Console.ReadKey();
        }
    }
}
