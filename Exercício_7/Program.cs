// Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
// temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
// variável C é a temperatura em graus Celsius.

double fahrenheit, celsius;

Console.WriteLine("Informe a temperatura em graus Fahrenheit: ");
fahrenheit = Convert.ToDouble(Console.ReadLine());
if(fahrenheit < -459.67)
{
    Console.WriteLine("Favor verificar a temperatura, pois ela corresponde a uma temperatura inferior ao zero absoluto");
    Console.WriteLine("Informe a temperatura em graus Fahrenheit novamente: ");
    fahrenheit = Convert.ToDouble(Console.ReadLine());
}

celsius = ((fahrenheit - 32) * 5) / 9;

Console.WriteLine("A temperatura informada corresponde a: {0:n2} ºC ", celsius);