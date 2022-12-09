// Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Введите количество строк треуголника Паскаля");
int n = Convert.ToInt32(Console.ReadLine());
int[,] paskal = new int[n, ((n-1) * 2 + 1)];
for (int i = 0; i < paskal.GetLength(0); i++)
{

    if (i == 0)
    {
        paskal[i, paskal.GetLength(1) / 2] = 1;
        continue;
    }
    if (i % 2 != 0)
    {
        for (int k = 0; k < i + 1; k ++)
        {
            if (k == 0) paskal[i, paskal.GetLength(1)/2-i] = 1;
            else if (k == i) paskal[i, paskal.GetLength(1)/2+i] = 1;
            else { paskal[i, (paskal.GetLength(1)/2)-i+(2*k)] = paskal[i - 1, (paskal.GetLength(1)/2)-i+(2*k) - 1] + paskal[i - 1, (paskal.GetLength(1)/2)-i+(2*k)+1];}

        }
    }
    if (i % 2 == 0)
    {
        for (int k = 0; k < i + 1; k ++)
        {
            if (k == 0) paskal[i, paskal.GetLength(1)/2-i] = 1;
            else if (k == i) paskal[i, paskal.GetLength(1)/2+i] = 1;
            else { paskal[i, paskal.GetLength(1)/2-i+2*k] = paskal[i - 1, paskal.GetLength(1)/2-i+2*k - 1] + paskal[i - 1, paskal.GetLength(1)/2-i+2*k+1];}

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]!=0)Console.Write(matrix[i, j] + "\t");
            else Console.Write("\t");
        }
        Console.WriteLine();
    }
}
PrintMatrix(paskal);
