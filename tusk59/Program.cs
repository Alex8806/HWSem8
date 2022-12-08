// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен наименьший элемент массива.
Console.Clear();
Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш массив: ");
int[,] matrix = new int[m, n];
int min =0;
int Mini = 0;
int Minj = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 100);

        if( i==0 && j==0) min = matrix[0, 0];
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            Mini = i;
            Minj = j;
        }

        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine("min " +min +"i "+Mini + "j "+Minj);

Console.WriteLine("принт без строчки и столбца");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == Mini) continue;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == Minj) continue;

        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}



//
int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

Console.WriteLine("Новая матрица");
int ti = 0;
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    if (i == Mini)
    {
        ti++; 
    }
    int tj = 0;
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {

        if (j == Minj)
        {
            tj++; 
        }

        newMatrix[i, j] = matrix[ti, tj];
        Console.Write(newMatrix[i, j] + "\t");
        tj++;
    }
    Console.WriteLine();
    ti++;
}

