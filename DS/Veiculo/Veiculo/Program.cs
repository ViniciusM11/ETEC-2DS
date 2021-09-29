using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Veiculo
{
    // Classe Veiculo
    class Veiculo
    {
        //atributo
        public string Placa { get; set; }

        //método
        public bool DefinirPlaca(string placa)
        {
            Regex rgx = new Regex("^[A-Z]{3}[0-9]{4}||[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}$"); // valida a placa, se estiver tudo conforme, retorna verdadeiro

            if (rgx.Match(placa).Success)
            {
                Placa = placa;
                return true;
            }
            return false;

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            if (veiculo.DefinirPlaca("RMX7C25"))
            {
                Console.WriteLine($"Aluno {veiculo.Placa} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar placa!");
            }
        }
    }
}
