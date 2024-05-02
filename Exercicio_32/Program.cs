//  Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
// ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.

using System.Diagnostics.Contracts;

int numeroinformado;

Console.Write("Informe um número entre 1 e 10:");
numeroinformado = Convert.ToInt16(Console.ReadLine());
if( numeroinformado < 1 || numeroinformado > 10)
{
    Console.WriteLine("Digite o número novamente: ");
    numeroinformado = Convert.ToInt16(Console.ReadLine());
} else if (numeroinformado % 2 == 0)
{
    numeroinformado = numeroinformado + 1;
    Console.WriteLine("O número informado é par. Por isso iremos somar 1 ao número informado.");
}


int somaquadrado, contador;
contador = 0;
somaquadrado = 0;

if (numeroinformado % 2 != 0) 
{
    while(contador < 21)
    {
        somaquadrado += numeroinformado * numeroinformado;
        numeroinformado += 2;
        contador++;
    }

    Console.WriteLine("A soma do quadrado dos próximos 20 números ímpares é: {0}", somaquadrado);

}

