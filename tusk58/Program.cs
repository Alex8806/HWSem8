// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] FillMatrix(int m,int n)
{
    
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

// int[,] FillMatrix(int m, int n)// для ручного ввода
// {

//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {Console.WriteLine($"Введите число строка {i+1} столбец {j+1} ");
//             matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return matrix;
// }
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
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += (matrix1[i, k] * matrix2[k, j]);
            }
            resultMatrix[i, j] = sum;

        }

    }
    return resultMatrix;
}
Console.Clear();
Console.WriteLine("Задайте первую матрицу\nВведите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix1 = FillMatrix(m, n);
Console.WriteLine("Первая матрица");
System.Threading.Thread.Sleep(1200);
PrintMatrix(OurMatrix1);
System.Threading.Thread.Sleep(1200);
Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй!");
System.Threading.Thread.Sleep(1200);
Console.Write("Введите число столбцов второй матрицы \t");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая матрица");
int[,] OurMatrix2 = FillMatrix(n, m1);
PrintMatrix(OurMatrix2);
System.Threading.Thread.Sleep(1200);
Console.WriteLine("Результат умножения матриц:");
System.Threading.Thread.Sleep(1200);
int[,] resultMatrix = MultiplicationMatrix(OurMatrix1, OurMatrix2);
PrintMatrix(resultMatrix);
