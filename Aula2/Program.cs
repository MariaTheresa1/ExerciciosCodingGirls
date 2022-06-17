using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
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
        /* 3. Escreva um programa que leia o número de horas trabalhadas e um funcionário, 
         * o valor que recebe por hora e calcula o salário desse funcionário. 
         * A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
         */
        public static void Aula02_03()
        {
            int horas;
            float valorDaHora;
            Console.Write("Quantas horas você trabalhou? ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("Qual o valor por hora? ");
            valorDaHora = float.Parse(Console.ReadLine());

            Console.WriteLine($"Você trabalhou {horas} horas e o seu salário é: R$ {horas * valorDaHora: 00.00}");

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
        /* 5. Construa um conversor de moedas:
         Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
         - DOLAR
         - EURO
         - LIBRA ESTERLINA
         - DÓLAR CANADENSE
         - PESO ARGENTINO
         - PESO CHILENO
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
        static void Main(string[] args)
        {
            //Aula02_01();
            //Aula02_02();
            //Aula02_03();
            //Aula02_04();
            //Aula02_05();

        }
    }
}
