//  Escreva um programa que leia: - aquantidade de números que deverá processar: 
// - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial. 
// Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N


int numero, resultado;

Console.WriteLine("insira o número que você deseja calcular o seu fatorial: ");
numero = Convert.ToInt32(Console.ReadLine());

resultado = 1;

while(numero > 0)
{
    resultado = resultado * numero;
    numero = numero - 1;
}

Console.WriteLine("O fatorial do número informado é: {0}", resultado);