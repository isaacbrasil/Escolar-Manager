class Aluno : Pessoa
{
    public override string ToString()
    {

        return "Nome: "+ Nome + " | Matrícula: " + Id + " | Turma: " + Turma + " | Escola: " + EscolaNome + " | Média: ";
    }
    private double[] notas;
    private char turma;
    private string escolaNome;
    public double[] Notas
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

    public Aluno(string nome, double[] notas, char turma, string escolaNome)
    {
        Nome = nome;
        this.notas = notas;
        this.turma = turma;
        this.escolaNome = escolaNome;

    }
    public Aluno()
    {
        this.notas = new double[] { 0, 0, 0, 0, 0 };
        this.turma = '0';

    }

    public void MostraDadosAluno(Aluno aluno)
    {
        Console.WriteLine("Nome: " + aluno.Nome);
        Console.WriteLine("Matrícula: " + aluno.Id);
        Console.Write("Notas: ");
        int indexAluno = 0;
        foreach (var nota in notas)
        {
            Console.Write(aluno.Notas[(indexAluno)].ToString() + " | "); //utiliza o toString para transformar o conteudo notas em uma string
            indexAluno++;
        }
        Console.WriteLine("");
        Console.WriteLine("Escola: " + aluno.EscolaNome);
        Console.WriteLine("Turma: " + aluno.Turma);

    }

    public void ExibeComprovanteDeMatricula(Aluno aluno)
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");
        DateTime dataHoje = DateTime.Now;
        Console.WriteLine("Atestamos que o aluno " + aluno.Nome + ", de matrícula N° " + aluno.Id + ", está no\r\npresente momento de " + dataHoje.ToString("d") + " matriculado na Instituição\r\nde Ensino " + aluno.EscolaNome + ".");
        Console.WriteLine("");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

    public void MostraAlunos(List<Aluno> alunos)
    {


        int i = 0;
        foreach (var aluno in alunos)
        {
            Console.WriteLine((i + 1) + "- " + aluno.Nome);
            i++;
        }
        Console.WriteLine("");

    }

    public virtual double CalculaMedia(List<Aluno> alunos, int i)
    {


        double media = alunos[(i-1)].Notas.Average(); //CLEAN CODE: Reutilizar código já escrito: isso inclui o uso de bibliotecas, ou códigos escritos por mim ou terceiros


        return media;
    }


}