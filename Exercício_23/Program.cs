// Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
// 1 – Adição
// 2 – Subtração
// 3 – Multiplicação
// 4 – Divisão

double numero1, numero2, soma, subtracao, divisao, multiplicacao;
int operacao;

Console.Write("Informe o número: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação a ser realizada:");
Console.WriteLine("1 - adição");
Console.WriteLine("2 - subtração");
Console.WriteLine("3 - multiplicação");
Console.WriteLine("4 - divisão");
Console.WriteLine("Informe o número correspondente a operação a ser realizada");
operacao = Convert.ToInt32(Console.ReadLine());
if(operacao == 1)
{
    soma = numero1 +  numero2;
    Console.WriteLine("O resultado é: {0}", soma);
} else if (operacao == 2)
{
   subtracao = numero1 - numero2;
   Console.WriteLine("O resultado é: {0}", subtracao); 
} else if (operacao == 3)
{
    multiplicacao = numero1 * numero2;
    Console.WriteLine("O resultado é: {0}", multiplicacao);
} else if (operacao == 4)
{
    divisao = numero1 / numero2;
    Console.WriteLine("O resultado é: {0}", divisao);
} else if (operacao < 1 || operacao > 4)
{
    Console.WriteLine("Calculadora encerrada devido a operação matemática não existente");
}

