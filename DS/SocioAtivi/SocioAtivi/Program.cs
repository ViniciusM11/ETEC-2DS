using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocioAtivi
{
    // Classe Socio
    class Socio
    {
        // Atributos
        public string NomeSocio { get; set; }
        public string EnderecoSocio { get; set; }
        public string TelefoneSocio { get; set; }
        public DateTime DataNascSocio { get; set; }
         
        // Método Registrar
        public int Registrar()
        {
            return 0;
        }
        // Método Consultar
        public int Consultar()
        {
            return 0;
        }
    }

    // Classe Dependente
    class Dependente
    {
        // Atributos
        public string NomeDep { get; set; }
        public DateTime DataNascDep { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
