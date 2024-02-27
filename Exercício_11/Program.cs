// Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
// possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.

int A, B, troca;

Console.Write("Informe o valor da variável A: ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de B: ");
B = Convert.ToInt32(Console.ReadLine());

troca = 0;
if(A != B && A > 0)
{
    troca = A;
    A = B;
    B = troca;
}


Console.WriteLine("O novo valor de A é: {0}", A);
Console.WriteLine("O novo valor de B é: {0}", B);