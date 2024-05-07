/* Faça um programa que leia 10 valores inteiros e positivos e: 
- Encontre o maior valor
- Encontre o menor valor
- Calcule a média dos números lidos */

int  i;
int numeros, maior = 0, menor = 0, somanumeros = 0;
double mediatotal;

int [] valores = new int [10];

for(i = 0; i < 10; i ++)
{
    Console.WriteLine("Informe o número: ");
    valores[i] = Convert.ToInt32(Console.ReadLine()); 
    if(valores[i] < 0)
    {
        Console.WriteLine("Número inválido. Digite outro: ");
        valores[i] = Convert.ToInt32(Console.ReadLine());
        break;
    }
    
    somanumeros =  somanumeros + valores[i];

}
i = 0;
if(valores[i] > 0)
{
    
    maior = valores[0];
    menor = valores[0];

    for (i = 1; i < 10; i++)
    {
        if(maior < valores[i])
        {
            maior = valores[i];
        }
        if(menor > valores[i])
        {
            menor = valores[i];
        }
    }
} 

mediatotal = somanumeros / 10;
Console.WriteLine("O maior valor digitado foi: {0} ", maior);
Console.WriteLine("O menor valor digitado foi: {0}", menor);
Console.WriteLine("A média dos números informados é: {0:n2}", mediatotal);