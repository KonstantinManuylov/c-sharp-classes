// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] BaseArray()
{
    Random rnd = new Random();
    int[] array = new int[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumOddNumbers(int[] array)
{
    int sumOdds = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdds += array[i];
    }
    return sumOdds;
}

int[] baseArray = BaseArray();
PrintArray(baseArray, "Base array:");
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {FindSumOddNumbers(baseArray)}");