﻿namespace DataStructures.Collections.Matrices;

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
}