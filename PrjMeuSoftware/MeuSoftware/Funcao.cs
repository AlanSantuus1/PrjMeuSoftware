using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSoftware
{
    class Funcao
    {
        public double CalcularIRRF(double salarioBruto)
        {
            double irrf;

            if (salarioBruto <= 1903.98)
            {
                Console.WriteLine("Isento");

            }
            else if (salarioBruto <= 2826.65)
            {
                irrf = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 3751.05)
            {
                irrf = salarioBruto * 0.15;
            }
            else if (salarioBruto <= 4664.68)
            {
                irrf = salarioBruto * 0.225;
            }
            else
            {
                irrf = salarioBruto * 0.275;
            }

            return irrf;

        }

        public int CalcularIdade(DateTime dataNascimento, DateTime hoje)
        {
            int idade = hoje.Year - dataNascimento.Year; //subtrai o ano atual pelo ano de nascimento

            if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day)) 
                // verificação do dia e mês atual caso sejam menores ou iguais a data atual

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
                imposto = salarioBruto * 0.09;
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
        public double CalcularFGTS(double salarioBruto)
        {
            double descontoPorMes;//Valor descontado por mês do FGTS

            descontoPorMes = salarioBruto * 0.08;

            return descontoPorMes;
        }
               

    }
}
