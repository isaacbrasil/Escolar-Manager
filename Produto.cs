public class Produto
{

    private string nomeAlimento;
    private double valorAlimento;
    private int quantidadeItens;
    public string NomeAlimento { get { return nomeAlimento; } set { this.nomeAlimento = value; } }
    public double ValorAlimento { get { return valorAlimento; } set { this.valorAlimento = value; } }
    public int QuantidadeItens { get { return quantidadeItens; } set { this.quantidadeItens = value; } }


    public override string ToString()
    {

        return "Produto: " + NomeAlimento + " | Preço: R$ " + ValorAlimento + " | Quantidade: " + QuantidadeItens + "x";

    }

    public Produto(string nomeAlimento, double valorAlimento, int quantidadeItens)
    {
        this.nomeAlimento = nomeAlimento;
        this.valorAlimento = valorAlimento;
        this.quantidadeItens = quantidadeItens;

    }
    public Produto()
    {
        this.nomeAlimento = "";
        this.valorAlimento = 0;
        this.quantidadeItens = 0;
    }
}