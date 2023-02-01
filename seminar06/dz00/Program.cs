// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string StringInput(string msg)
{
    Console.WriteLine(msg + " > ");
    string? result = Console.ReadLine();
    return result;
}

int[] SplitConvertNumbers(string line)
{
    string[] numbersText = line.Split(" ");
    int[] numbersInt = new int[numbersText.Length];
    for (int i = 0; i < numbersText.Length; i++)
    {
        numbersInt[i] = Convert.ToInt32(numbersText[i]);
    }
    return numbersInt;
}

int FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array, string msg)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string stringNumbers = StringInput("Введите числа через пробел");
int[] numbers = SplitConvertNumbers(stringNumbers);
PrintArray(numbers, "Базовый массив:");
Console.WriteLine($"Вы ввели {FindPositiveNumbers(numbers)} положительных чисел.");