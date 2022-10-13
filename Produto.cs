class Produto
{

    private string nomeAlimento;
    private double valorAlimento;
    public string NomeAlimento { get { return nomeAlimento; } set { this.nomeAlimento = value; } }
    public double ValorAlimento { get { return valorAlimento; } set { this.valorAlimento = value; } }

    public override string ToString()
    {

        return "Produto: " + NomeAlimento + " | Preço: R$ " + ValorAlimento;

    }

    public Produto(string nomeAlimento, double valorAlimento)
    {
        this.nomeAlimento = nomeAlimento;
        this.valorAlimento = valorAlimento;
    }
    public Produto()
    {
        this.nomeAlimento = "";
        this.valorAlimento = 0;
    }
}