using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 7
Реализуйте класс «Матрица». Реализуйте конструкторы и методы класса для ввода данных, вывода данных,
подсчёта максимума, подсчёта минимума. Используйте механизм перегрузки методов.*/

namespace Modul_3_task_7
{
    class Matrix
    {
        int rows;
        int columns;
        int[,] matrix = new int[,] { };
        public int MinValue { get; set; } = 1;
        public int MaxValue { get; set; } = 9;
        public Matrix()
        {
            rows = 3;
            columns = 3;
            matrix = new int[rows, columns];
        }
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }
        public void CreateMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(MinValue, MaxValue);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public int MinMatrix()
        {
            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        public int MaxMatrix()
        {
            int max = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(5, 5);
            matrix.MaxValue = 90;
            matrix.MinValue = 10;
            matrix.CreateMatrix();
            matrix.PrintMatrix();
            Console.WriteLine($"Min = {matrix.MinMatrix()}");
            Console.WriteLine($"Max = {matrix.MaxMatrix()}");
            Matrix matrix1 = new Matrix();
            matrix1.PrintMatrix();
        }
    }
}
