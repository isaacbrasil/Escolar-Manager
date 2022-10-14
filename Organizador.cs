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

    public IOrderedEnumerable<T> Ordena(List<T> lista)
    {
        //var listaOrdenada = lista.OrderBy(n => n); //LINQ QUERY + expressao lambda que ordena alfabeticamente a lista de alunos
        return lista.OrderBy(n => n);
    }


}



