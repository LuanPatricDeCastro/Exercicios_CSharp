// Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
// menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

double valora, valorb, maiornumero, menornumero;

Console.Write("Informe o valor do número: ");
valora = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor do segundo número: ");
valorb = Convert.ToDouble(Console.ReadLine());

maiornumero = valora;

if(valora == valorb)
{
    Console.WriteLine("Os números {0} e {1} são iguais.", valora, valorb);
}
else if(valora > valorb)
{
    maiornumero = valora;
    menornumero = valorb;
    Console.WriteLine("O menor número é: {0}", menornumero);
    Console.WriteLine("O maior número é: {0}", maiornumero);
}
else if(valorb > valora)
{
    maiornumero = valorb;
    menornumero = valora;
    Console.WriteLine("O menor número é: {0}", menornumero);
    Console.WriteLine("O maior número é: {0}", maiornumero);
}