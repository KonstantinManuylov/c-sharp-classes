// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int number = InputData("Введите необходимое количество чисел");
int minValue = InputData("Введите минимальное значение числа");
int maxValue = InputData("Введите максимальное значение числа");

int[] newArray = CreateRandomNumbersArray(number, minValue, maxValue);
PrintArray(newArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CreateRandomNumbersArray(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int InputData(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}