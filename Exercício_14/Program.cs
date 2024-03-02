// Escreva um programa que leia dois números e apresente a diferença do maior para o menor.

double valora, valorb, diferenca;

Console.Write("Informe o primeiro valor: ");
valora = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o segundo valor: ");
valorb = Convert.ToDouble(Console.ReadLine());

if(valora >= valorb)
{
    diferenca = valora - valorb;
    Console.WriteLine("A diferença entre os dois valores é de: {0}", diferenca);
}
else 
{
    diferenca = valorb - valora;
    Console.WriteLine("A diferença entre os dois valores é de: {0}", diferenca);
}