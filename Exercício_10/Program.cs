// Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
// entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.

int a, b;

Console.Write("Informe o primeiro número: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o segundo número: ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("O primeiro número é maior.");
} else if (b > a)
{
    Console.WriteLine("O segundo número informado é maior.");
} else if(a == b)
{
    Console.WriteLine("Os números informados são iguais");
} else if (a >= b)
{
    Console.WriteLine("O número {0} é maior ou igual do que o número {1}", a , b);
} else if(a <= b)
{
    Console.WriteLine("O número {0} é menor ou igual do que o número {1}", a , b);
}

