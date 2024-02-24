// Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
// entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.

using System.Collections;
using System.Linq.Expressions;

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
} else if(a != b)
{
    Console.WriteLine("Os números informados são diferentes");
} else if ()
{

}

