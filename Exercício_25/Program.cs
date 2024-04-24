//  Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, 
// utilizando as seguintes fórmulas: (h = altura)- Para homens: (72.7*h)- 58. Para mulheres: (62.1 *h) - 44.7


using System.Diagnostics;

char sexo;
double altura, pesoideal;

Console.WriteLine("Informe seu sexo: ");
Console.WriteLine("F = feminino ou M = masculino ");
sexo = Convert.ToChar(Console.ReadLine());
if(sexo != 'M' || sexo != 'F')
{
    Console.WriteLine("Você informou o sexo errado. Por favor digite novamente com a letra Maiuscula");
    sexo = Convert.ToChar(Console.ReadLine());
}

Console.WriteLine("Informe sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());


switch (sexo)
{
    case 'M':    
    {
        pesoideal = (72.8 * altura) - 58;
        Console.WriteLine("O seu peso ideal é: {0} kg", pesoideal);
        break;
    }

    case 'F':
    {
        pesoideal = (62.1 * altura) - 44.7;
        Console.WriteLine("O seu peso ideal é: {0} kg", pesoideal);
        break;
    }
}