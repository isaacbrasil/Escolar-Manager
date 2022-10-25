public abstract class Pessoa
{
    private string nome;
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
   
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Pessoa(string nome, int id)
    {
        this.nome = nome;
        this.id = id;
    }

    public Pessoa()
    {
        this.nome = "";
        Pessoa.numero++; // cria um id unico para cada construtor novo criado
        this.id = Pessoa.numero;
    }

    public virtual void MostraDados(Pessoa pessoa)
    {
        System.Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Nome: " + pessoa.Nome);
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
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Essa pessoa já existe no registro.");
                Console.ResetColor();
                Console.WriteLine("");
                return true;
            }
        }

        return false;
    }

}