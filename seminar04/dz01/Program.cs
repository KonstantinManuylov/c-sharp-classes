// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = InputData("Введите число");
int result = FindSum(number);
Console.WriteLine(result);

int FindSum(int num)
{
    int left;
    int sum = 0;
    while (num != 0)
    {
        left = num % 10;
        num /= 10;
        sum += left;
    }
    return sum;
}

int InputData(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}