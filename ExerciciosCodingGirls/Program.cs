using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodingGirls
{
    internal class Program
    {

        // ****** Aula 01 - Fundamentos de C# ******
        // 1. Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
        public static void Aula01_01()
        {
            string nome = "Maria Theresa de Sousa Ferreira";
            string endereco = "Rua Sem Nome, número 00, Bairro: Centro, Cidade: Bertolínia - Piauí";
            string CEP = "64870-000";
            string telefone = "(89) 91122-1122";

            Console.WriteLine(nome);
            Console.WriteLine(endereco);
            Console.WriteLine(CEP);
            Console.WriteLine(telefone);

            Console.ReadLine();

        }
        // 2. Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
        public static void Aula01_02()
        {
            Console.WriteLine("Margaret Hamilton");
            Console.WriteLine("Cientista da computação");
            Console.WriteLine("Foi diretora da Divisão de Software no Laboratório" +
                " de Instrumentação do MIT, que desenvolveu o programa de voo usado no " +
                "projeto Apollo 11, a primeira missão tripulada à Lua.");

            Console.ReadLine();

        }
        // 3. Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.
        public static void Aula01_03()
        {
            Console.WriteLine("Hoje eu preciso te encontrar de qualquer jeito\n" +
                "Nem que seja só pra te levar pra casa\n" +
                "Depois de um dia normal\n" +
                "Olhar teus olhos de promessas fáceis\n" +
                "E te beijar a boca de um jeito que te faça rir\n" +
                "Que te faça rir");
            Console.WriteLine("Jota Quest");
            Console.WriteLine("POP");

            Console.ReadLine();

        }
        // 4. Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.
        public static void Aula01_04()
        {
            Console.WriteLine("Vamos galera mulheres! Vamos! Girl Power *****!");

            Console.ReadLine();

        }

        // ****** Aula 02 - Conversão Implícita e Casting ******

        // 1. Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.
        public static void Aula02_01()
        {
            Console.Write("Qual é o seu ano de nascimento? ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua idade é {2022 - ano}.");

            Console.ReadLine();

        }
        // 2. Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.
        public static void Aula02_02()
        {
            int soma = 0;
            int[] v = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                v[i] = int.Parse(Console.ReadLine());
                soma += v[i];
            }
            Console.WriteLine($"A soma dos números é: {soma}");

            Console.ReadLine();
        }
        // 3. Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
        public static void Aula02_03()
        {
            int horas;
            float valorDaHora;
            Console.Write("Quantas horas você trabalhou? ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("Qual o valor por hora? ");
            valorDaHora = float.Parse(Console.ReadLine());

            //Console.WriteLine($"Você trabalhou {horas} horas e o seu salário é: R$ {(horas * valorDaHora).ToString("F2")}");
            Console.WriteLine($"Você trabalhou {horas} horas e o seu salário é: R$ {horas * valorDaHora: 00:00}");

            Console.ReadLine();
        }
        // 4. Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
        public static void Aula02_04()
        {
            int idade;
            Console.Write("Qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());
            Console.Write($"Sua idade em anos: {idade}\nSua idade em meses: {idade * 12}\nSua idade em dias: {idade * 365}");
            Console.ReadLine();

        }
        /*
         5. Construa um conversor de moedas:
            Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
            DOLAR
            EURO
            LIBRA ESTERLINA
            DÓLAR CANADENSE
            PESO ARGENTINO
            PESO CHILENO
            Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real. Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.
         */
        public static void Aula02_05()
        {
            float real;
            Console.Write("Digite o valor em real: ");
            real = float.Parse(Console.ReadLine());
            Console.Write($"DOLAR: {real / 4.87: 00.00}\nEURO: {real / 5.21: 00.00}\n" +
                $"LIBRA ESTERLINA: {real / 6.12: 00.00}\nDOLAR CANADENSE: {real / 3.88: 00.00}\n" +
                $"PESO ARGENTINO: {real / 0.04: 00.00}\nPESO CHILENO: {real / 0.0059: 00.00}");

            Console.ReadLine();

        }

        // ****** Aula 03 - Operadores de Comparação ou Relacionais ******
        // 1. Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2.
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
        // 2. Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.
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
        // 3. Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. Imprima se o aluno foi aprovado ou reprovado considerando a média 7.
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
        // 4. Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
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
        // 5. A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
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
        // ****** Aula 04 - Vetores e Matrizes ******
        // 1. Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5. Exiba os valores dos dois vetores na tela, um em cada linha.
        public static void Aula04_01()
        {
            int[] vetor = new int[10];
            int[] novo = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                novo[i] = vetor[i] * 5;
                Console.WriteLine($"{novo[i]}");
            }
            Console.ReadLine();
        }
        // 2. Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para números pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.
        public static void Aula04_02()
        {
            int[] par = new int[10];
            int[] impar = new int[10];
            int numero, indicePar = 0, indiceImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par[indicePar] = numero;
                    indicePar++;
                }
                else
                {
                    impar[indiceImpar] = numero;
                    indiceImpar++;
                }
            }

            Console.WriteLine("\n");
            for (int i = 0; i < indicePar; i++)
                Console.Write($"{par[i]} ");

            Console.WriteLine("\n");
            for (int i = 0; i < indiceImpar; i++)
                Console.Write($"{impar[i]} ");

            Console.ReadLine();

        }
        // 3. Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.
        public static void Aula04_03()
        {
            string[] palavras = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a {i + 1}ª palavra: ");
                palavras[i] = Console.ReadLine();
            }

            string[] ordenado = palavras.OrderBy(x => x.Length).ToArray();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(ordenado[i]);

            Console.ReadLine();
        }
        // 4. Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, papel e tesoura (Jokenpô) com você.
        public static void Aula04_04()
        {
            int escolhaMinha, escolhaDele; // 1 - Pedra; 2 - Papel; 3 - Tesoura 
            int vitoriasMinhas = 0, vitoriasDele = 0, opcao = 1;
            var rand = new Random();

            Console.Write("****** JOKENPÔ ******");
            while (opcao == 1)
            {
                Console.Write("\nEscolha:\n1 - Pedra, 2 - Papel ou 3 - Tesoura: ");
                escolhaMinha = int.Parse(Console.ReadLine());

                escolhaDele = rand.Next(1, 4); // 1 a 3

                if (escolhaMinha == 1)
                    Console.WriteLine("\nSua escolha: Pedra");
                if (escolhaMinha == 2)
                    Console.WriteLine("\nSua escolha: Papel");
                if (escolhaMinha == 3)
                    Console.WriteLine("\nSua escolha: Tesoura");

                if (escolhaDele == 1)
                    Console.WriteLine("Escolha do computador: Pedra");
                if (escolhaDele == 2)
                    Console.WriteLine("Escolha do computador: Papel");
                if (escolhaDele == 3)
                    Console.WriteLine("Escolha do computador: Tesoura");

                if (escolhaMinha == escolhaDele)
                {
                    Console.WriteLine("\nEmpatou.");
                }
                else if (escolhaMinha == 1 && escolhaDele == 3 || escolhaMinha == 2 && escolhaDele == 1 || escolhaMinha == 3 && escolhaDele == 2)
                {
                    Console.WriteLine("\nVocê ganhou!");
                    vitoriasMinhas++;
                }
                else
                {
                    Console.WriteLine("\nVocê perdeu.");
                    vitoriasDele++;
                }
                Console.Write("\nDeseja jogar novamente?\nDigite 1 para SIM ou outro número para NÂO: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n***** Resultado *****\n");
            if (vitoriasMinhas == vitoriasDele)
                Console.WriteLine("Empatados.");
            else if (vitoriasMinhas > vitoriasDele)
                Console.WriteLine("VOCÊ GANHOU :)");
            else
                Console.WriteLine("VOCÊ PERDEU :(");

            Console.WriteLine($"\nVocê {vitoriasMinhas} x {vitoriasDele} Computador");

            Console.ReadLine();

        }
        // 5. Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
        public static void Aula04_05()
        {
            char[,] matriz = new char[3, 3];
            char jogador1 = 'X', jogador2 = 'O', escolha;
            int marcacao, aux = 0;

            Console.WriteLine("****** JOGO DA VELHA ******");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = 'x';
                    Console.Write($"{matriz[i, j]}  ");
                }
                Console.WriteLine("");
            }

            Console.Write("Jogador 1, você escolhe 'X' ou 'O'? ");
            escolha = char.Parse(Console.ReadLine());

            do
            {
                if (escolha == 'x' || escolha == 'X')
                    jogador1 = escolha;
                else if (escolha == 'o' || escolha == 'O')
                    jogador1 = escolha;
                else
                {
                    Console.Write("Caracter inválido. Tente novamente. Digite X ou O: ");
                    escolha = char.Parse(Console.ReadLine());
                }
            } while (escolha != 'x' || escolha != 'X' || escolha != 'o' || escolha != 'O');

            if (jogador1 == 'x' || jogador1 == 'X')
                jogador2 = 'O';
            else
                jogador2 = 'X';

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    /*
                    aux++;
                    matriz[i, j] = (Char)(Convert.ToUInt16(aux) + 1);
                    Console.WriteLine(matriz[i, j]);
                    */

                    matriz[i, j] = '-';

                    Console.Write($"{matriz[i, j]}  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Jogador 1, escolha a posição que dejesa marcar:");
            marcacao = int.Parse(Console.ReadLine());



            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Aula04_05();

            /*
            int[,] matriz = new int[3, 3];

            int[,] m;

            int[,] mat = { };

            int[,] matr = new int[2, 2] { { 1, 3 }, { 4, 5 } };

            string[] nomes = new string[3] { "Maria", "Theresa", "FERREIRA" };

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            */
            Console.ReadLine();

        }
    }
}
