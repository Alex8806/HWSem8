// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix()
{
    Console.WriteLine("Введите размерность двумерного массива m x n");
    Console.Write("Введите  m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите  n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[m, n];
    int t = 1;//начало счета
    int k = 0;//строки
    int j = 0;//столбцы
    int stop =m*n;

    for (int i = 0; i <= (matrix.GetLength(0) + matrix.GetLength(1)) / 4; i++)
    {
        for (; j < n&t<=stop; j++)
        {
            matrix[k, j] = t;
            t++;
            //Console.Write($" 1 k={k} j={j} t ={t} ");
        }
        j--;
        k++;
        for (; k < m&t<=stop; k++)
        {
            matrix[k, j] = t;
            t++;
            //Console.Write($"  2 k={k} j={j} t ={t} ");
        }
        k--;
        j--;
        for (; j > (matrix.GetLength(1) - n-1)&t<=stop; j--)
        {
            matrix[k, j] = t;
            t++;
            //Console.Write($" 3 k={k} j={j} t ={t} ");
        }
        j++;
        m--;
        k--;
        for (; k > (matrix.GetLength(0) - m-1)&t<=stop; k--)
        {
            matrix[k, j] = t;
            t++;
            //Console.Write($" 4 k={k} j={j} t ={t} ");
        }
        k++;
        j++;
        n--;
        //Console.WriteLine("n=" + n);
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
int[,] OurMatrix = FillMatrix();
Console.WriteLine(" Ваш массив");
PrintMatrix(OurMatrix);