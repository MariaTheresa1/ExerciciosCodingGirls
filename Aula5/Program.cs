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
                Console.WriteLine($"Sua média é: {(nota1 + nota2 + nota3) / 3 :0.00}");
            }
            public void CalcularNotaFinal(float nota1, float nota2, float nota3)
            {
                if((nota1 + nota2 + nota3) / 3 < 7)
                {
                    Console.WriteLine($"Você precisa tirar{12 - (nota1 + nota2 + nota3) / 3: 0.00}" +
                        $" na prova final para passar. Boa sorte."); 
                }
                else
                {
                    Console.WriteLine("Média maior igual a 7.0. Você não ficou de prova final.");
                }
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

            Console.ReadLine();
        }
    }
}
