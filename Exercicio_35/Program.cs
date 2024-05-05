/*  Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".*/ 

int numero = 1;

while(numero <= 100)
{
    Console.WriteLine(numero);
    if(numero % 10 == 0) 
    {
        Console.WriteLine("Múltiplo de 10.");
    }
    numero++;
}