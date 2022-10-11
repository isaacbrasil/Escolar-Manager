class Professor : Pessoa
{
    private double taxaAprovacao;
    private double salarioProfessor;


    public double TaxaAprovacao
    {
        get { return taxaAprovacao; }
        set { taxaAprovacao = value; }
    }

    public double SalarioProfessor
    {
        get { return salarioProfessor; }
        set { salarioProfessor = value; }
    }

    public Professor(double taxaAprovacao, double salarioProfessor)
    {
        this.taxaAprovacao = taxaAprovacao;
        this.salarioProfessor = salarioProfessor;
    }
    public Professor()
    {
        this.taxaAprovacao = 0;
        this.salarioProfessor = 0;
    }

    public double CalculaTaxaAprovacao(int numAlunos, int alunosAprovados)
    {
        return Math.Round(((double)alunosAprovados / (double)numAlunos) * 100, 2); //limita o resultado double para duas casas decimais e utiliza conversão explícita
        //ao deixar esses valores originalmente como int o resultado não sai correto
    }
 

}