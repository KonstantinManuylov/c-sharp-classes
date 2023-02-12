// рекурсия от M - N

int Prompt(string msg)
{
    Console.WriteLine(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void RecursionRange(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    Console.Write(start + " ");
    RecursionRange(start + 1, finish);
}

int start = Prompt("Введите начальное число");
int finish = Prompt("Введите конечное число");
RecursionRange(start, finish);