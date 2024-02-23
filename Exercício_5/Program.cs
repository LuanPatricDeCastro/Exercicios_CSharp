// Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
// 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
// Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
// Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
// fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
// tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.

double tempoviagem, velocidade, distanciapercorrida, litrosusados, velocidademedia;

Console.Write("Informe o tempo de viagem em horas: ");
tempoviagem = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a sua velocidade: ");
velocidade = Convert.ToDouble(Console.ReadLine());

distanciapercorrida = tempoviagem * velocidade;
litrosusados = distanciapercorrida / 12;
velocidademedia = distanciapercorrida / tempoviagem;

Console.WriteLine("A velocidade média durante o percurso foi de: {0} km/h", velocidademedia);
Console.WriteLine("O tempo gasto na viagem foi de: {0} horas", tempoviagem);
Console.WriteLine("A distância percorrida foi de: {0} km", distanciapercorrida);
Console.WriteLine("A quantidade de combustível utilizado foi de: {0:n2} litros", litrosusados);
