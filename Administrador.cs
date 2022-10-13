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

        for (int i = 0; i < numAlunos; i++) //cadastra mais alunos na lista alunos
        {
            Aluno newAluno = new Aluno();
            Console.WriteLine("Insira o nome do aluno: " + (i + 1));
            newAluno.Nome = Console.ReadLine();
           /* Console.WriteLine("Insira as 5 notas do aluno: ");
            for (int j = 0; j < 5; j++)
            {
                newAluno.Notas[j] = Convert.ToDouble(Console.ReadLine());
            }*/
            Console.WriteLine("Insira a turma do aluno: ");
            newAluno.Turma = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Insira a Escola do aluno: ");
            newAluno.EscolaNome = Console.ReadLine();

            alunos.Add(newAluno);
        }
        int indexMedia = 0;
        foreach (Aluno aluno in alunos)
        {

            double media = aluno.CalculaMedia(alunos, (indexMedia+1));
            escritor.WriteLine(aluno.ToString()+ media);
            indexMedia++;

        }



        sistema.MensagemSucesso();
        escritor.Close();

        return alunos;
    }

    public List<Professor> CadastraProfessor(List<Professor> professores)
    {

        Console.WriteLine("Digite a quantidade de professores que quer cadastrar:");
        int numProfs = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt", true);

        for (int i = 0; i < numProfs; i++) //cadastra mais professores na lista professores
        {
            Professor newProf = new Professor();
            Console.WriteLine("Insira o nome do professor: " + (i + 1));
            newProf.Nome = Console.ReadLine();
            professores.Add(newProf);
        }

        foreach (Professor professor in professores)
        {

            escritor.WriteLine(professor.ToString() );

        }

        Console.WriteLine("");
        sistema.MensagemSucesso();

        escritor.Close();

        return professores;

    }

    public void DeletaProfessores(List<Professor> professores)
    {

        if (professores.Count > 0)
        {
            professores.Clear();
        }
        else
        {
            Console.WriteLine("Nenhum professor cadastrado");

        }


    }
    public void DeletaAlunos(List<Aluno> alunos)
    {
        if (alunos.Count > 0)
        {
            alunos.Clear();

        }
        else
        {
            Console.WriteLine("Nenhum aluno cadastrado");
        }
    }

    public void MostraAlunos(List<Aluno> alunos)
    {
        Console.WriteLine("");

        if (alunos.Count > 0)
        {
            Console.WriteLine("Alunos: \r\n");
            int i = 0;
            foreach (Aluno aluno in alunos)
            {

                Console.WriteLine((i + 1) + "-" + aluno.Nome);
                i++;
            }


        }
        else
        {
            Console.WriteLine("Nenhum aluno cadastrado");


        }
        Console.WriteLine("");

    }

    public void MostraProfessores(List<Professor> professores)
    {
        Console.WriteLine("");

        if (professores.Count > 0)
        {
            Console.WriteLine("Professores: \r\n");
            int i = 0;
            foreach (Professor professor in professores)
            {
                Console.WriteLine((i + 1) + "-" + professor.Nome);
                i++;

            }
        }
        else
        {
            Console.WriteLine("Nenhum professor cadastrado");

        }
        Console.WriteLine("");

    }

}