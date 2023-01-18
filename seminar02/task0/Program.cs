// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int number = InputInt("Введите число");
if (ValidateNumberRank3(number))
{
    int lastRank = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} - {lastRank}");
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    Console.WriteLine("Число не трехзначное.");
    return false;
}