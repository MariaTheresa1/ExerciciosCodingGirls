using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        // ****** Aula 03 - Operadores de Comparação ou Relacionais ******

        /* 1. Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
         * A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
         * As notas consideradas são de 100, 50, 20, 10, 5, 2.
         */
        public static void Aula03_01()
        {
            float valorDoSaque, cont;
            int notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0, notas2 = 0;

            Console.Write("Qual o valor que você deseja sacar?: ");
            valorDoSaque = float.Parse(Console.ReadLine());

            cont = valorDoSaque;

            while (cont > 0)
            {
                if (cont - 100 >= 0)
                {
                    cont -= 100;
                    notas100++;
                }
                else if (cont - 50 >= 0)
                {
                    cont -= 50;
                    notas50++;
                }
                else if (cont - 20 >= 0)
                {
                    cont -= 20;
                    notas20++;
                }
                else if (cont - 10 >= 0)
                {
                    cont -= 10;
                    notas10++;
                }
                else if (cont - 5 >= 0)
                {
                    cont -= 5;
                    notas5++;
                }
                else if (cont - 2 >= 0)
                {
                    cont -= 2;
                    notas2++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("NOTAS");
            Console.WriteLine($"{notas100} nota(s) de 100");
            Console.WriteLine($"{notas50} nota(s) de 50");
            Console.WriteLine($"{notas20} nota(s) de 20");
            Console.WriteLine($"{notas10} nota(s) de 10");
            Console.WriteLine($"{notas5} nota(s) de 5");
            Console.WriteLine($"{notas2} nota(s) de 2");

            Console.ReadLine();

        }
        /* 2. Faça um programa que leia três valores e apresente o maior dos três valores lidos 
         * seguido da mensagem “x é o maior”.
         */
        public static void Aula03_02()
        {
            float maior;
            float[] num = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                num[i] = float.Parse(Console.ReadLine());
            }

            maior = num[0];

            if (num[0] >= num[1] && num[0] >= num[2])
            {
                maior = num[0];
            }
            else if (num[1] >= num[0] && num[1] >= num[2])
            {
                maior = num[1];
            }
            else if (num[2] >= num[0] && num[2] >= num[1])
            {
                maior = num[2];
            }

            Console.WriteLine($"O {maior} é o número maior.");

            Console.ReadLine();
        }
        /* 3. Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
         * Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. 
         * Imprima se o aluno foi aprovado ou reprovado considerando a média 7.
         */
        public static void Aula03_03()
        {
            float soma = 0;
            float[] nota = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                nota[i] = float.Parse(Console.ReadLine());
                soma += nota[i];
            }
            if (soma / 3 >= 7)
                Console.WriteLine("Aprovado.");
            else
                Console.WriteLine("Reprovado.");

            Console.ReadLine();
        }
        /* 4. Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
        - Se a nota for menor que 6.0, deve exibir a nota F.
        - Se a nota for de 6.0 até 7.0, deve exibir a nota D.
        - Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
        - Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
        - Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
        - Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns 
          para aprovação ou algo mais complexo.
         */
        public static void Aula03_04()
        {
            float media, soma = 0;
            int quant = 3;
            float[] nota = new float[quant];

            for (int i = 0; i < quant; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                nota[i] = float.Parse(Console.ReadLine());
                soma += nota[i];
            }
            media = soma / quant;
            if (media < 6.0)
            {
                Console.WriteLine("Nota F");
            }
            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine("Nota D");
            }
            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine("Nota C");
            }
            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine("Nota B");
            }
            else if (media >= 9.0 && media < 10.0)
            {
                Console.WriteLine("O aluno tirou A. Parabéns!");
            }

            Console.ReadLine();

        }
        /* 5. A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
         - Salário de 0 até 400.00 ganha 15% 
         - Salário de 400.01 até 800.00 ganha 12% 
         - Salário de 800.01 até 1200.00 ganha 10% 
         - Salário de 1200.01 até 2000.00 ganha 7% 
         - Acima de 2000.00 ganha 4%
         * Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor 
         * de reajuste ganho e o índice reajustado, em percentual.
         */
        public static void Aula03_05()
        {
            float salario, perc = 0.0f, aumento;
            Console.Write("***** Bem-vindo! *****\nDigite seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 400)
            {
                perc = 0.15f;
            }
            else
            {
                if (salario > 401 && salario <= 800)
                {
                    perc = 0.12f;
                }
                else
                {
                    if (salario > 800 && salario <= 1200)
                    {
                        perc = 0.1f;
                    }
                    else
                    {
                        if (salario > 1200 && salario < 2000)
                        {
                            perc = 0.07f;
                        }
                        else
                        {
                            if (salario > 2000)
                            {
                                perc = 0.04f;
                            }
                            else
                            {
                                Console.WriteLine("Salário inválido");
                            }
                        }
                    }
                }
            }
            aumento = salario * perc;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Seu salário antes: {salario:0.00}");
            Console.WriteLine($"Percentual: {perc * 100}%");
            Console.WriteLine($"Valor do aumento: {aumento:0.00}");
            Console.WriteLine($"Seu salário reajustado: {salario += aumento:0.00}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Aula03_01();
            //Aula03_02();
            //Aula03_03();
            //Aula03_04();
            //Aula03_05();
        }
    }
}
