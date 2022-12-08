// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//  наименьшей суммой элементов: 1 строка
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


void StrokaSNaimenshei(int[,] matrix)
{
    int[] sumarr = new int[matrix.GetLength(0)];
    int tempsum = 0;
    int sum;
    int sumi = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0) { tempsum = sum; }
        if (sum < tempsum)
        {
            tempsum = sum;
            sumi = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой {sumi + 1} c суммой {tempsum}");


}

void StrokaSNaimenshei2(int[,] matrix)
{
    int[] sumarr = new int[matrix.GetLength(0)];
    int tempsum = 0;
    int sum;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)  tempsum = sum; 
        if (sum < tempsum)     tempsum = sum;
        
        sumarr[i] = sum;
    }



    Console.Write("Строка(и) с наименьшей суммой "+ tempsum + " - ");
for (int i = 0; i < sumarr.Length; i++)
{if(tempsum==sumarr[i]) Console.Write($" {i+1},");
    
}

}

int[,] OurMatrix = FillMatrix();
Console.WriteLine(" Наша матрица");
PrintMatrix(OurMatrix);
StrokaSNaimenshei(OurMatrix);
StrokaSNaimenshei2(OurMatrix);
