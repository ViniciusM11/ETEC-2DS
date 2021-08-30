using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    // Classe Conta
    class Conta
    {
        // Atributos
        private int Agencia { get; set; }
        private string ContaCorrente { get; set; }


        // Métodos
        public void Depositar(float valor)
        {

        }

        public float Saldo(int saldo)
        {
            return saldo;
        }
    }

    // Classe ContaPoupanca
    class ContaPoupanca
    {
        // Atributos
        private int DiaDeposito { get; set; }

        // Métodos
        public float VerLucro()
        {
            return 0;
        }

    }

    // Classe Cliente
    class Cliente
    {
        // Atributos
        private int CPF { get; set; }
        private string Nome { get; set; }
        private string Telefone { get; set; }

        // Métodos
        public int MostrarCPF()
        {
            return this.CPF;
        }

        public void VerSaldo(int saldo)
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            Cliente cliente = new Cliente();
        }
    }
}