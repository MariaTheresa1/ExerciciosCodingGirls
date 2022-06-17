using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
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
        /* 2. Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
         * sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
         */
        public static void Aula01_02()
        {
            Console.WriteLine("Margaret Hamilton");
            Console.WriteLine("Cientista da computação");
            Console.WriteLine("Foi diretora da Divisão de Software no Laboratório" +
                " de Instrumentação do MIT, que desenvolveu o programa de voo usado no " +
                "projeto Apollo 11, a primeira missão tripulada à Lua.");

            Console.ReadLine();

        }
        /* 3. Elabore um programa que mostre na tela uma letra de música que você gosta, 
         * o compositor e o gênero musical em linhas separadas.
         */
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

        static void Main(string[] args)
        {
            //Aula01_01();
            //Aula01_02();
            //Aula01_03();
            //Aula01_04();
        }
    }
}
