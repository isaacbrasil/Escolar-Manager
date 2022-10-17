class Sistema
{
    //CLASSE SISTEMA CRIADA PARA UTILIZAÇÃO DA NOÇÃO DRY - DON'T REPEAT YOURSELF
    public void MenuSistema()
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
    public void MenuUsuário()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Digite seu tipo de usuário: ");
        Console.WriteLine("");
        System.Console.WriteLine("1 - Admin");
        System.Console.WriteLine("2 - Aluno");
        System.Console.WriteLine("3 - Professor");
        System.Console.WriteLine("4 - Funcionário");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");

    }
    public void MenuOperaçãoAdmin()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Administrador, Qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar professores");
        Console.WriteLine("2 - Cadastrar alunos");
        Console.WriteLine("3 - Deletar registro professores");
        Console.WriteLine("4 - Deletar registro alunos");
        Console.WriteLine("5 - Mostrar professores cadastrados");
        Console.WriteLine("6 - Mostrar alunos cadastrados");

        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

    public void MenuOperaçãoAluno()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Aluno, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Calcular média");
        Console.WriteLine("2 - Emitir comprovante de matrícula");
        Console.WriteLine("3 - Exibir Informações Aluno");

        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }
    public void MenuOperaçãoProf()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Professor, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar notas alunos");
        Console.WriteLine("2 - Calcular taxa de aprovação");
        Console.WriteLine("3 - Exibir Informações Professor");
        Console.WriteLine("4 - Testar Downcasting de Professor");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");



    }


    public void MenuOperaçãoFunc()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Funcionário, qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar alimento cantina");
        Console.WriteLine("2 - Remover alimento cantina");
        Console.WriteLine("3 - Mostrar alimentos da cantina");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

    public void MensagemSucesso()
    {
        Console.WriteLine("Operação Realizada com Sucesso!\r\n");

    }

}