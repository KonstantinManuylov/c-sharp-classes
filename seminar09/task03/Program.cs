// A B - возводит в степень

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int ShowPows(int num, int pow)
{
    if (pow == 0)
    {
        return 1;
    }
    return num * ShowPows(num, pow - 1);
}

int baseNum = Prompt("Введите базовое число");
int powNumber = Prompt("Введите значение степени");
int powNum = ShowPows(baseNum, powNumber);
Console.Write(powNum + " ");