using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Matrix
    {
        int[,] array;
        int rows, cols;

        #region Properties
        public int[,] Array
        {
            get { return array; }
            set { array = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }
        #endregion

        public Matrix() { }

        public void CreatRandomMatrix(int min, int max)
        {
            do
            {
                Console.Write("Number of rows: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Number of cols: ");
                cols = int.Parse(Console.ReadLine());
            } while (rows < 0 || cols < 0);

            array = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(min, max);
                }
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\t" + array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void AddTwoMatrix(Matrix mt1, Matrix mt2)
        {
            int[,] tmp1 = mt1.Array;
            int[,] tmp2 = mt2.Array;

            if (mt1.rows == mt2.rows && mt1.cols == mt2.cols)
            {
                int[,] tmp = new int[mt1.rows, mt1.cols];
                for (int i = 0; i < mt1.rows; i++)
                {
                    for (int j = 0; j < mt1.cols; j++)
                    {
                        tmp[i, j] = tmp1[i, j] + tmp2[i, j];
                    }
                }

                Console.WriteLine("=====  Addition of mt1 && mt2  =====\n");

                for (int i = 0; i < tmp.GetLength(0); i++)
                {
                    for (int j = 0; j < tmp.GetLength(1); j++)
                    {
                        Console.Write("\t" + tmp[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error: Two matrix must have the same dimensions!");
            }
        }
    }
}
