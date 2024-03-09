// Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o
// resultado.


double numero;

Console.Write("Informe um numero: ");
numero = Convert.ToDouble(Console.ReadLine());

double A, B;
if(numero > 0)
{
    A = 0;
    A = numero;
    Console.WriteLine("o número foi armazenado na variável A.");
    Console.WriteLine(A);
}else
{
    B = 0;
    B = numero;
    Console.WriteLine("o número foi armazenado na variável B.");
    Console.WriteLine(B);
}