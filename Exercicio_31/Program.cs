// Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba 
// ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o 
// número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
// fim dos dados.

int i, numero, somaimpar = 0, somapar = 0;
for(i = 0; i < 10; i++)
{
    Console.Write("Informe um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero < 0)
    {
        Console.WriteLine("Aplicação encerrada.");
        break;
    } else if(numero % 2 == 0)
    {
        Console.WriteLine("O número é par.");
        somapar += numero;
    } else 
    {
        Console.WriteLine("O número é ímpar.");
        somaimpar+= numero;
    }
}

Console.WriteLine("A soma dos números pares é: {0}", somapar);
Console.WriteLine("A soma dos números pares é: {0}", somaimpar);