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

    public override void MenuOperação()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Professor, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar notas alunos");
        Console.WriteLine("2 - Calcular taxa aprovação");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");



    }

}