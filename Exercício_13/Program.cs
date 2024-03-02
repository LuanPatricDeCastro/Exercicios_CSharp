// Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

int valora, valorb, valorc, maiorvalor, valorintermediario, menorvalor;

Console.Write("Insira o primeiro número inteiro: ");
valora = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número inteiro: ");
valorb = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o terceiro número inteiro: ");
valorc = Convert.ToInt32(Console.ReadLine());

maiorvalor = valora;
valorintermediario = 0;
menorvalor = 0;

if (valora >= valorb && valora >= valorc && valorb >= valorc)
{
    maiorvalor = valora;
    valorintermediario = valorb;
    menorvalor = valorc;
}
else if (valorb >= valora && valorb >= valorc && valora >= valorc)
{
    maiorvalor = valorb;
    valorintermediario = valora;
    menorvalor = valorc;
}
else if (valorc >= valora && valorc >= valorb && valorb >= valora)
{
    maiorvalor = valorc;
    valorintermediario = valorb;
    menorvalor = valora;
}

Console.Write("Os valores digitados em ordem decrescente foram: {0} , {1}, {2}", maiorvalor, valorintermediario, menorvalor);


