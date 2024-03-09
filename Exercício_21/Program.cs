// Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é
// positivo ou negativo. Pare a execução do programa quando o usuário requisitar.

int numero;

Console.Write("Informe um numero inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());
switch (numero)
{
    case > 0:
        Console.WriteLine("O número informado é positivo");
        break;
    case < 0:
        Console.WriteLine("O número informado é negativo.");
        break;
}