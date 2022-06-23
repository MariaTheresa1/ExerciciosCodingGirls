using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    /****** Aula 06 - Orientação a Objetos ******/

    // 2. Gerenciando Salários
    // A fim de representar empregados em uma empresa, crie uma classe chamada Empregado que inclui
    // os seguintes atributos; nome, cargo e salário mensal.
    // Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos
    // que executem as seguintes ações:
    // - Se o salário mensal não for positivo, configure-o como 0.0.
    // - Conceder aumento de salários a seus funcionários de acordo com os dados abaixo:
    // Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01
    // até 1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
    // - Imprimir o salário de um funcionário.
    public class Empregado
    {
        public string nome;
        public string cargo;
        public float salario;

        public Empregado(string nome, string cargo, float salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public void AlterarSalarioNegativo(float salario)
        {
            if (salario < 0)
                salario = 0.0f;
            else
                Console.WriteLine("O valor do salário é positivo.");
        }
        public float AumentarSalario(float salario)
        {
            switch (salario)
            {
                case float i when i >= 0 && i <= 400.0:
                    salario += salario * 0.15f;
                    break;
                case float i when i >= 400.1 && i <= 800.0:
                    salario += salario * 0.12f;
                    break;
                case float i when i >= 800.1 && i <= 1200.0:
                    salario += salario * 0.1f;
                    break;
                case float i when i >= 1200.1 && i <= 2000.0:
                    salario += salario * 0.07f;
                    break;
                case float i when i > 2000:
                    salario += salario * 0.04f;
                    break;
                default:
                    Console.WriteLine("Sem aumento, desculpe.");
                    break;
            }
            return salario;
        }
        public void ImprimirSalario(float salario)
        {
            Console.WriteLine($"Seu salario é: R$ {salario: 0.00}");
        }
    }

    // 3. Fatura de Serviço
    // Crie uma classe que representa uma fatura para uma loja de suprimentos de informática.
    // A classe deve conter os seguintes atributos: número, descrição dos produtos, quantidade
    // comprada de um produto e o preço. A classe deve ter um construtor e um método get e set
    // para cada variável de instância. Além disso, forneça um método para calcular o valor total
    // da fatura.
    public class Fatura
    {
        public int numero;
        public string descricao;
        public int quantidade;
        public float preco;

        // Instância
        public Fatura(int numero, string descricao, int quantidade, float preco)
        {
            this.numero = numero;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.preco = preco;
        }
        // Métodos Get e Set
        public int Numero { get { return numero; } set { numero = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
        public float Preco { get { return preco; } set { preco = value; } }
        public void CalcularValorTotalFatura(int quantidade, float preco)
        {
            Console.WriteLine("O valor total da fatura é: " + quantidade * preco);
        }
    }

    // 4. Sorteio
    // Fazer uma classe que represente um Sorteio que irá sortear um número de 0 a 1000 e
    // após pedir para o usuário adivinhar este número. Se ele errar, informar se o palpite
    // é maior ou menor do que o número sorteado. O usuário pode jogar até que acerte e,
    // depois disso, mostrar quantas tentativas ele fez até acertar.
    public class Sorteio
    {
        public int numero;

        public Sorteio(int numero)
        {
            this.numero = numero;
        }
        public void Sortear(int numero)
        {
            Random rand = new Random();
            int numeroSorteado = rand.Next(numero);
            int tentativas = 0;

            // Console.WriteLine("O número sorteado é: " + numeroSorteado);
            Console.Write($"Usuário, tente adivinhar o número de 0 a {numero}: ");
            int numeroUsuario = int.Parse(Console.ReadLine());

            while (true)
            {
                if (numeroSorteado == numeroUsuario)
                {
                    Console.WriteLine("\nParabéns, você acertou. Número sorteado: " + numeroSorteado);
                    Console.WriteLine("Quantidade de tentativas: " + tentativas);
                    break;
                }
                else if (numeroSorteado > numeroUsuario)
                {
                    Console.WriteLine("Você errou. Dica: O número sorteado é maior...");
                    Console.Write("Usuário, tente adivinhar novamente: ");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    tentativas++;
                }
                else // numeroSorteado < numeroUsuario
                {
                    Console.WriteLine("Você errou. Dica: O número sorteado é menor...");
                    Console.Write("Usuário, tente adivinhar novamente: ");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    tentativas++;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. 
            Empregado empregado = new Empregado("Maria", "Agente", 1800.0f);
            empregado.AlterarSalarioNegativo(empregado.salario);
            empregado.salario = empregado.AumentarSalario(empregado.salario);
            empregado.ImprimirSalario(empregado.salario);

            Console.WriteLine("");

            // 3.
            Fatura fatura;
            fatura = new Fatura(1, "Carregador de celular", 2, 55);
            fatura.CalcularValorTotalFatura(fatura.quantidade, fatura.preco);

            Console.WriteLine("");

            // 3.
            Sorteio sorteio = new Sorteio(1000);
            sorteio.Sortear(sorteio.numero);

            Console.ReadLine();
        }
    }
}
