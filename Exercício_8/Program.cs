// Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
// V = 3.14159 * R * R * A
// Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.


double volume, raio, altura;

Console.WriteLine("Informe o valor do raio da lata de óleo em centímetros: ");
raio = Convert.ToDouble(Console.ReadLine());
if (raio < 0) 
{
    Console.WriteLine("Informe o raio novamente:");
    raio = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Informe a altura da lata de óleo em centímetros: ");
altura = Convert.ToDouble(Console.ReadLine());
if(altura < 0)
{
    Console.WriteLine("Informe a altura novamente:");
    altura = Convert.ToDouble(Console.ReadLine());    
}

volume = 3.14159 * raio * raio * altura;

Console.WriteLine("O volume da lata de óleo é: {0:n2} cm³", volume);