class Pessoa
{
    private string nome;
    private int idade;
    private int id;
    private string tipoUsuario;
    private string senha;
    private static int numero = 202201500;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public override int GetHashCode()
    {
        return this.Nome.GetHashCode() * 17;
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string TipoUsuario
    {
        get { return tipoUsuario; }
        set { tipoUsuario = value; }
    }

    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }

    public Pessoa(string nome, int idade, int id)
    {
        this.nome = nome;
        this.idade = idade;
        this.id = id;
    }

    public Pessoa()
    {
        this.nome = "";
        this.idade = 0;
        Pessoa.numero++;
        this.id = Pessoa.numero;
    }

    public virtual void MostraDados()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Usuário: " + tipoUsuario);
        System.Console.WriteLine("------------------------------------------------------------");

    }


    public virtual void MenuOperação()
    {
        Console.WriteLine("Qual operação você deseja realizar ?");

    }

}