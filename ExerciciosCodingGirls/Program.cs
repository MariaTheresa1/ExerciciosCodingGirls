using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    internal class Program
    {             
        
        // ****** Aula 04 - Vetores e Matrizes ******

        /* 1. Crie um programa que solicite a entrada de 10 números pelo usuário, 
         * armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5. 
         * Exiba os valores dos dois vetores na tela, um em cada linha.
         */
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
        /* 2. Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: 
         * um somente para números pares, e outro somente para números ímpares. 
         * Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.
         */
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
        /* 3. Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho.
         * Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.
         */
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
        /* 4. Jogo Jokenpô
         * Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa 
         * que jogue pedra, papel e tesoura (Jokenpô) com você.   
            - Permitir que eu decida quantas rodadas iremos fazer;
            - Ler a minha escolha (Pedra, papel ou tesoura);
            - Decidir de forma aleatória a decisão do computador;
            - Mostrar quantas rodadas cada jogador ganhou;
            - Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um
         (computador e jogador); 
            - Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha 
         de quantidade de rodadas, se não finalize o programa.
         */
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
        /* 5. Jogo da Velha.
         * Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha 
         * e exiba quem foi o vencedor.
         */
        public static void Aula04_05()
        {
            char[,] matriz = new char[3, 3];
            char jogador1 = 'X', jogador2 = 'O', escolha;
            int marcacao, aux;

            Console.WriteLine("****** JOGO DA VELHA ******");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = '·';
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
                    Console.Write("Caracter inválido. Tente novamente. Jogador 1, digite X ou O: ");
                    escolha = char.Parse(Console.ReadLine());
                }
            } while (escolha != 'x' && escolha != 'X' && escolha != 'o' && escolha != 'O');

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
                    // i * 3 + j + 1;
                    // matriz[i, j] = aux.ToString(); 

                    //matriz[i, j] = char(3);

                    // aux = matriz[i, j] - '0';

                    //aux = Convert.ToChar(i * 3 + j + 1);
                    //aux = (char)aux;

                    //Console.Write($"{aux} ");

                    // Console.WriteLine(i * 3 + j + 1);
                    //matriz[i, j] = (char)aux;

                    //matriz[i, j] = Convert.ToChar(i * 3 + j + 1);

                    //Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Jogador 1, escolha a posição que deseja marcar:");
            marcacao = int.Parse(Console.ReadLine());

            if (marcacao == 1)
                matriz[0, 0] = jogador1;
            else if (marcacao == 2)
                matriz[0, 1] = jogador1;
            else if (marcacao == 3)
                matriz[0, 2] = jogador1;
            else if (marcacao == 4)
                matriz[1, 0] = jogador1;
            else if (marcacao == 5)
                matriz[1, 1] = jogador1;
            else if (marcacao == 6)
                matriz[1, 2] = jogador1;
            else if (marcacao == 7)
                matriz[2, 0] = jogador1;
            else if (marcacao == 8)
                matriz[2, 1] = jogador1;
            else if (marcacao == 9)
                matriz[2, 2] = jogador1;
            

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
