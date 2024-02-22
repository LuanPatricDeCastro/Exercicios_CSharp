//Exercício 1) Faça um programa para calcular o estoque médio de uma peça, sendo que:
//ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2

int quantidademinima;
int quantidademaxima;
int estoquemedio;

Console.WriteLine("Informe a quantidade mínima para esta peça: ");
quantidademinima = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a quantidade máxima permitida para está peça: ");
quantidademaxima = Convert.ToInt32(Console.ReadLine());
if(quantidademaxima < quantidademinima)
    {
        Console.WriteLine("Por favor. Verique os valores.");
        Console.WriteLine("Insira novamente o valor máximo do estoque: ");
        quantidademaxima = Convert.ToInt32(Console.ReadLine());
    }

estoquemedio = (quantidademinima + quantidademaxima) / 2;

Console.WriteLine("O valor médio do estoque é: {0} peças", estoquemedio);
