// Напишите программу замены элементов массива: положительные элементы
//  замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateNumbersArray()
{
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 11);
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

int[] Inverter(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] numsArray = CreateNumbersArray();
PrintArray(numsArray, "Базовый массив: ");
int[] invertedArray = Inverter(numsArray);
PrintArray(invertedArray, "Инвертированный массив: ");
