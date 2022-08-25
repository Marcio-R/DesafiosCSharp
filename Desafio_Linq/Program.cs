//Escrever um programa que recebe um produto como argumento,
//validar se esse produto está na lista de itens disponíveis do mercado.
//Caso esteja, avisar se possui ou não e,
//por último, exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado,
//para que o usuário possa pedir na próxima vez.

string mensagem = "";

try
{
    List<string> listamercado = new List<string>()
    {
        "Tomate",
        "Cebola",
        "Coca-Cola",
        "Batata",
        "Vinho",
        "Pilha",
        "Ovo",
        "Água",
        "Frango",
        "Mel"
    };

    Console.WriteLine("Digite o produto que gostaria de comprar:");
    string produtoselecionado = Console.ReadLine();

    bool validaproduto = listamercado.Where(x => x.Equals(produtoselecionado)).Any();

    if(validaproduto == true)
    {
        Console.WriteLine($"Pode comprar o produto {produtoselecionado} pois ele está disponivel! ");
    }
    else
    {
        Console.WriteLine($"O produto {produtoselecionado} não está a venda");
    }

    Console.WriteLine("Produtos disponiveis são:");
    foreach (var produtos in listamercado.OrderBy(produtos => produtos))
    {
        Console.WriteLine(produtos);
    }

    mensagem = "Obrigado por ter utizado o sistema de mercado! E boas compras!";
}
catch(Exception ex)
{
    mensagem = $"Aconteceu o seguinte problema: {ex.Message}";
}