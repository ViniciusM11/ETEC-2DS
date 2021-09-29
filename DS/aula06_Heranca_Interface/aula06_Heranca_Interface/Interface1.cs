using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6_Heranca_Interface
{
    // Interface adiciona recursos a aplicação
    // implementa funcionalidades
    // A Interface é um "Contrato" com  a aplicação
    interface IRecursos
    {

        string Falar(string falar);

        void Parar();

        string Andar();
    }
}
