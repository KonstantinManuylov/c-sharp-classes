// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Знаю, что функция PrintResult и ее вывод получились путанными, но очень хотелось ответ
// сделать через функцию.
Console.WriteLine("Введите число >");
string? numberInput = Console.ReadLine();
Console.WriteLine(PrintResult(IsPalindrome(numberInput), numberInput));

string PrintResult(bool function, string number)
{
    if (function)
    {
        return $"Число {number} является палиндромом.";
    }
    else
    {
        return $"Число {number} не является палиндром.";
    }
}

bool IsPalindrome(string num)
{
    for (int i = 0; i < num.Length / 2; i++)
    {
        if (num[i] != num[num.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}