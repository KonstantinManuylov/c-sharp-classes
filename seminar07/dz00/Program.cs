// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/* m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] NumbersArray(int x = 3, int y = 4)
{
    Random rnd = new Random();
    double[,] array = new double[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 20 - 10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F1}\t");
        }
        Console.WriteLine();
    }
}

double[,] resultArray = NumbersArray();
PrintArray(resultArray);