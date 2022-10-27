public class Funcionario : Pessoa
{

    public static List<Produto> CadastraItemCantina(List<Produto> produtos)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Dados serão gravados em:\n\r" + AppDomain.CurrentDomain.BaseDirectory + "cantina.txt\r\n");
        Console.ResetColor();
        Console.WriteLine("Digite a quantidade de itens que quer cadastrar:");

        if (int.TryParse(Console.ReadLine(), out int numItens) && numItens > 0) {
            Console.Clear();
            TextWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "cantina.txt");

            for (int i = 0; i < numItens; i++) //cadastra mais produtos na lista produtos
            {
                Produto newProduto = new ();
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


        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Insira apenas valores numéricos.");
            Console.ResetColor();
        }
            return produtos;

    }

    public static void DeletaItemCantina(List<Produto> produtos)
    {
        Console.WriteLine("Insira qual índice do produto a ser deletado: ");

        if (int.TryParse(Console.ReadLine(), out int indexProduto) && indexProduto > 0 && produtos.Count > 0 && indexProduto <= produtos.Count)
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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhum produto cadastrado.");
            Console.ResetColor();

        }
    }
    public static void DeletaRegistroArquivoProduto(List<Produto> produtos, int index)
    {
        string filePath = AppDomain.CurrentDomain.BaseDirectory + "cantina.txt";
        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0 && (index - 1) <= produtos.Count && index > 0)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(filePath));
            file.RemoveAt(index - 1);
            File.WriteAllLines(filePath, file.ToArray());
        }


    }

    public static void MostraItensCantina(List<Produto> produtos)
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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhum produto cadastrado.");
            Console.ResetColor();


        }
        Console.WriteLine("");

    }

    public static double CalculaCaixaCantina(List<Produto> produtos)
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

    public static bool ChecaExistenciaProduto(List<Produto> produtos, int hashNome) // checa se já existe um hashcode na lista alunos
    {
        foreach (Produto produto in produtos)
        {
            int hash = produto.NomeAlimento.GetHashCode();

            if (hash.Equals(hashNome))
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Esse produto já existe no registro.");
                Console.ResetColor();

                return true;
            }
        }

        return false;
    }
   
  
}

