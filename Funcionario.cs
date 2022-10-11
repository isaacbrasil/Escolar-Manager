class Funcionario : Pessoa
{
    private string nomeFuncao;
    Sistema sistema = new Sistema();

    public string NomeFuncao
    {
        get { return this.nomeFuncao; }
        set { nomeFuncao = value; }
    }

      public void CadastraItemCantina()
    {
        Console.WriteLine("Digite a quantidade de itens que quer cadastrar:");
        int numItens= Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt", true);

        List<string> listaItensCantina = new List<string>();
        for (int i = 0; i < numItens; i++)
        {
            Console.WriteLine("Insira o nome do item " + (i + 1) + "e o valor: ");
            listaItensCantina.Add(Console.ReadLine());
        }

        IEnumerable<string> itensFiltrados = listaItensCantina.OrderBy(n => n); // filtra os alimentos em ordem alfabética com query LINQ
        string last = itensFiltrados.Last(); // pega o ultimo elemento com LINQ query para poder remover a vírgula no final das concatenações

        foreach (string itens in itensFiltrados)
        {

            if (itens == last)
            {
                escritor.WriteLine(itens);
                Console.Write(itens);
            }
            else
            {
                escritor.WriteLine(itens);
                Console.Write(itens + ", ");
            }


        }

        Console.WriteLine("");
        sistema.MensagemSucesso();

        escritor.Close();


    }

    public void DeletaItemCantina()
    {
        if (File.Exists("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt") && new FileInfo("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt").Length != 0)
        {
            File.WriteAllText("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt", string.Empty);
            sistema.MensagemSucesso();

        }
        else 
        {
            Console.WriteLine("Não existe nenhum item cadastrado ainda!");
        }

    }




}

