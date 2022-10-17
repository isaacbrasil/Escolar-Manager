﻿class Funcionario : Pessoa
{
    Sistema sistema = new Sistema();

    public List<Produto> CadastraItemCantina(List<Produto> produtos)
    {
        Console.WriteLine("Digite a quantidade de itens que quer cadastrar:");
        int numItens = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt");

        for (int i = 0; i < numItens; i++) //cadastra mais produtos na lista produtos
        {
            Produto newProduto = new Produto();
            Console.WriteLine("Insira o nome do produto: " + (i + 1));
            newProduto.NomeAlimento = Console.ReadLine().ToUpper();
            Console.WriteLine("Insira o valor do produto: ");
            newProduto.ValorAlimento = Convert.ToDouble(Console.ReadLine());

            produtos.Add(newProduto);
        }

        var itensOrdenados = produtos.OrderBy(n => n.NomeAlimento); //LINQ QUERY + expressao lambda que ordena alfabeticamente a lista de alunos


        foreach (Produto produto in itensOrdenados)
        {

            escritor.WriteLine(produto.ToString());

        }


        Console.WriteLine("");
        sistema.MensagemSucesso();

        escritor.Close();
        return produtos;

    }

    public void DeletaItemCantina(List<Produto> produtos)
    {
        if (produtos.Count > 0)
        {
            produtos.Clear();

        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado");
        }

    }


    public void MostraItensCantina(List<Produto> produtos)
    {

        Console.WriteLine("");

        int i = 0;
        if (produtos.Count > 0)
        {
            Console.WriteLine("========== CANTINA ========== ");

            foreach (var alimento in produtos)
            {
                Console.WriteLine((i + 1) + "- " + alimento.NomeAlimento + " | Preço: R$ " + alimento.ValorAlimento);
                i++;
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado");


        }
        Console.WriteLine("");

    }

}

