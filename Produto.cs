public class Produto
{

    public string NomeAlimento { get; set; }
    public double ValorAlimento { get; set; }
    public int QuantidadeItens { get; set; }

    public override string ToString()
    {

        return "Produto: " + NomeAlimento + " | Preço: R$ " + ValorAlimento + " | Quantidade: " + QuantidadeItens + "x";

    }

    public Produto(string nomeAlimento, double valorAlimento, int quantidadeItens)
    {
        NomeAlimento = nomeAlimento;
        ValorAlimento = valorAlimento;
        QuantidadeItens = quantidadeItens;

    }
    public Produto()
    {
        NomeAlimento = "";
        ValorAlimento = 0;
        QuantidadeItens = 0;
    }
}