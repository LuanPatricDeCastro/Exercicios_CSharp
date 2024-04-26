//  Faça um programa para imprimir uma tabuada.

int numeroTabuada, multiplicador, valoresTabuada;

multiplicador = 1;

Console.Write("Insira o número que deseja imprimir a tabuada: ");
numeroTabuada = Convert.ToInt32(Console.ReadLine());

while(multiplicador < 11)
{
    
    valoresTabuada = numeroTabuada * multiplicador;
    Console.WriteLine("{0} x {1} = {2} ",numeroTabuada, multiplicador, valoresTabuada);
    multiplicador++;

}
