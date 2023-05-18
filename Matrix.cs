namespace DataStructures.Collections.Matrices;

public class Matrix<T>
{
    private T[,] _data;
    private int _rows;
    private int _columns;

    public T[,] Data
    {
        get { return this._data; }
        set { this._data = value; }
    }

    public int Rows
    {
        get { return this._rows; }
    }

    public int Columns
    {
        get { return this._columns; }
    }

    public Matrix(int rows, int columns)
    {
        this._data = new T[rows, columns];
        this._rows = rows;
        this._columns = columns;
    }

    public T this[int row, int column]
    {
        get { return this._data[row, column]; }
        set { this._data[row, column] = value; }
    }

    public void Fill(T value)
    {

    }
}