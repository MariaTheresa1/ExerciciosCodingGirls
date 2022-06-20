using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    internal class Program
    {
        // **** Aula 05 - Introdução à orientação a objetos ****

        // 1. Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
        // Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome,
        // 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
        // - Calcular média: calcula e exibe a média final do aluno com base em suas notas;
        // - Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.
        public class Aluno
        {
            public int matricula;
            public string nome;
            public float nota1prova;
            public float nota2prova;
            public float nota1trabalho;
            public void CalcularMedia(float nota1, float nota2, float nota3)
            {
                Console.WriteLine($"Sua média é: {(nota1 + nota2 + nota3) / 3:0.00}");
            }
            public void CalcularNotaFinal(float nota1, float nota2, float nota3)
            {
                if ((nota1 + nota2 + nota3) / 3 < 7)
                {
                    Console.WriteLine($"Você precisa tirar{12 - (nota1 + nota2 + nota3) / 3: 0.00}" +
                        $" na prova final para passar. Boa sorte.\n");
                }
                else
                {
                    Console.WriteLine("Média maior igual a 7.0. Você não ficou de prova final.\n");
                }
            }
        }
        // 2. Escreva uma classe em que cada objeto representa um vôo que acontece em determinada
        // data e em determinado horário. Cada vôo possui no máximo 100 vagas, e a classe
        // permite controlar a ocupação das vagas. A classe deve ter os seguintes métodos:
        // - Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro,
        // e retorna verdadeiro se a cadeira ainda não estiver ocupada (operação foi bem sucedida)
        // e falso caso contrário;
        // - Vagas Livres: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo;
        // - Cadeira Livre: Retorna o número da próxima cadeira livre;
        // - Ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro.
        // Caso a cadeira esteja ocupada exibe uma mensagem, caso esteja vazia, reserva e exibe
        // uma mensagem de confirmação;
        // - Ver horário: Imprime a data e o horário do vôo.

        public class Voo
        {
            public string data;
            public string horario;
            public bool[] vagas = new bool[100];

            public bool OcuparVaga(int numero, bool[] vagas)
            {
                if (vagas[numero] == false)
                {
                    Console.WriteLine("A operação foi bem sucedida. Vaga resevada.");
                    return true;
                }
                else
                {
                    Console.WriteLine("A operação foi mal sucedida. Cadeira já ocupada.");
                    return false;
                }
            }
            public int VagasLivres(bool[] vagas)
            {
                int cont = 0;
                for (int i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == false)
                        cont++;
                }
                return cont;
            }
            public int CadeiraLivre(bool[] vagas)
            {
                int i;
                for (i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == false)
                        break;
                }
                return i;
            }
            public void Ocupa(int numero, bool[] vagas)
            {
                if (vagas[numero] == true)
                {
                    Console.WriteLine("Cadeira já ocupada.");
                }
                else
                {
                    vagas[numero] = true;
                    Console.WriteLine("Reserva realizada. Ok.");
                }
            }
            public void VerHorario(string data, string horario)
            {
                Console.WriteLine($"Data do vôo: {data}\nHorário do vôo: {horario}\n");
            }
        }

        static void Main(string[] args)
        {
            // 1.
            Aluno aluno = new Aluno();

            aluno.nome = "Maria Silva";
            aluno.matricula = 0012;
            aluno.nota1prova = 6.0f;
            aluno.nota2prova = 6.0f;
            aluno.nota1trabalho = 6.0f;

            aluno.CalcularMedia(aluno.nota1prova, aluno.nota2prova, aluno.nota1trabalho);
            aluno.CalcularNotaFinal(aluno.nota1prova, aluno.nota2prova, aluno.nota1trabalho);

            // 2.
            Voo voo = new Voo();

            voo.data = "20/05/2021";
            voo.horario = "07:15";
            for (int i = 0; i < voo.vagas.Length; i++)            
                voo.vagas[i] = false;

            voo.vagas[13] = voo.OcuparVaga(13, voo.vagas);
            Console.WriteLine("Quantidade de vagas livres: " + voo.VagasLivres(voo.vagas));
            Console.WriteLine("Próxima cadeira livre: " + voo.CadeiraLivre(voo.vagas));
            voo.Ocupa(13, voo.vagas);
            voo.Ocupa(14, voo.vagas);
            voo.VerHorario(voo.data, voo.horario);


            Console.ReadLine();
        }
    }
}
