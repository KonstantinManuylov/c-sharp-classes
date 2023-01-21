// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int PromtInt(string message)
{
    Console.Write($"{message} >");
    return int.Parse(Console.ReadLine());
}

bool Validate(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        Console.WriteLine($"Одна из координат находится на оси.");
        return false;
    }
    return true;
}

int GetQuarter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0)
    {
        return 1;
    }
    if (xCoord > 0 && yCoord < 0)
    {
        return 4;
    }
    if (xCoord < 0 && yCoord < 0)
    {
        return 2;
    }
    else
    {
        return 3;
    }
}

int x = PromtInt($"Введите X");
int y = PromtInt($"Введите Y");
if (Validate(x, y))
{
    int quarter = GetQuarter(x, y);
    Console.WriteLine(quarter);
}