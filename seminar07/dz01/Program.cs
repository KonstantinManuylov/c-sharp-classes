// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateArray(int x = 3, int y = 4)
{
    Random rnd = new Random();
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
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

int InputData(string msg)
{
    Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int FindNumberInArray(int x, int y, int[,] array)
{
    return array[x, y];
}

bool Validate(int x, int y, int[,] array)
{
    if (x <= array.GetLength(0) && y <= array.GetLength(1))
    {
        return true;
    }
    return false;
}

int lines = InputData("Введите номер строки");
int columns = InputData("Введите номер стобца");
int[,] resultArray = CreateArray();
int resultNumber = FindNumberInArray(lines, columns, resultArray);
PrintArray(resultArray);

if (Validate(lines, columns, resultArray))
{
    Console.WriteLine($"Число в массиве, в позиции [{lines}, {columns}] = {resultNumber}.");
}
else
{
    Console.WriteLine($"Такого элемента нет.");
}