class Funcionario : Pessoa
{
    private string nomeFuncao;

    public string NomeFuncao
    {
        get { return this.nomeFuncao; }
        set { nomeFuncao = value; }
    }

    public override void MenuOperação()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Funcionário, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar alimento cantina");
        Console.WriteLine("2 - Remover alimento cantina");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

}

