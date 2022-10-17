﻿using System.Linq;
class Administrador : Pessoa
{


    Sistema sistema = new Sistema();
    public List<Aluno> CadastraAluno(List<Aluno> alunos)
    {
        Console.WriteLine("Digite a quantidade de alunos que quer cadastrar:");
        int numAlunos = Convert.ToInt32(Console.ReadLine());
        int numNotas = 5;
        Console.Clear();

        TextWriter escritor = new StreamWriter("C:/Users/Escolar Manager/source/repos/isaacEstudos/GerenciamentoEscolar/alunos.txt");

        for (int i = 0; i < numAlunos; i++) //cadastra mais alunos na lista alunos
        {
            Aluno newAluno = new Aluno();
            Pessoa p = newAluno; //UTILIZANDO UPCASTING de classe filha Aluno para Pessoa

            Console.WriteLine("Insira o nome do aluno: " + (i + 1));
            p.Nome = Console.ReadLine().ToUpper();// UPCASTING lê o nome do aluno que é pessoa

            Console.WriteLine("Insira o sexo do aluno(F/M): ");
            newAluno.Sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            for (int j = 0; j < numNotas; j++) // atribuo notas nulas para o novo aluno pois quem lançará as notas é o professor
            {
                newAluno.Notas[j] = 0;
            }

            Console.WriteLine("Insira a Turma do aluno: ");
            newAluno.Turma = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Insira a Escola do aluno: ");
            newAluno.EscolaNome = Console.ReadLine().ToUpper();

            alunos.Add(newAluno); //adiciona o novo aluno na lista alunos

        }

        int indexMedia = 0;

        var alunosOrdenados = alunos.OrderBy(n => n.Nome); //LINQ QUERY + expressao lambda que ordena alfabeticamente a lista de alunos


        foreach (Aluno aluno in alunosOrdenados)
        {

            double media = aluno.CalculaMedia(alunos, (indexMedia + 1)); //para calcular a média é necessário passar a lista e o índice do aluno
            escritor.WriteLine(aluno.ToString() + media); //escreve as informações do aluno no file.txt sobrescrevendo o método toString()
            indexMedia++;

        }

        //sistema.MensagemSucesso();
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
            newProf.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Insira a matéria do professor " + newProf.Nome + ": ");
            newProf.Materia = Console.ReadLine().ToUpper();

            professores.Add(newProf); //adiciona o novo professor na lista professores
        }
        var professoresOrdenados = professores.OrderBy(n => n.Nome); //LINQ QUERY + expressao lambda que ordena alfabeticamente a lista de alunos

        foreach (Professor professor in professoresOrdenados)
        {

            escritor.WriteLine(professor.ToString()); //escreve as informações do professor no file.txt sobrescrevendo o método toString()

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

                Console.WriteLine((i + 1) + "-" + aluno.Nome.ToUpper() + " | HASH: " + aluno.GetHashCode()); // APAGAR HASH
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
                Console.WriteLine((i + 1) + "-" + professor.Nome.ToUpper());
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