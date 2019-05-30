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
        public double CalcularINSS(double salarioBruto)
        {
            double imposto;//Valor do imposto de acordo com o valor do salario bruto

            if (salarioBruto <= 1693.72)
            {
                imposto = salarioBruto * 0.08;
            }
            else if (salarioBruto > 1693.72 && salarioBruto <= 2822.90)
            {
                imposto = salarioBruto * 0.08;
            }
            else if (salarioBruto > 2822.90 && salarioBruto <= 5645.80)
            {
                imposto = salarioBruto * 0.11;
            }
            else
            {
                imposto = 621.04;
            }

            return imposto;
        }

    }
}
