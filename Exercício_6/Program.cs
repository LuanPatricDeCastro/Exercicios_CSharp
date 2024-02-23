// Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
// temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
// Fahrenheit e a variável C representa é a temperatura em graus Celsius.

double fahrenheit, celsius;

Console.WriteLine("Informe a temperatura em graus celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());
if(celsius < 273.15)
    {
        Console.WriteLine("Favor verificar a temperatura, pois não é impossível existir uma temperatura inferior ao zero absoluto");
        Console.WriteLine("Informe a temperatura novamente: " );
        celsius = Convert.ToDouble(Console.ReadLine());
    }
    

fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine("A temperatura informada corresponde a: {0:n2} Fahrenheit", fahrenheit);

