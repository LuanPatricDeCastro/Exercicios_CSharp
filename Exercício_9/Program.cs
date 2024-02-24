// Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa
// pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.


int anos, meses, dias, diasvividos;

Console.Write("Informe sua idade expressa em anos: ");
anos = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a sua idade expressa em meses: ");
meses = Convert.ToInt32(Console.ReadLine());
if(meses < 0|| meses > 12)
{
    Console.WriteLine("Informe a quantidade de meses novamente.");
    meses = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Informe sua idade em dias: ");
dias = Convert.ToInt32(Console.ReadLine());
if(dias < 0 || dias > 30)
{
    Console.WriteLine("Informe a quantidade de dias novamente.");
    dias = Convert.ToInt32(Console.ReadLine());
}

diasvividos = (anos * 365) + (meses * 30) + dias;

Console.WriteLine("A idade informada representa uma quantidade de: {0} dias", diasvividos);