using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCorrentista
{

    // Classe Conta 
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        //Métodos
        public string VerSaldo()
        {
            return $"O saldo do correntista: {Titular}, conta número: {Numero} é de: R${Saldo}";
            // return "O saldo do correntista: " + Titular + ", conta número: " + Numero.ToString() + " é de " + Saldo.ToString();
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;

        }

        public void Transferir(double valor, Conta Destino)
        {
            Saldo -= valor;

            Destino.Saldo += valor;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Criar dois correntistas
            Conta correntista1 = new Conta();
            Conta correntista2 = new Conta();

            // Atribuir dados aos correntistas
            correntista1.Numero = 1000;
            correntista1.Titular = "Wagner";
            correntista1.Saldo = 1000.0;

            correntista2.Numero = 1001;
            correntista2.Titular = "Cris";
            correntista2.Saldo = 1000.0;

            // Verificar saldo dos correntistas
            Console.WriteLine(correntista1.VerSaldo());
            Console.WriteLine(correntista2.VerSaldo());

            // adicionar valor à conta dos correntistas
            correntista1.Depositar(100);
            correntista2.Depositar(200);

            // verificar o saldo dos correntistas após o depósito
            Console.WriteLine("Após Depósito: ");
            Console.WriteLine($"O saldo do correntista 1: {correntista1.VerSaldo()}");
            Console.WriteLine(correntista1.VerSaldo());
            Console.WriteLine($"O saldo do correntista 2: {correntista1.VerSaldo()}");
            Console.WriteLine(correntista2
                .VerSaldo());

            //manter a console aberta até digitar algo
            Console.ReadKey();

        }
    }
}