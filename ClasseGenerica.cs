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
}


