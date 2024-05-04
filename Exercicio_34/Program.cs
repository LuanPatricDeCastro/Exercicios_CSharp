/* Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o
 número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
 fim dos dados.
*/

using System.ComponentModel.DataAnnotations;

int quantidadeElementos, i;
double numeros, maior = 0, menor = 0;

double [] valores = new Double [1000];

Console.Write("Informe a quantidade de elementos do vetor: ");
quantidadeElementos = Convert.ToInt16(Console.ReadLine());

for(i = 0; i < quantidadeElementos; i ++)
{
    Console.WriteLine("Informe o número: ");
    valores[i] = Convert.ToDouble(Console.ReadLine()); 
    if(valores[i] < 0)
    {
        Console.WriteLine("Aplicação encerrada.");
        break;
    }
}
i = 0;
if(quantidadeElementos > 0)
{
    maior = valores[0];
    menor = valores[0];
    for (i = 1; i < quantidadeElementos; i++)
    {
        if(maior < valores[i])
        {
            maior = valores[i];
        }
        if(menor > valores[i])
        {
            menor = valores[i];
        }
    }
} 

Console.WriteLine("O maior valor digitado foi: {0} ", maior);
Console.WriteLine("O menor valor digitado foi: {0}", menor);
