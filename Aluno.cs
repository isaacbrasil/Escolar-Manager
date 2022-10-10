class Aluno : Pessoa
{
    private int[] notas;
    private char turma;
    private string escolaNome;

    public int[] Notas
    {

        get { return notas; }
        set { notas = value; }

    }

    public char Turma
    {

        get { return turma; }
        set { turma = value; }

    }

    public string EscolaNome
    {

        get { return escolaNome; }
        set { escolaNome = value; }

    }

    public Aluno(string nome, int[] notas, char turma, string escolaNome)
    {
        Nome = nome;
        this.notas = notas;
        this.turma = turma;
        this.escolaNome = escolaNome;

    }
    public Aluno()
    {
        this.notas = new int[] { 0, 3, 4, 5 };
        this.turma = '0';

    }


    public override void MostraDados()
    {
        Console.Write("Notas: ");
        foreach (var nota in notas)
        {

            Console.Write("|" + nota.ToString());
        }
        Console.WriteLine("");
        Console.WriteLine("Turma: " + turma);

    }

    public override void MenuOperação()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Aluno, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Calcular média");
        Console.WriteLine("2 - Solicitar comprovante de matrícula");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

    public void ExibeComprovanteDeMatricula(Aluno aluno)
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");
        DateTime dataHoje = DateTime.Now;
        Console.WriteLine("Atestamos que o aluno " + aluno.Nome + ", de matrícula N° "+ aluno.Id + ", está no presente momento de " + dataHoje.ToString("d") + " matriculado na Instituição de Ensino " + aluno.EscolaNome );
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }


}