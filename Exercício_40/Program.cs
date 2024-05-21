/*  A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
 altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe
 para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
 industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos
 devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e
 emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o 
usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". */

char opcao;
do
{
    double indicepoluicao;
    Console.WriteLine("Informe o índice de poluição atual (valor entre 0 e 1): ");
    indicepoluicao = Convert.ToDouble(Console.ReadLine());
    if( indicepoluicao < 0 || indicepoluicao > 1)
    {
        Console.WriteLine("índice incorreto. Por favor informe novamente. ");
        indicepoluicao = Convert.ToDouble(Console.ReadLine());
    }
    if(indicepoluicao > 0 && indicepoluicao <= 0.25)
    {
        Console.WriteLine("Nenhuma empresa precisa suspender suas atividades.");
    }
    else if(indicepoluicao >= 0.3 && indicepoluicao < 0.40)
    {
        Console.WriteLine("As industrias do 1º grupo devem suspender suas atividades.");
    }
    else if (indicepoluicao >= 0.40 && indicepoluicao < 0.50)
    {
        Console.WriteLine("As industrias do 1º e 2º grupo devem suspender suas atividades.");
    }
    else
    {
        Console.WriteLine("As industrias do 1º, 2º e 3º grupo dever suspender suas atividades.");
    }
    Console.WriteLine("Deseja encerrar o programa (S / N)?");
    opcao = Convert.ToChar(Console.ReadLine().ToUpper());
}
while(opcao != 'S');
