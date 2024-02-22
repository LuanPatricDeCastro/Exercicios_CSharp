// Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
// comissão será de 5% do total da venda e que você tem os seguintes dados:
// - Identificação do vendedor
// - Código da peça
// - Preço unitário da peça
// - Quantidade vendida

double valorpeca, valorvenda, comissao;
int idvendedor, codigopeca, quantidadevendida;

Console.WriteLine("Lista das peças disponíveis: ");
Console.WriteLine("001 = Teclado");
Console.WriteLine("002 = mouse");
Console.WriteLine("003 = monitor");
Console.WriteLine("004 = placa-mãe");
Console.WriteLine("005 = processador");

Console.WriteLine("Informe o código da peça: ");
codigopeca = Convert.ToInt32(Console.ReadLine());
if(codigopeca > 005)
{
    Console.WriteLine("Código inválido. Digite novamente.");
    codigopeca = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Informe o preço do produto: ");
valorpeca = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidade vendida: ");
quantidadevendida = Convert.ToInt32(Console.ReadLine());
if(quantidadevendida < 0)
{
    Console.WriteLine("Verifique a quantidade informada e digite novamente.");
    quantidadevendida = Convert.ToInt32(Console.ReadLine());
}

valorvenda = valorpeca * quantidadevendida;

Console.WriteLine("Informe o vendedor através do código: ");
Console.WriteLine("Lista dos vendedores: ");
Console.WriteLine("1 - Luan");
Console.WriteLine("2 - Josiane");
Console.WriteLine("3 - Camilo");
Console.WriteLine("4 - Juliano");

idvendedor = Convert.ToInt32(Console.ReadLine());
if(idvendedor > 4)
{
    Console.WriteLine("Verifique o código do vendedor e digite novamente:");
    idvendedor = Convert.ToInt32(Console.ReadLine());
}

comissao = 0.05 * valorvenda;

Console.WriteLine("Dados da venda:");
Console.Write("Código da peça: {0}, Quantidadevendida: {1}, Valor da venda: R$ {2:n2}, Vendedor: {3}, Comissão pela venda: R$ {4:n2}",
codigopeca, quantidadevendida, valorvenda, idvendedor, comissao);
