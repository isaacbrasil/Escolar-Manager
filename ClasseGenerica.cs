public class ClasseGenerica<T>
{
    // define um Array do tipo Generic com tamanho 5
    T[] obj = new T[4];
    int contador = 0;
    // adiciona itens ao tipo genérico
    public void Adicionar(T item)
    {
        //verifica o tamanho
        if (contador + 1 < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }
    //indexador para a iteração da instrução foreach
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}

