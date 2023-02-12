// Проверка на кратность к 2

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckBinary(int num)
{
    if (num == 1)
    {
        return true;
    }
    else if (num % 2 != 0)
    {
        return false;
    }
    return CheckBinary(num / 2);
}

bool CheckBinary2(int num)
{
    if (num == 1)
    return true;
    return (num % 2 == 0) && CheckBinary2(num / 2);
}

int number = Prompt("Введите число");
Console.WriteLine(CheckBinary(number));
Console.WriteLine(CheckBinary2(number));