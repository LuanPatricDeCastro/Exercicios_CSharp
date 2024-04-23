// Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja realizar:
// 1 – Verificar se um dos números lidos é ou não múltiplo do outro
// 2 – Verificar se os dois números lidos são pares
// 3 – Verificar se a média dos dois números é maior ou igual a 7.
// 4 – Sair


using Microsoft.VisualBasic;

int valor1, valor2, operacao, resultado;

Console.WriteLine("Operações disponíveis: ");
Console.WriteLine("1 - Verificar se um dos números lidos é múltiplo do outro.");
Console.WriteLine("2 - Verificar se os dois números lidos são pares.");
Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7.");
Console.WriteLine("4 - Sair");

Console.WriteLine("Escolha uma operação a ser realizada: ");
operacao = int.Parse(Console.ReadLine());

Console.Write("Informe o primeiro número inteiro: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo número inteiro: ");
valor2 = int.Parse(Console.ReadLine());

switch (operacao)
{
    case 1:
        {
            if(valor1 * valor1 == valor2 || valor2 * valor2 == valor1)
            {
                Console.WriteLine("Um dos números lidos é multiplo do outro.");
            }
            else
            {
                Console.WriteLine("Nenhum dos números informados é multiplo do outro.");
            }
            break;
        }

    case 2:
    {
        if(valor1 % 2 == 0 & valor2 % 2 == 0)
        {
            Console.WriteLine("Os dois números lidos são pares");
        }
        else 
        {
            Console.WriteLine("Os números informados não são pares.");
        }
        break;
    }    

    case 3:
    {
        if( (valor1 + valor2) / 2 >= 7)
        {
            Console.WriteLine("A média dos números é maior do que 7");
        }
        else {
            Console.WriteLine("A média é inferior a 7.");
        }
        break;

    }

    case 4:
    {
        Console.WriteLine("Sair da aplicação.");
        break;
    }
}