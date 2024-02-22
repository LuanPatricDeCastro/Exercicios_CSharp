// Exercício 4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
// valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
// A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
// com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
// devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
// multiplicações.

int a, b, c, d, resultado, resultado2, resultado3,
resultado4, resultado5, resultado6, resultado7, resultado8, resultado9, resultado10,
resultado11, resultado12;

Console.WriteLine("Informe o valor de a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de c: ");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de d: ");
d = Convert.ToInt32(Console.ReadLine());

resultado = a + b;
resultado2 = a + c;
resultado3 = a + d;
resultado4 = b + c;
resultado5 = b + d;
resultado6 = c + d;
resultado7 = a * b;
resultado8 = a * c;
resultado9 = a * d;
resultado10 = b * c;
resultado11 = b * d;
resultado12 = c * d;

Console.WriteLine("O valor da operação é: {0}", resultado);
Console.WriteLine("O valor da operação é: {0}", resultado2);
Console.WriteLine("O valor da operação é: {0}", resultado3);
Console.WriteLine("O valor da operação é: {0}", resultado4);
Console.WriteLine("O valor da operação é: {0}", resultado5);
Console.WriteLine("O valor da operação é: {0}", resultado6);
Console.WriteLine("O valor da operação é: {0}", resultado7);
Console.WriteLine("O valor da operação é: {0}", resultado8);
Console.WriteLine("O valor da operação é: {0}", resultado9);
Console.WriteLine("O valor da operação é: {0}", resultado10);
Console.WriteLine("O valor da operação é: {0}", resultado11);
Console.WriteLine("O valor da operação é: {0}", resultado12);