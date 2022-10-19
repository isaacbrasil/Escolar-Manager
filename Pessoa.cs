public abstract class Pessoa
{
    private string nome;
    private int idade;
    private char sexo;
    private int id;
    private static int numero = 202201500;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public char Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }
    public override int GetHashCode()
    {
        return this.Nome.GetHashCode() * 17; //multiplica o hashcode por um número primo para diminuir colisões
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Pessoa(string nome, int idade, int id)
    {
        this.nome = nome;
        this.idade = idade;
        this.id = id;
    }

    public Pessoa()
    {
        this.nome = "";
        this.idade = 0;
        Pessoa.numero++; // cria um id unico para cada construtor novo criado
        this.id = Pessoa.numero;
    }

    public virtual void MostraDados(Pessoa pessoa)
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Nome: " + pessoa.Nome);
        Console.WriteLine("Idade: " + pessoa.Idade) ;
        Console.WriteLine("Id: " + pessoa.Id);
        System.Console.WriteLine("------------------------------------------------------------");

    }

    public virtual void MenuOperação()
    {
        Console.WriteLine("Qual operação você deseja realizar ?");

    }
    public virtual void DeletaRegistro(string filePath, int index)
    {
        if (File.Exists(filePath))
        {
            var file = new List<string>(System.IO.File.ReadAllLines(filePath));
            file.RemoveAt(index - 1);
            File.WriteAllLines(filePath, file.ToArray());
        }


    }

    public virtual bool ChecaExistencia(List<Pessoa> pessoas, int hashNome) // checa se já existe um hashcode na lista professores
    {
        foreach (Pessoa pessoa in pessoas)
        {
            int hash = pessoa.Nome.GetHashCode();
            if (hash.Equals(hashNome))
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Essa pessoa já existe no registro.");
                Console.ResetColor();
                Console.WriteLine("");
                return true;
            }
        }

        return false;
    }

    public virtual void MostraLista(List<Pessoa> pessoas)
    {
        Console.WriteLine("");
        if (pessoas.Count > 0)
        {
            Console.WriteLine("Alunos: \r\n");
            int i = 0;
            foreach (Aluno pessoa in pessoas)
            {

                Console.WriteLine((i + 1) + "-" + pessoa.Nome.ToUpper());
                i++;
            }


        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma pessoa cadastrada");
            Console.ResetColor();

        }
        Console.WriteLine("");

    }


}