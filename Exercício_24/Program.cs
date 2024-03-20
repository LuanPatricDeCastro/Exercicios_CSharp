// Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja realizar:
// 1 – Verificar se um dos números lidos é ou não múltiplo do outro
// 2 – Verificar se os dois números lidos são pares
// 3 – Verificar se a média dos dois números é maior ou igual a 7.
// 4 – Sair

using System.Formats.Asn1;
using System.Net.Http.Headers;

int valor1, valor2, operacao, media;

Console.Write("Informe o primeiro número inteiro: ");
valor1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o segundo número inteiro: ");
valor2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escolha a operação a ser realizada: ");
Console.WriteLine("1 - Verificar se um dos números lidos é múltiplo do outro.");
Console.WriteLine("2 - Verificar se os dois números lidos são pares.");
Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7.");
Console.WriteLine("4 - Sair");
operacao = Convert.ToInt32(Console.ReadLine());

media = (valor1 + valor2) / 2;
  
if(operacao == 1 || valor1 == valor2 * valor2 || valor2 == valor1 * valor1 ) 
{
    Console.WriteLine("Um dos números é múltiplo do outro.");

}
 else if (operacao == 2 && valor1 % 2 == 0 && valor2 % 2 == 0 )
{
    Console.WriteLine("Os dois números informados são pares.");
} else {
    Console.WriteLine("Os números não são pares.");
} 
else if (operacao == 3 && media > 7)
{
    Console.WriteLine("A média é maior do que 7");
} else {
    Console.WriteLine("A média é inferior a 7.");
}
else if(operacao == 4)
{
    Console.WriteLine("Sair da aplicação");
}