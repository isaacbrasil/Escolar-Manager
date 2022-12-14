class Professor : Pessoa
{
    public override string ToString()
    {

        return "Nome: " + Nome + " | Matéria: " + Materia;
    }
    public double TaxaAprovacao { get; set; }
    public string Materia { get; set; }

    public static double CalculaTaxaAprovacao(int numAlunos, int alunosAprovados)
    {
        return Math.Round(alunosAprovados / (double)numAlunos * 100, 2); //limita o resultado double para duas casas decimais e utiliza conversão explícita

    }

    public override void MostraDados(Pessoa professor)
    {

        Console.WriteLine("Nome: " + professor.Nome);
        Console.WriteLine("Sexo: " + professor.Sexo);
        Console.WriteLine("Id: " + professor.Id);
        Console.WriteLine("Matéria: " + ((Professor)professor).Materia);
    }
    public static void MostraEstatisticaTurma(List<Aluno> alunos)
    {
        var numAlunosSexoMasc = alunos.Where(al => al.Sexo == 'M').Count(); //LINQ QUERY + expressao lambda que conta número de alunos homens
        var numAlunosSexoFem = alunos.Where(al => al.Sexo == 'F').Count(); //LINQ QUERY + expressao lambda que conta número de alunos mulheres

        var alunosSexoMasc = alunos.Where(al => al.Sexo == 'M'); //LINQ QUERY + expressao lambda que retorna alunos homens
        var alunosSexoFem = alunos.Where(al => al.Sexo == 'F'); //LINQ QUERY + expressao lambda que retorna alunos mulheres

        int indexMedia = 1;
        int numAlunosAcimaMedia = 0;
        foreach (var aluno in alunos)
        {
            if ((aluno.CalculaMedia(alunos, indexMedia)) >= 6)
            {
                numAlunosAcimaMedia++;
            }
            indexMedia++;
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("===================================");
        Console.WriteLine("Nº Total de alunos: " + alunos.Count);
        Console.WriteLine("===================================");
        Console.WriteLine("Nº de alunos do sexo masculino: " + numAlunosSexoMasc);
        Console.WriteLine("===================================");
        Console.WriteLine("HOMENS: \r\n");
        foreach (var aluno in alunosSexoMasc)
        {
            Console.WriteLine(aluno.Nome);
        }
        Console.WriteLine("===================================");
        Console.WriteLine("");


        Console.WriteLine("Nº de alunos do sexo feminino: " + numAlunosSexoFem + "\r\n");
        Console.WriteLine("===================================");
        Console.WriteLine("MULHERES: \r\n");
        foreach (var aluno in alunosSexoFem)
        {
            Console.WriteLine(aluno.Nome);
        }
        Console.WriteLine("===================================");
        Console.WriteLine("");


        Console.WriteLine("Qtde de alunos acima da média: " + numAlunosAcimaMedia);
        Console.WriteLine("Qtde de alunos abaixo da média: " + (alunos.Count - numAlunosAcimaMedia));


    }

}