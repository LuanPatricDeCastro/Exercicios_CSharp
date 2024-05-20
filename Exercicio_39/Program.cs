/* Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, 
e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte 
pergunta, "Deseja encerrar o programa?"*/

int numero;
char resposta;

Console.WriteLine("Este programa consegue verificar se um número é positivo, negativo, par ou ímpar.");
Console.Write("Deseja encerrar o programa (Tecle 'S' para encerrar)? ");
resposta = Convert.ToChar(Console.ReadLine().ToUpper());
if (resposta == 'S')
{
    Console.WriteLine("Você decidiu encerrar o programa. ");
}
while (resposta != 'S')
{
    Console.WriteLine("informe um número inteiro: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero > 0)
    {
        Console.WriteLine("O número é positivo.");
    }
    if(numero < 0)
    {
        Console.WriteLine("O número é negativo.");
    }
    if(numero % 2 == 0)
    {
        Console.WriteLine("O número é par.");
    }
    if(numero % 2 != 0)
    {
        Console.WriteLine("O número é ímpar. ");
    }
    Console.WriteLine("Deseja encerrar o programa (Tecle 'S' para encerrar)? ");
    resposta = Convert.ToChar(Console.ReadLine().ToUpper());
}

