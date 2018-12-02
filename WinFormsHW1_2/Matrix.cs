using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHW1_2
{
    class Matrix
    {
        int[,] matrix;
        public int Col { get; }
        public int Row { get; }
        public Matrix(int col, int row)
        {
            matrix = new int[col, row];
            Col = col;
            Row = row;
        }
        public int this[int col, int row]
        {
            get
            {
                if (col >= 0 && col < Col &&
                    row >= 0 && row < Row)
                {
                    return matrix[col, row];
                }
                else
                    throw new Exception("Обращение к элементу класса Matrix за пределами массива");
            }
            set
            {
                if (col >= 0 && col < Col &&
                    row >= 0 && row < Row)
                {
                    matrix[col, row] = value;
                }
                else
                    throw new Exception("Установка значения элемента класса Matrix за пределами массива");
            }
        }
        public (int value, int col, int row) Max()
        {
            // list и linq не модно)))
            (int value, int col, int row) max = (matrix[0,0],0,0);
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    if (matrix[i, j] > max.value)
                    {
                        max.value = matrix[i, j];
                        max.col = i;
                        max.row = j;
                    }
                }
            }
            return max;
        }
        public (int value, int col, int row) Min()
        {
            (int value, int col, int row) min = (matrix[0, 0], 0, 0);
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    if (matrix[i, j] < min.value)
                    {
                        min.value = matrix[i, j];
                        min.col = i;
                        min.row = j;
                    }
                }
            }
            return min;
        }
        public static List<int> Find(ref Matrix matrix, Predicate<int> criterion)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < matrix.Col; i++)
            {
                for (int j = 0; j < matrix.Row; j++)
                {
                    list.Add(matrix[i, j]);
                }
            }
            return (list.FindAll(criterion));
        }
    }
}
