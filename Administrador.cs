using System.Linq;
class Administrador : Pessoa
{
    Sistema sistema = new Sistema();
    public List<Aluno> CadastraAluno(List<Aluno> alunos)
    {
        Console.WriteLine("Digite a quantidade de alunos que quer cadastrar:");
        int numAlunos = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt", true);

        List<Aluno> listAlunos = new List<Aluno>() {
                            new Aluno()
                            {
                                Nome = "Isaac",
                                Notas = new double[] { 0, 2, 3, 4, 5 }, //2,8
                                Turma = 'A',
                                EscolaNome = "Colégio Visão"
                            },
                             new Aluno()
                            {
                                Nome = "Gabriel",
                                Notas = new double[] { 1, 10, 7, 6, 6 },//6
                                Turma = 'B',
                                EscolaNome = "Colégio Delta"
                             },
                              new Aluno()
                            {
                                Nome = "Lucas",
                                Notas = new double[] { 10, 7, 8, 6, 6 },//7,4
                                Turma = 'C',
                                EscolaNome = "Colégio WR"
                            }
        };

        

        for (int i = 0; i < numAlunos; i++) //cadastra mais alunos na listAlunos
        {
            Aluno newAluno = new Aluno();
            Console.WriteLine("Insira o nome do aluno: " + (i + 1));
            newAluno.Nome = Console.ReadLine();
            Console.WriteLine("Insira as 5 notas do aluno: ");
            for (int j = 0; j < 5; j++)
            {
                newAluno.Notas[j] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Insira a turma do aluno: ");
            newAluno.Turma = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Insira a Escola do aluno: ");
            newAluno.EscolaNome = Console.ReadLine();

            listAlunos.Add(newAluno);
        }
       

        /*List<string> listaAlunos = new List<string>();

        IEnumerable<string> alunosFiltrados = alunos[].Nome.OrderBy(n => n); // filtra os alunos em ordem alfabética com query LINQ
        string last = alunosFiltrados.Last(); // pega o ultimo elemento com LINQ query para poder remover a vírgula no final das concatenações
        foreach (string aluno in alunosFiltrados)
        {
            if (aluno == last)
            {
                escritor.WriteLine(aluno);
                Console.Write(aluno);
            }
            else
            {
                escritor.WriteLine(aluno);
                Console.Write(aluno + ", ");
            }
        }
        Console.WriteLine("");
*/        sistema.MensagemSucesso();
        escritor.Close();

        return listAlunos;
    }

    public void CadastraProfessor()
    {
        Console.WriteLine("Digite a quantidade de professores que quer cadastrar:");
        int numProfs = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt", true);

        List<string> listaProfessores = new List<string>();
        for (int i = 0; i < numProfs; i++)
        {
            Console.WriteLine("Insira o nome do professor: " + (i + 1));
            listaProfessores.Add(Console.ReadLine());
        }

        IEnumerable<string> profsFiltrados = listaProfessores.OrderBy(n => n); // filtra os professores em ordem alfabética com query LINQ
        string last = profsFiltrados.Last(); // pega o ultimo elemento com LINQ query para poder remover a vírgula no final das concatenações

        foreach (string prof in profsFiltrados)
        {

            if (prof == last)
            {
                escritor.WriteLine(prof);
                Console.Write(prof);
            }
            else
            {
                escritor.WriteLine(prof);
                Console.Write(prof + ", ");
            }


        }

        Console.WriteLine("");
        sistema.MensagemSucesso();

        escritor.Close();


    }

    public void DeletaProfessores()
    {
        if (File.Exists("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt") && new FileInfo("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt").Length != 0)
        {
            File.WriteAllText("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt", string.Empty);

            sistema.MensagemSucesso();
        }
        else
        {
            Console.WriteLine("Não existe nenhum professor cadastrado ainda!");

        }

    }
    public void DeletaAlunos()
    {
        if (File.Exists("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt") && new FileInfo("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt").Length != 0)
        {
            File.WriteAllText("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt", string.Empty);

            sistema.MensagemSucesso();
        }
        else
        {
            Console.WriteLine("Não existe nenhum aluno cadastrado ainda!");

        }

    }

    public void MostraAlunos(List<Aluno> alunos)
    {
        Console.WriteLine("Alunos: ");
        foreach(Aluno aluno in alunos)
        {
            Console.WriteLine(aluno.Nome);
        }

        /*if (File.Exists("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt") && new FileInfo("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt").Length != 0)
        {
            TextReader leitor = new StreamReader("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt");
            string linha = leitor.ReadLine();
            Console.WriteLine("Alunos: ");
            Console.WriteLine("");
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();

            }
            Console.WriteLine("");

        }
        else
        {
            Console.WriteLine("Não existe nenhum aluno cadastrado ainda!");

        }*/


    }

    public void MostraProfessores()
    {
        if (File.Exists("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt") && new FileInfo("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt").Length != 0)
        {
            TextReader leitor = new StreamReader("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt");
            string linha = leitor.ReadLine();
            Console.WriteLine("Professores: ");
            Console.WriteLine("");
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();

            }
            Console.WriteLine("");

        }
        else
        {
            Console.WriteLine("Não existe nenhum professor cadastrado ainda!");

        }


    }

}