// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение 
// по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumLines(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (max < array[i, j])
            {
                max = array[i, j];
            }
        }
        sum += max;
    }
    return sum;
}

int SumColumns(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int min = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
            }
        }
        sum += min;
    }
    return sum;
}

int[,] NumbersArray = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };
PrintArray(NumbersArray);
int sumMax = SumLines(NumbersArray);
int sumMin = SumColumns(NumbersArray);
Console.Write($"{sumMax} - {sumMin} = {sumMax - sumMin}");
Console.WriteLine();