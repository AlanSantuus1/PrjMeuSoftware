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
            string dataNascimento = ""; // variavel iniciada para não gerar conflito 
            DateTime hoje = DateTime.Now; // variavel para o sistema pegar a data atual
            int numeroDependentes;
            string cargo;
            double salarioBruto;
            char recebeValeTransporte;
            string valetrans = ""; // Variavel auxiliar para checagem, caso o funcionário receba Vale Transporte
            char saida = ' '; // variável de condição de saída do programa


            Funcao objFuncao = new Funcao(); // chama a função para o projeto


            Console.WriteLine("Seja Bem-Vindo !");


            do
            {

                Console.WriteLine("Digite o nome completo do novo funcionário:");
                nomeCompleto = Console.ReadLine(); // Recebe o nome completo do funcionário
                Console.Clear();

                try // Falta gerar um loop para permanecer na questão até que seja dada a resposta certa
                {
                    Console.WriteLine("Digite a data de nascimento do funcionário neste formato DD/MM/AAA:");
                    dataNascimento = DateTime.Parse(Console.ReadLine()).ToString("dd/MM/yyyy"); // Recebe a data de nascimento do funcionário 
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.Replace("Cadeia de caracteres não foi reconhecida como DateTime válido.", "Formato de Data inválido, tente novamente !"));
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Informe o número de dependes do funcionário:");
                numeroDependentes = int.Parse(Console.ReadLine()); // Recebe o número de dependentes do funcionário
                Console.Clear();

                Console.WriteLine("Informe o cargo do funcionário:");
                cargo = Console.ReadLine(); // Recebe o nome do cargo do funcionário
                Console.Clear();

                Console.WriteLine("Informe o salário bruto do funcionário:");
                salarioBruto = double.Parse(Console.ReadLine()); // Recebe o salário bruto do funcionário
                Console.Clear();

                Console.WriteLine("Informe se o funcionário recebe Vale Transporte: (s/n)");  // Falta gerar um loop para permanecer na questão até que seja dada a resposta certa
                recebeValeTransporte = char.Parse(Console.ReadLine()); // Informa se o funcionário recebe vale transporte

                
                if (recebeValeTransporte == 's' || recebeValeTransporte == 'S') // Validação de resposta sobre Vale Transporte
                {
                    valetrans = "recebe";
                }
                else if (recebeValeTransporte == 'n' || recebeValeTransporte == 'N')
                {
                    valetrans = "não recebe";
                }
                else
                {
                    Console.WriteLine("Informação incorreta !");
                    Console.WriteLine("Pressione qualquer tecla pra continuar...");
                    Console.ReadKey();
                }

                Console.WriteLine("Pressione a tecla 's' para sair ou 'n' para refazer...");
                saida = char.Parse(Console.ReadLine());
                Console.Clear();


            } while (saida != 's');



            Console.Clear();            

            Console.WriteLine("Seja Bem Vindo {0} !", nomeCompleto);
            Console.WriteLine("Seu código de acesso é " + dataNascimento.Replace("/", "") + "2019 !");
            Console.WriteLine("Você tem {0} anos de idade ", objFuncao.CalcularIdade(DateTime.Parse(dataNascimento), hoje)); // faz o cálculo da idade do funcionário
            Console.WriteLine("Você tem {0} dependente(s) !", numeroDependentes);
            Console.WriteLine("Seu cargo na empresa é: {0} !", cargo);
            Console.WriteLine("Seu salário bruto é: {0} !",  salarioBruto);
            Console.WriteLine("Você {0} Vale Transporte !", valetrans);


            Console.ReadKey();



        }
    }
}
