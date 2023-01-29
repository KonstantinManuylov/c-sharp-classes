// нахождение второго максимального числа

int[] FillNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Base array");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int FindSecondMax(int[] array, int max)
{
    int secondMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > secondMax && array[i] < max)
        {
            secondMax = array[i];
        }
    }
    return secondMax;
}

int[] numbersArray = FillNumbersArray();
PrintArray(numbersArray);
int max = FindMax(numbersArray);
int secondMax = FindSecondMax(numbersArray, max);
Console.WriteLine($"Второе максимальное число в массиве {secondMax}");