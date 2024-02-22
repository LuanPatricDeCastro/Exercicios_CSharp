//Faça um programa que:
// - Leia a cotação do dólar
// - Leia um valor em dólares
// - Converta esse valor para Real
// - Mostre o resultado


double cotacaodolar;
double quantidadedolar;
double valoremreais;

Console.WriteLine("Informe a cotação do dólar: ");
cotacaodolar = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor em dólar que você possui: ");
quantidadedolar = Convert.ToDouble(Console.ReadLine());

valoremreais = quantidadedolar / cotacaodolar;

Console.WriteLine("Você possui o equivalente a: R$ {0:N2} reais", valoremreais);
