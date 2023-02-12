// Напишите программу, которая заполнит спирально квадратный массив.
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
// метод нагло спёр из сети. Не смог додумать сам. Не понял 41 строку.
int[,] CreateCatapillarsArray(int num = 5)
{
    int[,] array = new int[num, num];
    int i = 0;
    int j = 0;
    int value = 1;
    while (num != 0)
    {
        int k = 0;
        do {array[i, j++] = value++; } while (++k < num - 1);
        for (k = 0; k < num - 1; k++) array[i++, j] = value++;
        for (k = 0; k < num - 1; k++) array[i, j--] = value++;
        for (k = 0; k < num - 1; k++) array[i--, j] = value++;

        ++i; ++j; num = num < 2 ? 0 : num - 2;
    }
    return array;
}

int[,] newArray = CreateCatapillarsArray();
PrintArray(newArray);