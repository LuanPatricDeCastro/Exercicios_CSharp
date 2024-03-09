// Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
// variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido
// multiplicado pelo maior e o maior valor dividido pelo menor.


int a, b, c, menorvalor, maiorvalor, multiplicar, dividir;

Console.Write("Informe o valor de a: ");
a = Convert.ToInt32(Console.ReadLine());
if(a < 0)
{
    Console.WriteLine("Informe o valor novamente.");
    a = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Informe o valor de b: ");
b = Convert.ToInt32(Console.ReadLine());
if(b < 0)
{
    Console.WriteLine("Informe o valor novamente.");
    b = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Informe o valor de c: ");
c = Convert.ToInt32(Console.ReadLine());
if(c < 0)
{
    Console.WriteLine("Informe o valor novamente.");
    c = Convert.ToInt32(Console.ReadLine());
}

menorvalor = a;
if(b < a && c > b)
{
    menorvalor = b;
}
else if(c < a && b > c)
{
    menorvalor = c; 
}

maiorvalor = a;
if(b > a && c < b)
{
    maiorvalor = b;
}
else if(c > a && c > b)
{
    maiorvalor = c;
}

multiplicar = menorvalor * maiorvalor;
dividir = maiorvalor / menorvalor;

Console.WriteLine("O resultado da multiplicação é: {0}", multiplicar);
Console.WriteLine("O resultado da divisão é: {0}", dividir);