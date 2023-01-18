// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = InputInt("Введите число");
if (number < 100)
{
    Console.WriteLine($"Третьей цифры в числе {number} нет.");
}
else
{
    int newNum = ThirdNumber(number);
    Console.WriteLine($"Третья цифра в числе {number} - {newNum}");
}


int ThirdNumber(int num)
{
    while (num > 1000)
    {
            num /= 10;
    }
    return num %= 10;
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}