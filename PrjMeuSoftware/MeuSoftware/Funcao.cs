using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSoftware
{
    class Funcao
    {
        public int CalcularIdade(DateTime dataNascimento, DateTime hoje)
        {
            int idade = hoje.Year - dataNascimento.Year;

            if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day))

                idade--;

            return idade;
        }

    }
}
