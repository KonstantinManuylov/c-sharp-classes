// проверка на простое число

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckPrimary(int num, int divider)
{
    if (divider > 1)
    {
        return true;
    }
    else if (num % divider == 0)
    {
        return false;
    }
    return CheckPrimary(num, divider - 1);
}

int num = Prompt("Введите число");
Console.WriteLine(CheckPrimary(num, num - 1));