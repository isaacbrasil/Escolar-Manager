public class Aluno : Pessoa
{

    public override string ToString()
    {
        return "Nome: " + Nome + " | Sexo: " + Sexo + " | Matrícula: " + Id + " | Turma: " + Turma + " | Escola: " + EscolaNome;
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

    public override void MostraDados(Pessoa aluno)
    {
        Console.WriteLine("Nome: " + aluno.Nome);
        Console.WriteLine("Matrícula: " + aluno.Id);
        Console.WriteLine("Sexo: " + aluno.Sexo);
        Console.Write("Notas: ");
        int indexAluno = 0;
        foreach (var nota in notas)
        {
            Console.Write(((Aluno)aluno).Notas[(indexAluno)].ToString() + " | "); //utiliza o toString para transformar o conteudo notas em uma string
            indexAluno++;
        }
        Console.WriteLine("");
        Console.WriteLine("Escola: " + ((Aluno)aluno).EscolaNome); //downcasting
        Console.WriteLine("Turma: " + ((Aluno)aluno).Turma); //downcasting
    }

    public void ExibeComprovanteDeMatricula(Aluno aluno)
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");
        DateTime dataHoje = DateTime.Now;
        if (aluno.Sexo.ToString().Equals("M")) //UTILIZO EQUALS PARA VALIDAR SEXO DO ALUNO
        {
            Console.WriteLine("Atestamos que o aluno " + aluno.Nome + ",\r\nde matrícula N° " + aluno.Id + ", está no presente momento de\r\n" + dataHoje.ToString("d") + " matriculado na Instituição de Ensino " + aluno.EscolaNome + ".");
        }
        else
        {
            Console.WriteLine("Atestamos que a aluna " + aluno.Nome + ",\r\nde matrícula N° " + aluno.Id + ", está no presente momento de\r\n" + dataHoje.ToString("d") + " matriculada na Instituição de Ensino " + aluno.EscolaNome + ".");

        }
        Console.WriteLine("");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

   
    public virtual double CalculaMedia(List<Aluno> alunos, int i)
    {


        double media = alunos[(i - 1)].Notas.Average(); //CLEAN CODE: Reutilizar código já escrito: isso inclui o uso de bibliotecas, ou códigos escritos por mim ou terceiros
        return Math.Round(media, 2);

    }


}