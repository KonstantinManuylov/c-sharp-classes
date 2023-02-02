// Пользователь вводит число N, например 12 -> 
// вывод, последоватльность чисел: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5. 
// 12 цифр, количество повторов равно значению числа.

int InputData(string msg)
{
    Console.WriteLine(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int amount)
{
    int[] array = new int[amount];
    int count = 1;
    int temp = 1;
    for (int i = 0; i < amount; i++)
    {
        if (temp < count)
        {
            array[i] = count;
            temp++;
        }
        else
        {
            array[i] = count;
            count++;
            temp = 1;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int amountNumber = InputData($"Введите число");
int[] array = CreateArray(amountNumber);
PrintArray(array);