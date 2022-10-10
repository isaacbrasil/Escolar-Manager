using System.Linq;
class Administrador : Pessoa
{
    private string assinatura;

    public override void MenuOperação()
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bem-Vindo Administrador, Qual operação você deseja realizar ?");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar professores");
        Console.WriteLine("2 - Cadastrar alunos");
        Console.WriteLine("3 - Alterar salário professores");
        System.Console.WriteLine("0 - Voltar");
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");


    }

    public void CadastraAluno()
    {
        Console.WriteLine("Digite a quantidade de alunos que quer cadastrar:");
        int numAlunos = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        while (numAlunos != 0)
        {
            List<string> listaAlunos = new List<string>();
            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine("Insira o nome do aluno: " + (i + 1));
                listaAlunos.Add(Console.ReadLine());
            }

            foreach (string aluno in listaAlunos)
            {
                Console.Write(aluno + ", ");

            }

            Console.WriteLine("");
        }
    }

    public void CadastraProfessor()
    {
        Console.WriteLine("Digite a quantidade de professores que quer cadastrar:");
        int numProfs = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        while (numProfs != 0) {

            List<string> listaProfessores = new List<string>();
            for (int i = 0; i < numProfs; i++)
            {
                Console.WriteLine("Insira o nome do aluno: " + (i + 1));
                listaProfessores.Add(Console.ReadLine());
            }

            foreach (string professor in listaProfessores)
            {
                Console.Write(professor + ", ");

            }

            Console.WriteLine("");
        }
    }

}