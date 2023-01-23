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
            return "Введенное число ненатуральное";
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
/* 
int x, x_tmp, x2 = 0;
        Console.Write("Введите число: ");
        string s = Console.ReadLine();
        
        if (int.TryParse(s, out x))
        {
            if (s[0]=='0')Console.WriteLine("не натуральное число");
            else
            {
                x_tmp = x;
                while (x_tmp > 0)
                {
                    x2 *= 10;
                    x2 += x_tmp % 10;
                    x_tmp /= 10;
                }
                if (x == x2) Console.WriteLine("палиндром");
                else Console.WriteLine("не палиндром");
            }
        } 
        else
        {
            Console.WriteLine("Введено не число");
        } */