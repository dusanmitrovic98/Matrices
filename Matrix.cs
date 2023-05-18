namespace DataStructures.Collections.Matrices;

public class Matrix<T>
{
    private T[,] _data;
    private int _rows;
    private int _columns;

    public T[,] Data
    {
        get { return this._data; }
    }
}