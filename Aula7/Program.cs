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
    // nome do cliente e saldo privados.Além dos métodos de get para os atributos crie um
    // método para alterar o nome, realizar depósitos e saques. Também construa um construtor
    // onde saldo é opcional, com valor default zero, já os demais atributos são obrigatórios.
    public class ContaBancaria
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Aluno aluninhos = new Aluno();

            // 3. 


            Console.ReadLine();
        }
    }
}
