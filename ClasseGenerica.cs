using System;

public class ClasseGenerica<T>
{
    // private data members
    private T data;

    // using properties
    public T value
    {
        // using accessors
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }

    public string MostraLista(List<T> pessoas)
    {
        if (pessoas.Count > 0)
        {
            int i = 0;
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine((i + 1) + "-" + pessoa);
                i++;
            }
            Console.WriteLine("");

            return pessoas.ToString();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma pessoa cadastrada");
            Console.ResetColor();
            return "";
        }
        Console.WriteLine("");

    }
}


