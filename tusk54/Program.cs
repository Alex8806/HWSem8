// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix()
{
    Console.Clear();
    Console.WriteLine("Введите размерность двумерного массива m x n");
    Console.Write("Введите  m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите  n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ваш массив: ");
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, 0];
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
                else temp = matrix[i, k + 1];

            }
        }

    }
    return matrix;
}

int[,] OurMatrix = FillMatrix();
Console.WriteLine(" Исходная матрица");
PrintMatrix(OurMatrix);
Console.WriteLine(" Упорядоченная матрица");
OurMatrix = ArrangeMatrix(OurMatrix);
PrintMatrix(OurMatrix);