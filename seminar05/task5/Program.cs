// реверс массива

int[] CreateNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 51);
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

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap2(array, i, array.Length - 1 - i);
    }
    return array;
}

void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void Swap2(int[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}

(int, int) MinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (min, max);
}

int[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив:");
int[] reversedArray = Reverse(BaseArray);
PrintArray(reversedArray, "Перевернутый массив:");
(int min, int max) = MinMax(BaseArray);
PrintArray(BaseArray, $"Минимальное = {min}, максимальное = {max}:");
