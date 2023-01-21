int number = InputInt("Введите число");
int maxNumber = Max(number);
Console.WriteLine($"Максимальная цифра в числе {number} - {maxNumber}");

int Max(int num)
{
    int max = 0;
    while (num > 0)
    {
        int temp = num % 10;
        if (temp > max)
        {
            max = temp;
        }
        num = num / 10;
    }
    return max;
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}