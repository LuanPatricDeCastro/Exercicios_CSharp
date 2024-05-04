/* Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de 
alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão. */


int numeroAlunos, quantidadeProva, valorProva;
double media, notaIndividual, numeroMatricula, somaNotas = 0;

Console.Write("Informe a quantidade de alunos da turma: ");
numeroAlunos = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de provas: ");
quantidadeProva = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor da prova:");
valorProva = Convert.ToInt32(Console.ReadLine());

double[,] notasAlunos = new double[numeroAlunos, quantidadeProva];

for (int i = 0; i < numeroAlunos; i++)
{
    Console.WriteLine($"Informe o número de matrícula do aluno {i + 1}: ");
    numeroMatricula = Convert.ToDouble(Console.ReadLine());

    for (int j = 0; j < quantidadeProva; j++)
    {
        Console.WriteLine($"Informe a nota da prova {j + 1} do aluno {i + 1}: ");
        notaIndividual = Convert.ToDouble(Console.ReadLine());

        while (notaIndividual > valorProva)
        {
            Console.WriteLine("Você informou a nota errada. Por favor, verifique e digite novamente.");
            notaIndividual = Convert.ToDouble(Console.ReadLine());
        }

        notasAlunos[i, j] = notaIndividual;
        somaNotas += notaIndividual;
    }
}

media = somaNotas / (numeroAlunos * quantidadeProva);
Console.WriteLine($"A média da turma foi: {media:F2}");
