// Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
// entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
// Caso contrário, apresentar a mensagem “valor inválido”.


int valor;

Console.Write("Informe um valor inteiro: ");
valor = Convert.ToInt32(Console.ReadLine());
if(valor >= 0 && valor <= 9)
{
    Console.WriteLine("valor válido.");
}
else
{
    Console.WriteLine("valor inválido");
}