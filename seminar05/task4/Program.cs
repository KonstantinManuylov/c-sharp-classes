// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
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

int[] Multiplication(int[] array)
{
    int[] resultArray = new int[array.Length / 2 + array.Length % 2];
    resultArray[resultArray.Length - 1] = array[resultArray.Length - 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        resultArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return resultArray;
}

int[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив:");
int[] MultipliedArray = Multiplication(BaseArray);
PrintArray(MultipliedArray, "Массив с умножением значений:");