class Alimento
{

    private string nomeAlimento;
    private double valorAlimento;
    public string NomeAlimento { get { return nomeAlimento; } set { this.nomeAlimento = value; } }


    public Alimento(string nomeAlimento, double valorAlimento)
    {
        this.nomeAlimento = nomeAlimento;
        this.valorAlimento = valorAlimento;
    }   
}