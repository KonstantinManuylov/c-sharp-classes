// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = InputInt("Введите трехзначное число", "Вы ввели не трехзначное число");
int midNum = SearchMidNum(number);
Console.WriteLine($"Вторая цифра трехзначного числа {number} - {midNum}");

int SearchMidNum(int num)
{
    num = num % 100;
    num = num / 10;
    return num;
}

int InputInt(string message1, string message2)
{
    Console.WriteLine(message1 + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    if (result > 99 && result < 1000)
    {
        return result;
    }
    else
    {
        Console.WriteLine(message2);
        return InputInt(message1, message2);
    } 
}