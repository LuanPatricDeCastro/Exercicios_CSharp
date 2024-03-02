// Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
// aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
// do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
// apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
// apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
// aluno.

double nota1, nota2, nota3, nota4, recuperacao, media, mediafinal;

Console.Write("Informe a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
if(media >= 7) 
{
    Console.WriteLine("O aluno foi aprovado com a média final: {0}", media);
}
else
{
    Console.WriteLine("você está de recuperação. ");
    Console.Write("Por favor. Informe a nota da recuperação: ");
    recuperacao = Convert.ToDouble(Console.ReadLine());
    {
        
        mediafinal = (media + recuperacao) / 2;
    }
    
    if(mediafinal >= 7)
    {
        Console.WriteLine("Você foi aprovado com média final de: {0}", mediafinal);
    }
    else
    {
        Console.WriteLine("Você foi reprovado com média final de: {0}", mediafinal);
    }
}