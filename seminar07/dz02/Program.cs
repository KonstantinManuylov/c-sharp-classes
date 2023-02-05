// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateNumbersArray(int x = 3, int y = 4)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}

double[] FindAverage(int[,] array)
{
    double amount = array.GetLength(0);
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average[j] = sum / amount;
    }
    return average;
}

void PrintResult(double[] array, string msg)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(msg + ": ");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F1}" + "\t");
    }
    Console.WriteLine();
}

int[,] resultArray = CreateNumbersArray();
PrintArray(resultArray, "Массив: ");
double[] resultAvarage = FindAverage(resultArray);
PrintResult(resultAvarage, $"Среднее арифметическое столбцов");