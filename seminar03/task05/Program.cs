// Напишите программу, которая генерирует последовательность случайных 
// чисел из 10 элементов в диапазоне от 1 до 10, и подсчитывает, 
// сколько сгенерировалось чисел больше 5.

int[] numbersArray = new int [10];
FillArray(numbersArray);
PrintArray(numbersArray);
int result = FindMoreThanFive(numbersArray);
Console.WriteLine($"Количество чисел больше 5 = {result}");

int FindMoreThanFive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 5)
        {
            count ++;
        }
    }
    return count;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
}

void PrintArray(int[] array)
{
    Console.Write($"Числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
