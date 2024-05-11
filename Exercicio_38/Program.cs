/* Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um 
operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 
50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora 
excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O 
programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o 
programa?".*/

double C, N, E, SalarioTotal;
char resposta;

double [] empresa = new double [1000];
{
    for(int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Bem vindo a calculadora de salário! ");
        Console.WriteLine("Deseja encerrar a aplicação? ");
        Console.WriteLine("Responda 'S' caso Sim e 'N' caso Não: ");
        resposta = Convert.ToChar(Console.ReadLine().ToUpper());
        while(resposta == 'N')
        {
            Console.Write("Informe o código do colaborador: ");
            C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de horas trabalhadas: ");
            N = Convert.ToDouble(Console.ReadLine()); 
            if(N > 50)
            {
                E = N - 50;
                Console.WriteLine("O colaborador de Código {0} trabalhou {1} horas extras",C, E);
            
                SalarioTotal = ((N - E) * 10) + (E * 20);
            } else
            {
                SalarioTotal = N * 10;
            }

            
            Console.WriteLine("Seu salário é: R$ {0}", SalarioTotal);  
            Console.WriteLine("Deseja encerrar a aplicação");
            Console.WriteLine("Responda 'S' caso Sim e 'N' caso Não: ");
            resposta = Convert.ToChar(Console.ReadLine().ToUpper());   
        }
        if(resposta == 'S')
        {
            Console.WriteLine("Programa encerrado.");
            break;
        }
    }
}
        
