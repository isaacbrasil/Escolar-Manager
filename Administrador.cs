using System.Linq;
class Administrador : Pessoa
{
    Sistema sistema = new Sistema();
    public List<Aluno> CadastraAluno(List<Aluno> alunos)
    {
        Console.WriteLine("Digite a quantidade de alunos que quer cadastrar:");
        int numAlunos = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt");

        for (int i = 0; i < numAlunos; i++) //cadastra mais alunos na lista alunos
        {
            Aluno newAluno = new Aluno();
            Pessoa p = newAluno; //UTILIZANDO UPCAST de classe filha Aluno para Pessoa

            Console.WriteLine("Insira o nome do aluno: " + (i + 1));
            p.Nome = Console.ReadLine();// lê o nome do aluno que é pessoa
            
            for (int j = 0; j < 5; j++) // atribuo notas nulas para o novo aluno pois quem lançará as notas é o professor
            {
                newAluno.Notas[j] = 0;
            }

            Console.WriteLine("Insira a Turma do aluno: ");
            newAluno.Turma = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira a Escola do aluno: ");
            newAluno.EscolaNome = Console.ReadLine();

            alunos.Add(newAluno); //adiciona o novo aluno na lista alunos
        }

        int indexMedia = 0;

        foreach (Aluno aluno in alunos) 
        {

            double media = aluno.CalculaMedia(alunos, (indexMedia+1)); //para calcular a média é necessário passar a lista e o índice do aluno
            escritor.WriteLine(aluno.ToString() + media); //escreve as informações do aluno no file.txt sobrescrevendo o método toString()
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

        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/professores.txt");

        for (int i = 0; i < numProfs; i++) //cadastra mais professores na lista professores
        {
            Professor newProf = new Professor();
            Console.WriteLine("Insira o nome do professor: " + (i + 1));
            newProf.Nome = Console.ReadLine();

            Console.WriteLine("Insira a matéria do professor " + newProf.Nome + ": ");
            newProf.Materia = Console.ReadLine();

            professores.Add(newProf); //adiciona o novo professor na lista professores
        }

        foreach (Professor professor in professores)
        {

            escritor.WriteLine(professor.ToString() ); //escreve as informações do professor no file.txt sobrescrevendo o método toString()

        }

        Console.WriteLine("");

        sistema.MensagemSucesso();
        escritor.Close();

        return professores;

    }

    public void DeletaProfessores(List<Professor> professores, int indexProf)
    {

        if (professores.Count > 0 && indexProf <= professores.Count) // se a lista não for vazia, limpa ela no indice indexProf
        {
            Console.WriteLine("Insira qual índice do professor a ser deletado: ");
            professores.RemoveAt((indexProf - 1));
        }
        else if (indexProf > professores.Count)
        {

            Console.WriteLine("Insira um índice válido");
        }
        else
        {
            Console.WriteLine("Nenhum professor cadastrado");

        }


    }
    public void DeletaAlunos(List<Aluno> alunos, int indexAluno)
    {

        if (alunos.Count > 0 && indexAluno <= alunos.Count) // se a lista não for vazia, limpa ela no indice indexAluno
        {
            Console.WriteLine("Insira qual índice do aluno a ser deletado: ");
            alunos.RemoveAt((indexAluno - 1));

        }
        else if (indexAluno > alunos.Count)
        {

            Console.WriteLine("Insira um índice válido");
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