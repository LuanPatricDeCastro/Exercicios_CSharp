/* Faça um programa que simule uma calculadora e que possua a opção do usuário retornar para o menu inicial
O programa deverá apresentar uma tela de entrada com as seguintes opções:
 1– Adição
 2– Subtração
 3– Multiplicação
 4– Divisão */

double operacao, resultado, valor1, valor2;
char resposta, respostaMaiuscula;

Console.WriteLine("Bem vindo ao seu aplicativo de calculadora: ");
Console.WriteLine("Informe a operação necessária: ");
Console.WriteLine(" 1 - Adição:");
Console.WriteLine(" 2 - Subtração:");
Console.WriteLine(" 3 - Multiplicação:");
Console.WriteLine(" 4 - Divisão: ");
operacao = Convert.ToDouble(Console.ReadLine());
if(operacao < 1 || operacao > 4)
{
    Console.WriteLine("Escolha novamente a operação: ");
    operacao = Convert.ToDouble(Console.ReadLine());
}

Console.Write("Informe o primeiro número: ");
valor1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe o primeiro número: ");
valor2 = Convert.ToDouble(Console.ReadLine());

switch(operacao)
{
    case 1:
    {
        resultado = valor1 + valor2;
        Console.WriteLine("O resultado da adição é: {0}", resultado);
        break;
    }
    case 2:
    {
        resultado = valor1 - valor2;
        Console.WriteLine("O resultado da subtração é: {0}", resultado);
        break;
    }
    case 3:
    {
        resultado = valor1 * valor2;
        Console.WriteLine("O resultado da multiplicação é: {0}", resultado);
        break;
    }
    case 4:
    {
        resultado = valor1 / valor2;
        Console.WriteLine("O resultado da divisão é: {0}", resultado);
        break;
    }
    

}
Console.WriteLine("Deseja realizar uma nova operação (S = Sim e N = Não): ");
resposta = Convert.ToChar(Console.ReadLine().ToUpper());
if(resposta == null)
{
    Console.WriteLine("Digite a resposta");
    resposta = Convert.ToChar(Console.ReadLine().ToUpper());
}
switch(resposta)
{
    case 'S':
    {
        Console.WriteLine("Bem vindo ao seu aplicativo de calculadora: ");
        Console.WriteLine("Informe a operação necessária: ");
        Console.WriteLine(" 1 - Adição:");
        Console.WriteLine(" 2 - Subtração:");
        Console.WriteLine(" 3 - Multiplicação:");
        Console.WriteLine(" 4 - Divisão: ");
        operacao = Convert.ToDouble(Console.ReadLine());
        if(operacao < 1 || operacao > 4)
        {
            Console.WriteLine("Escolha novamente a operação: ");
            operacao = Convert.ToDouble(Console.ReadLine());
        }


        Console.Write("Informe o primeiro número: ");
        valor1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Informe o primeiro número: ");
        valor2 = Convert.ToDouble(Console.ReadLine());

        switch(operacao)
        {
            case 1:
            {
                resultado = valor1 + valor2;
                Console.WriteLine("O resultado da adição é: {resultado}");
                break;
            }
            case 2:
            {
                resultado = valor1 - valor2;
                Console.WriteLine("O resultado da subtração é: {resultado}");
                break;
            }
            case 3:
            {
                resultado = valor1 * valor2;
                Console.WriteLine("O resultado da multiplicação é: {resultado}");
                break;
            }
            case 4:
            {
                resultado = valor1 / valor2;
                Console.WriteLine("O resultado da divisão é: {resultado}");
                break;
            }
        }
        break;
    }

    case 'N':
    {
        Console.WriteLine("Calculadora encerrada.");
        break;
    }

}




