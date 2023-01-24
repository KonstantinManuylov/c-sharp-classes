// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string number = InputNumber("Введите число");
Console.WriteLine(IsPalindrom(number));

string InputNumber(string message)
{
    Console.WriteLine(message + " > ");
    string? number = Console.ReadLine();
    return number;
}

string IsPalindrom(string num)
{
    int x = 0;
    int temp = 0;
    int x2 = 0;
    if (int.TryParse(num, out x))
    {
        if (num[0] == '0')
        {
            return $"Введенное число {num} ненатуральное";
        }
        else
        {
            temp = x;
            while (temp > 0)
            {
                x2 *= 10;
                x2 += temp % 10;
                temp /= 10;
            }
            if (x == x2)
            {
                return $"Введенное число {num} является палиндромом.";
            }
            else
            {
                return $"Введенное число {num} не является палиндромом.";
            }
        }
    }
    else
    {
        return $"Введенные данные {num} не являются числом.";
    }
}