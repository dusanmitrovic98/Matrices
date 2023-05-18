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
        private set { this._rows = value; }
    }

    public int Columns
    {
        get { return this._columns; }
        private set { this._columns = value; }
    }

    public Matrix(int rows, int columns)
    {
        this.Data = new T[rows, columns];
        this.Rows = rows;
        this.Columns = columns;
    }

    public T this[int row, int column]
    {
        get { return this.Data[row, column]; }
        set { this.Data[row, column] = value; }
    }

    public void Fill(T value)
    {
        for (int i = 0; i < this.Rows; i++)
        {

        }
    }
}