// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] DoubleNumbersArray()
{
    Random rnd = new Random();
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Базовый массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F3} ");
    }
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindDifference(double min, double max)
{
    return max - min;
}

double[] doubleNumbers = DoubleNumbersArray();
PrintArray(doubleNumbers);
double min = FindMin(doubleNumbers);
double max = FindMax(doubleNumbers);
Console.WriteLine($"Разница минимального {min:F3} и максимального {max:F3} " +
                    $"значений в массиве = {FindDifference(min, max):F3}");