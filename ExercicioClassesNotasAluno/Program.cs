using System;
using System.Globalization;

namespace ExercicioClassesNotasAluno {
    class Program {
        static void Main(string[] args) {


            /* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
             (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO e REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter
            o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema. */
           
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double notaFinal = aluno.Media();

            Console.WriteLine("Nota final: " + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (notaFinal >= 60.00) {
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }
            

        }
    }
}