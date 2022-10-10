class Pessoa
{
    private string nome;
    private int idade;
    private int id;
    private string tipoUsuario;
    private string senha;
    private static int numero = 1223;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
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
        Console.WriteLine("Nome: " + senha);
        System.Console.WriteLine("------------------------------------------------------------");

    }
    public virtual void MenuSistema()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo ao Software Escolar Manager!");
        Console.WriteLine("");
        System.Console.WriteLine("Digite a operação que deseja realizar: ");
        Console.WriteLine("");
        System.Console.WriteLine("1 - Logar no Sistema ");
        System.Console.WriteLine("0 - Sair");
        System.Console.WriteLine("------------------------------------------------------------");

    }
    public virtual void MenuUsuário()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Digite seu tipo de usuário: ");
        Console.WriteLine("");
        System.Console.WriteLine("1 - Admin");
        System.Console.WriteLine("2 - Aluno");
        System.Console.WriteLine("3 - Professor");
        System.Console.WriteLine("4 - Funcionario");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");

    }

    public virtual void MenuOperação()
    {
        Console.WriteLine("Qual operação você deseja realizar ?");

    }

}