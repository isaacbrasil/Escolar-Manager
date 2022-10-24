﻿using System.Linq;
using System.IO;
using System.Text;
class Administrador : Pessoa
{

    Sistema sistema = new Sistema();
    public List<Aluno> CadastraAluno(List<Aluno> alunos)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Dados serão gravados em:\n\r" + AppDomain.CurrentDomain.BaseDirectory + "alunos.txt\r\n");
        Console.ResetColor();

        Console.WriteLine("Digite a quantidade de alunos que quer cadastrar:");
        int numAlunos = Convert.ToInt32(Console.ReadLine());
        int numNotas = 5;
        if (numAlunos == 0)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\nInsira um índice maior que zero.\r\n");
            Console.ResetColor();
        }
        else
        {
            Console.Clear();

            TextWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "alunos.txt");

            for (int i = 0; i < numAlunos; i++) //cadastra mais alunos na lista alunos
            {
                Aluno newAluno = new Aluno();
                Pessoa p = newAluno; //UTILIZANDO UPCASTING de classe filha Aluno para Pessoa

                Console.WriteLine("Insira o nome do aluno: " + (i + 1));
                p.Nome = Console.ReadLine().ToUpper();// UPCASTING lê o nome do aluno que é pessoa

                if (ChecaExistenciaAluno(alunos, p.Nome.GetHashCode()))
                {
                    break;
                }

                Console.WriteLine("Insira o sexo do aluno (F/M): ");
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

            foreach (Aluno aluno in alunos)
            {

                double media = aluno.CalculaMedia(alunos, (indexMedia + 1)); //para calcular a média é necessário passar a lista e o índice do aluno
                escritor.WriteLine(aluno.ToString() + media); //escreve as informações do aluno no file.txt sobrescrevendo o método toString()
                indexMedia++;

            }
            Console.WriteLine("");

            escritor.Close();
        }

        return alunos;
    }
    public List<Professor> CadastraProfessor(List<Professor> professores)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Dados serão gravados em:\n\r" + AppDomain.CurrentDomain.BaseDirectory +"professores.txt\r\n");
        Console.ResetColor();
        Console.WriteLine("Digite a quantidade de professores que quer cadastrar:");
        int numProfs = Convert.ToInt32(Console.ReadLine());
        if (numProfs == 0)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\nInsira um índice maior que zero.\r\n");
            Console.ResetColor();
        }
        else
        {
            Console.Clear();

            TextWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "professores.txt");


            for (int i = 0; i < numProfs; i++) //cadastra mais professores na lista professores
            {
                Professor newProf = new Professor();
                Console.WriteLine("Insira o nome do professor: " + (i + 1));
                newProf.Nome = Console.ReadLine().ToUpper();
                if (ChecaExistenciaProf(professores, newProf.Nome.GetHashCode()))
                {
                    break;
                }
                Console.WriteLine("Insira a matéria do professor " + newProf.Nome + ": ");
                newProf.Materia = Console.ReadLine().ToUpper();
                Console.WriteLine("Insira o sexo do professor (F/M): ");
                newProf.Sexo = Convert.ToChar(Console.ReadLine().ToUpper());
                professores.Add(newProf); //adiciona o novo professor na lista professores
            }

            foreach (Professor professor in professores)
            {

                escritor.WriteLine(professor.ToString()); //escreve as informações do professor no file.txt sobrescrevendo o método toString()

            }

            Console.WriteLine("");

            escritor.Close();
        }
        return professores;

    }
      
    public bool ChecaExistenciaAluno(List<Aluno> alunos, int hashNome) // checa se já existe um hashcode na lista alunos
    {
        foreach (Aluno aluno in alunos)
        {
            int hash = aluno.Nome.GetHashCode();
            if (hash.Equals(hashNome))
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Esse aluno já existe no registro.");
                Console.ResetColor();
                return true;
            }
        }

        return false;
    }
    public bool ChecaExistenciaProf(List<Professor> professores, int hashNome) // checa se já existe um hashcode na lista professores
    {
        foreach (Professor prof in professores)
        {
            int hash = prof.Nome.GetHashCode();
            if (hash.Equals(hashNome))
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Esse professor já existe no registro.");
                Console.ResetColor();
                return true;
            }
        }

        return false;
    }
    public void DeletaRegistroArquivoProf(List<Professor> professores, int index)
    {
        string filePath = AppDomain.CurrentDomain.BaseDirectory + "professores.txt";

        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0 && (index - 1) <= professores.Count && index > 0)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(filePath));
            file.RemoveAt(index - 1);
            File.WriteAllLines(filePath, file.ToArray());
        }


    }
    public void DeletaRegistroArquivoAluno(List<Aluno>alunos, int index)
    {
        string filePath = AppDomain.CurrentDomain.BaseDirectory + "alunos.txt";


        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0 && (index-1) <= alunos.Count && index > 0)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(filePath));
            file.RemoveAt(index - 1);
            File.WriteAllLines(filePath, file.ToArray());
        }


    }



}