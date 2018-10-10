using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5L1DoWhilePesquisaHabitantes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             5.	A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
                coletando dados sobre o salário e o número de filhos. A prefeitura deseja saber:
                a.	A média do salário da população;
                b.	A média do número de filhos
                c.	O maior salário;
                d.	A percentagem de pessoas com salários até R$ 1000,00;
                Para finalizar a leitura dos dados, o usuário deverá fornecer o salário negativo.
             */

            Console.WriteLine("Pesquisa");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            int nota = 0;

            double salario = 0;
            int nrFilhos = 0;

            double somaSalario = 0;
            double somaFilhos = 0;

            int qtdePessoasPesquisadas = 0;

            double maiorSalario = int.MinValue;

            int qtdeSalariosMenores1000 = 0;

            char op = 'N';

            do
            {
                Console.Write("Digite o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());

                if (salario >= 0)
                {
                    Console.Write("Digite o número de filhos: ");
                    nrFilhos = Convert.ToInt32(Console.ReadLine());

                    somaSalario += salario;
                    somaFilhos += nrFilhos;

                    qtdePessoasPesquisadas++;

                    // Encontrar o maior salário
                    if (salario > maiorSalario)
                    {
                        maiorSalario = salario;
                    }

                    // Conta os salários até 1000
                    if (salario <= 1000)
                    {
                        qtdeSalariosMenores1000++;
                    }

                }
    
            } while (salario >= 0);

            Console.WriteLine();
            Console.WriteLine("--------- Resultado -----------");

            double mediaSalario = (double) somaSalario/qtdePessoasPesquisadas;
            Console.WriteLine("A média do salário da população: " + mediaSalario);

            double mediaFilhos = (double) somaFilhos / qtdePessoasPesquisadas;
            Console.WriteLine("A média do número de filhos: " + mediaFilhos);

            Console.WriteLine("O maior salário: " + maiorSalario);

            double percentagemSalarios1000 = ((double) qtdeSalariosMenores1000 / qtdePessoasPesquisadas) * 100;
            Console.WriteLine("A percentagem de pessoas com salários até R$ 1000,00: " + percentagemSalarios1000 + "%");

            Console.ReadKey();

        }
    }
}
