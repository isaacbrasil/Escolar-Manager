public class Funcionario : Pessoa
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
            if (ChecaExistenciaProduto(produtos, newProduto.NomeAlimento.GetHashCode()))
            {
                break;
            }
            Console.WriteLine("Insira o valor do produto: ");
            newProduto.ValorAlimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira quantas unidades desse produto: ");
            newProduto.QuantidadeItens = Convert.ToInt32(Console.ReadLine());

            produtos.Add(newProduto);
        }


        foreach (Produto produto in produtos)
        {

            escritor.WriteLine(produto.ToString());

        }


        Console.WriteLine("");

        escritor.Close();
        return produtos;

    }

    public void DeletaItemCantina(List<Produto> produtos, int indexProduto)
    {
        if (indexProduto > 0 && produtos.Count > 0 && indexProduto <= produtos.Count)
        {
            produtos.RemoveAt((indexProduto - 1));
            DeletaRegistroArquivoProduto(produtos, indexProduto);
        }

        else if (indexProduto <= 0 || indexProduto > produtos.Count)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Insira um índice válido!");
            Console.ResetColor();

        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
    }
    public void DeletaRegistroArquivoProduto(List<Produto> produtos, int index)
    {
        string filePath = "C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/cantina.txt";
        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0 && (index - 1) <= produtos.Count && index > 0)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(filePath));
            file.RemoveAt(index - 1);
            File.WriteAllLines(filePath, file.ToArray());
        }


    }

    public void MostraItensCantina(List<Produto> produtos)
    {

        Console.WriteLine("");

        int i = 0;
        if (produtos.Count > 0)
        {
            Console.WriteLine("========== CANTINA ==========");

            foreach (var alimento in produtos)
            {
                Console.WriteLine((i + 1) + "- " + alimento.NomeAlimento + " | Preço: R$ " + alimento.ValorAlimento + " | Unidades: " + alimento.QuantidadeItens + "x");
                i++;
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado.");


        }
        Console.WriteLine("");

    }

    public double CalculaCaixaCantina(List<Produto> produtos)
    {
        MostraItensCantina(produtos);
        Console.WriteLine("");

        double somaCaixa = 0;
        int quantidadeMensal = 30;

        foreach (var produto in produtos)
        {

            somaCaixa += produto.ValorAlimento * produto.QuantidadeItens;
        }

        return Math.Round((somaCaixa * quantidadeMensal),2);

    }

    public bool ChecaExistenciaProduto(List<Produto> produtos, int hashNome) // checa se já existe um hashcode na lista alunos
    {
        foreach (Produto produto in produtos)
        {
            int hash = produto.NomeAlimento.GetHashCode();

            if (hash.Equals(hashNome))
            {
                Console.WriteLine("");
                Console.WriteLine("Esse produto já existe no registro.");
                Console.WriteLine("");
                return true;
            }
        }

        return false;
    }
   
  
}

