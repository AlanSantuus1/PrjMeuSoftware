using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            int dataNascimento;
            int numeroDependentes;
            string cargo;
            double salarioBruto;
            char recebeValeTransporte;
            string valetrans = ""; // Variavel auxiliar para checagem, caso o funcionário receba Vale Transporte




            Console.WriteLine("Seja Bem-Vindo !");

            Console.WriteLine("Digite o nome completo do novo funcionário:");
            nomeCompleto = Console.ReadLine(); // Recebe o nome completo do funcionário
            Console.Clear();

            Console.WriteLine("Digite a data de nascimento do funcionário neste formato DDMMAAA (não separe os números por barras):");
            dataNascimento = int.Parse(Console.ReadLine()); // Recebe a data de nascimento do funcionário
            Console.Clear();

            Console.WriteLine("Informe o número de dependes do funcionário:");
            numeroDependentes = int.Parse(Console.ReadLine()); // Recebe o número de dependentes do funcionário
            Console.Clear();

            Console.WriteLine("Informe o cargo do funcionário:");
            cargo = Console.ReadLine(); // Recebe o nome do cargo do funcionário
            Console.Clear();

            Console.WriteLine("Informe o salário bruto do funcionário:");
            salarioBruto = double.Parse(Console.ReadLine()); // Recebe o salário bruto do funcionário
            Console.Clear();

            Console.WriteLine("Informe se o funcionário recebe Vale Transporte: (s/n)");
            recebeValeTransporte = char.Parse(Console.ReadLine()); // Informa se o funcionário recebe vale transporte
            Console.Clear();


            // Checagem de resultado caso funcionário receba ou não Vale Transporte
            switch (recebeValeTransporte)
            {
                case 's':
                    valetrans = "recebe";
                    break;

                case 'n':
                    valetrans = "não recebe";
                    break;
            }
                       

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Seja Bem Vindo {0} !", nomeCompleto);
            Console.WriteLine("Seu código de acesso é " + dataNascimento + "2019 !");
            Console.WriteLine("Você tem {0} dependente(s) !", numeroDependentes);
            Console.WriteLine("Seu cargo na empresa é: {0} !", cargo);
            Console.WriteLine("Seu salário bruto é: {0} !", salarioBruto);
            Console.WriteLine("Você {0} Vale Transporte !", valetrans);


            Console.ReadKey();
        }
    }
}
