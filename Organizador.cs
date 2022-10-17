public class OrganizadorGenerico<T>
{
    // define um Array do tipo Generic com tamanho 5
    T[] obj = new T[5];
    int contador = 0;
    //indexador para a iteração da instrução foreach
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }

    public List<T> Ordena(List<T> lista)
    {
        foreach (var n in lista)
        {
            Console.WriteLine(lista.OrderBy(n => n));
        }
        return lista.OrderBy(n => n).ToList();
    }


}



