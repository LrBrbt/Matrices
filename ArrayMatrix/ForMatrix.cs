using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrix
{
    public class ForMatrix
    {
        static public double[,] Create(int rowCount, int columnCount)
        {
            return new double[rowCount, columnCount];
        }
        static public void Fill(double[,] matrix, int minValue, int maxValue)
        {
            Random random = new();
            Random random1 = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(random.NextDouble() * random1.Next(minValue, maxValue), 2);

                }
            }
        }
        static public string SizeOfMatrix(double[,] matrix)
        {
            return $"Размер матрицы: {matrix.GetLength(0)}x{matrix.GetLength(1)}";
        }
        static public bool IsRectangularOrSquare(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        static public bool IsMatrixRow(double[,] matrix)
        {
            if (matrix.GetLength(0) == 1 && matrix.GetLength(1) > 1)
            {
                return true;
            }
            return false;
        }
        static public bool IsMatrixColumn(double[,] matrix)
        {
            if (matrix.GetLength(1) == 1 && matrix.GetLength(0) > 1)
            {
                return true;
            }
            return false;
        }

        static public bool IsNullMatrix(double[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            if (count == matrix.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool IsDiagonalMatrix(double[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0 && i == j)
                    {
                        count++;
                    }
                }
            }
            if (count == matrix.GetLength(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool IsUnitMatrix(double[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1 && i == j)
                    {
                        count++;
                    }
                }
            }
            if (count == matrix.GetLength(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool IsTriangularMatrix(double[,] matrix)
        {
            int[] mas = new int[matrix.GetLength(0)];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
                mas[i] = count;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                int zeroCount = 0;
                if (mas[i] == i)
                {
                    zeroCount++;
                }
                if (zeroCount == mas.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public DataTable ToDataTable(double[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }
            return res;
        }
    }
}
