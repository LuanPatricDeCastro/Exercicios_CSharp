// Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
// lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
// eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
// contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.

double a, b, c;

Console.Write("Informe o valor do lado a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor do lado b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor do lado c: ");
c = Convert.ToDouble(Console.ReadLine());

if(a < (b + c) || b < (a + c) || c < (a + b))
{
    Console.WriteLine("Os números informados não obedecem a condição de existência dos triãngulos");
    Console.WriteLine("Digite os valores novamente:");
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());

    if( a == b && b == c )
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if( a == b || a == c || b ==c )
    {
        Console.WriteLine("o triângulo é isósceles");
    }
    else if ( a > 0 && b > 0 && c > 0)
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}