// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
int[,,] Fill3DMatrix()
{
    int m = 100; int n = 1; int k = 1;
    while ((m * n * k) > 90)
    {
        Console.WriteLine("Введите размерность двумерного массива m x n x k");
        Console.Write("Введите  m: (в задании 2)");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите  n: (в задании 2)");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите  k: (в задании 2)");
        k = Convert.ToInt32(Console.ReadLine());

        if ((m * n * k) > 90) Console.WriteLine("Слишком большой массив ,нет столько неповторяющихся чисел!!!!!!");
    }
    int[,,] matrix = new int[m, n, k];
    int[] random = new int[90];
    for (int i = 0; i < random.Length; i++) random[i] = 10 + i;
    int difindexMax = 90;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int t = 0; t < k; t++)
            {
                int[] tempRandom = new int[random.Length - 1];
                int difindex = new Random().Next(0, difindexMax);
                matrix[i, j, t] = random[difindex];
                difindexMax--;
                for (int s = 0; s < tempRandom.Length; s++)
                {
                    tempRandom[s] = random[s];
                    if (s >= difindex) tempRandom[s] = random[s + 1];
                }
                random = tempRandom;
            }
        }
    }
    //   for (int s = 0; s < random.Length; s++) System.Console.Write(random[s]+" ");
    return matrix;

}

void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine("Ваша матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = 0; t < matrix.GetLength(2); t++)
            {
                Console.Write($"{matrix[i, j, t]} ({i},{j},{t})\t");
            }
            Console.WriteLine();
        }
        
    }

}

int[,,] OurMatrix = Fill3DMatrix();
PrintMatrix(OurMatrix);