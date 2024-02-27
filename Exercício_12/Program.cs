// Escreva um programa que leia um número inteiro e exiba o seu módulo.
// O módulo de um número x é:
// x se x é maior ou igual a zero
// x * (-1) se x é menor que zero

int x;

Console.Write("Informe o valor de x: ");
x = Convert.ToInt32(Console.ReadLine());

if(x >= 0)
{
    Console.WriteLine("O valor do módulo de X é: {0}", x);
}
else
{
    x = x *(-1);
    Console.WriteLine("O valor do módulo de x é: {0}", x);   
}