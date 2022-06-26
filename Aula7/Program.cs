using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    /****** Aula 07 - Encapsulamento ******/
    // 1. Cadastro de Alunos
    // Considere uma classe Aluno. Esta classe possui como atributos privados o nome,
    // as notas e a frequência. Além do construtor, esta classe deve conter os métodos
    // que cadastram os alunos, adiciona suas notas, consulta um aluno por código e
    // consulta todos os alunos do cadastro.
    class Aluno
    {
        private int codigo;
        private string nome;
        private float[] notas = new float[2];
        private float frequencia;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public float[] Notas { get { return notas; } set { notas = value; } }
        public float Frequencia { get { return frequencia; } set { frequencia = value; } }

        public Aluno()
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos = CadastrarAluno();
            ConsultarTodosOsAlunos(listaAlunos);
            ConsultarAluno(listaAlunos);
        }
        public Aluno(int codigo, string nome, float[] notas, float frequencia)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.notas = notas;
            this.frequencia = frequencia;
        }
        public List<Aluno> CadastrarAluno()
        {
            List<Aluno> alunos = new List<Aluno>();
            float[] notas = new float[2];
            int escolha = 1;

            Console.Write("---------- CADASTRO DE ALUNOS ----------");
            do
            {
                Console.Write("\nDigite o código do aluno: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.Write($"Digite a nota {i + 1} do aluno: ");
                    notas[i] = float.Parse(Console.ReadLine());
                }

                Console.Write("Digite a frequência do aluno: ");
                float frequencia = float.Parse(Console.ReadLine());

                alunos.Add(new Aluno(codigo, nome, notas, frequencia));

                Console.Write("\nDeseja cadastrar mais um aluno?\nPara SIM, digite 1. " +
                    "Para NÃO, digite qualquer outro número: ");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha == 1);

            return alunos;
        }
        public void ConsultarAluno(List<Aluno> alunos)
        {
            Console.WriteLine("---------- CONSULTAR ALUNO ----------");
            Console.Write("Digite o código do aluno que deseja consultar: ");
            int cod = int.Parse(Console.ReadLine());

            foreach (Aluno i in alunos)
            {
                if (cod == i.codigo)
                {
                    Console.WriteLine($"Aluno encontrado.\nNome: {i.Nome}" +
                        $"\nNota 1: {i.notas[0]}\nNota 2: {i.notas[1]}\nFrequência: {i.Frequencia}%\n");
                }
                else
                {
                    Console.Write("Aluno não encontrado.");
                }
            }
        }
        public void ConsultarTodosOsAlunos(List<Aluno> alunos)
        {
            Console.Write("\n---------- LISTA DE TODOS OS ALUNOS ----------\n");
            foreach (Aluno i in alunos)
                Console.WriteLine($"Código: {i.Codigo}\nNome: {i.Nome}" +
                    $"\nNota 1: {i.notas[0]}\nNota 2: {i.notas[1]}\nFrequência: {i.Frequencia}%\n");
        }
    }

    // 3. Conta Bancária
    // Crie uma classe Conta Bancária que possua os seguintes atributos: número da conta,
    // nome do cliente e saldo privados. Além dos métodos de get para os atributos crie um
    // método para alterar o nome, realizar depósitos e saques. Também construa um construtor
    // onde saldo é opcional, com valor default zero, já os demais atributos são obrigatórios.
    public class ContaBancaria
    {
        private int numero;
        private string nome;
        private float saldo;

        public int Numero { get { return numero; } set { numero = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public float Saldo { get { return saldo; } set { saldo = value; } }

        public ContaBancaria()
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            Menu(contas);
        }

        public ContaBancaria(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
            saldo = 0;
        }
        public List<ContaBancaria> AlterarNome(List<ContaBancaria> contas)
        {
            Console.Write("Informe o número da conta que deseja alterar o nome: ");
            int numero = int.Parse(Console.ReadLine());

            foreach (ContaBancaria i in contas)
            {
                if(numero == i.Numero)
                {
                    Console.Write("Informe o novo nome: ");
                    string nome = Console.ReadLine();
                    i.Nome = nome;
                    Console.WriteLine("Nome alterado com sucesso.");
                    return contas;
                }                
            }
            Console.WriteLine("A conta com o número informado não foi encontrada.\n");
            return contas;
        }
        public List<ContaBancaria> RealizarDeposito(List<ContaBancaria> contas)
        {
            Console.Write("Informe o número da conta que deseja realizar o depósito: ");
            int numero = int.Parse(Console.ReadLine());

            foreach (ContaBancaria i in contas)
            {
                if (numero == i.Numero)
                {
                    Console.Write("Informe o depósito: ");
                    float deposito = float.Parse(Console.ReadLine());
                    i.Saldo += deposito;
                    Console.WriteLine("Depósito realizado com sucesso.");
                    return contas;
                }
            }
            Console.WriteLine("A conta com o número informado não foi encontrada.\n");
            return contas;
        }
        public List<ContaBancaria> RealizarSaque(List<ContaBancaria> contas)
        {
            Console.Write("Informe o número da conta que deseja realizar o saque: ");
            int numero = int.Parse(Console.ReadLine());

            foreach (ContaBancaria i in contas)
            {
                if (numero == i.Numero)
                {
                    Console.Write("Informe o saque: ");
                    float saque = float.Parse(Console.ReadLine());
                    i.Saldo -= saque;
                    Console.WriteLine("Saque realizado com sucesso.");
                    return contas;
                }
            }
            Console.WriteLine("A conta com o número informado não foi encontrada.\n");
            return contas;
        }
        public List<ContaBancaria> AdicionarConta(List<ContaBancaria> contas)
        {
            Console.WriteLine("\n----------- Adicionar uma conta -----------");
            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do titular da conta: ");
            string nome = Console.ReadLine();

            contas.Add(new ContaBancaria(numero, nome));

            return contas;
        }
        public void ListarTodasAsContas(List<ContaBancaria> contas)
        {
            Console.WriteLine("\n----------- Contas cadastradas -----------");
            foreach (ContaBancaria i in contas)
            {
                Console.WriteLine($"Número: {i.Numero}");
                Console.WriteLine($"Nome: {i.Nome}");
                Console.WriteLine($"Saldo: {i.Saldo}");
                Console.WriteLine();
            }
        }
        public void Menu(List<ContaBancaria> contas)
        {
            int opcao;
            do
            {
                Console.Write("MENU\n1 - Cadastrar conta\n2 - Alterar nome\n3 - Realizar Saque\n4 " +
                    "- Realizar Deposito\n5 - Listar todas as contas\n0 - Sair\nDigite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        contas = AdicionarConta(contas);
                        break;
                    case 2:
                        AlterarNome(contas);
                        break;
                    case 3:
                        RealizarSaque(contas);
                        break;
                    case 4:
                        RealizarDeposito(contas);
                        break;
                    case 5:
                        ListarTodasAsContas(contas);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Aluno aluninhos = new Aluno();

            // 3. 
            ContaBancaria continhas = new ContaBancaria();

            Console.ReadLine();
        }
    }
}
