// Массив поменять местами первую и последнюю строку.

int[,] CreateArray(int x = 3, int y = 4)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +"\t");
        }
    }
    Console.WriteLine();
}

int[,] ReplaceLines(int[,] array)
{
    int lastString = array.GetLength(0) - 1;
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[lastString, j];
        array[lastString, j] = temp;
    }
    return array;
}

int[,] array = CreateArray();
PrintArray(array, "Базовый массив: ");
int[,] newArray = ReplaceLines(array);
PrintArray(newArray, "Измененный массив: ");