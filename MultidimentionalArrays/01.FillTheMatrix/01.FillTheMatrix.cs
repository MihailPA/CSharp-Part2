//Problem 1. Fill The Matrix
//Write a program that fills and prints a matrix of size (n,n) as shown below:


using System;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {   
        static void Main(string[] args)
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

       

            // Variant A
            Console.WriteLine("Variant A");
            int number = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++, number++)
                {
                    matrix[row, col] = number;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] <= 9)
                    {
                        Console.Write("{0}   ", matrix[row, col]);
                    }
                    else if ((matrix[row, col] <= 99) && (matrix[row, col] >= 10))
                    {
                        Console.Write("{0}  ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Variant B
            number = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number++;
                    }
                }
                else
                {
                    for (int row = (matrix.GetLength(0) - 1); row >= 0; row--)
                    {
                        matrix[row, col] = number++;
                    }
                }
            }

            Console.WriteLine("Variant B");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] <= 9)
                    {
                        Console.Write("{0}   ", matrix[row, col]);
                    }
                    else if ((matrix[row, col] <= 99) && (matrix[row, col] >= 10))
                    {
                        Console.Write("{0}  ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Variant C
            number = 1;

            for (int row = (n - 1); row >= 0; row--)
            {
                int tempRow = row;

                for (int col = 0; col < (n - row); col++)
                {
                    matrix[tempRow, col] = number++;
                    tempRow++;
                }
            }

            number = n * n;

            for (int row = 0; row < (n - 1); row++)
            {
                int tempRow = row;

                for (int col = (n - 1); tempRow >= 0; col--)
                {
                    matrix[tempRow, col] = number--;
                    tempRow--;
                }
            }

            Console.WriteLine("Variant C");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] <= 9)
                    {
                        Console.Write("{0}   ", matrix[row, col]);
                    }
                    else if ((matrix[row, col] <= 99) && (matrix[row, col] >= 10))
                    {
                        Console.Write("{0}  ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Variant D
            int[,] newMatrix = new int[n, n];

            int newRow = 0;
            int newCol = 0;
            number = 1;

            do
            {
                while ((newRow < n) && (newMatrix[newRow, newCol] == 0))
                {
                    newMatrix[newRow++, newCol] = number++;
                }
                newRow--;
                newCol++;

                while ((newCol < n) && (newMatrix[newRow, newCol] == 0))
                {
                    newMatrix[newRow, newCol++] = number++;
                }
                newCol--;
                newRow--;

                while ((newRow > -1) && (newMatrix[newRow, newCol] == 0))
                {
                    newMatrix[newRow--, newCol] = number++;
                }
                newRow++;
                newCol--;

                while ((newCol >= 0) && (newMatrix[newRow, newCol] == 0))
                {
                    newMatrix[newRow, newCol--] = number++;
                }
                newCol++;
                newRow++;

            } while (number <= n * n);

            Console.WriteLine("Variant D");

            for (newRow = 0; newRow < newMatrix.GetLength(0); newRow++)
            {
                for (newCol = 0; newCol < newMatrix.GetLength(1); newCol++)
                {
                    if (newMatrix[newRow, newCol] <= 9)
                    {
                        Console.Write("{0}   ", newMatrix[newRow, newCol]);
                    }
                    else if ((newMatrix[newRow, newCol] <= 99) && (newMatrix[newRow, newCol] >= 10))
                    {
                        Console.Write("{0}  ", newMatrix[newRow, newCol]);
                    }
                    else
                    {
                        Console.Write("{0} ", newMatrix[newRow, newCol]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
        
  
