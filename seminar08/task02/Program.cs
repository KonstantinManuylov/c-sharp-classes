// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

int[,] CreateBaseArray(int x = 3, int y = 4)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 9);
        }
    }
    return array;
}

void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
}

int[] SearchResult(int[,] array, int amount = 10)
{
    int[] frequency = new int[amount];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            frequency[array[i, j]]++;
        }
    }
    return frequency;
}

void PrintSingleArray(int[] array, string msg)
{
    Console.WriteLine();
    Console.WriteLine(msg);
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} встречается {array[i]} раз");
    }
}

int[,] baseArray = CreateBaseArray();
PrintArray(baseArray, "Базовый массив: ");
int[] resultArray = SearchResult(baseArray);
PrintSingleArray(resultArray, "Частотный словарь: ");