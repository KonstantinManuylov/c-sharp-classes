// на вход число и вывод сумму его цифр

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int ShowSum(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num % 10 + ShowSum(num / 10);
}

int number = Prompt("Введите число");
int result = ShowSum(number);
Console.WriteLine(result);