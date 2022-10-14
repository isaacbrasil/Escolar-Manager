class Professor : Pessoa
{
    private double taxaAprovacao;
    private string materia;

    public override string ToString()
    {

        return "Nome: " + Nome + " | Matéria: " + Materia;
    }
    public double TaxaAprovacao
    {
        get { return taxaAprovacao; }
        set { taxaAprovacao = value; }
    }
    public string Materia
    {
        get { return materia; }
        set { materia = value; }
    }
   

    public Professor(double taxaAprovacao)
    {
        this.taxaAprovacao = taxaAprovacao;
       
    }
    public Professor()
    {
        this.taxaAprovacao = 0;
    }

    public double CalculaTaxaAprovacao(int numAlunos, int alunosAprovados)
    {
        return Math.Round(((double)alunosAprovados / (double)numAlunos) * 100, 2); //limita o resultado double para duas casas decimais e utiliza conversão explícita
       
    }

    public void MostraDadosProfessor(Professor professor)
    {
        Console.WriteLine("Nome: " + professor.Nome);
        Console.WriteLine("Id: " + professor.Id);
        Console.WriteLine("Matéria: " + professor.Materia);

    }

}