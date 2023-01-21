// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = InputInt($"Введите номер четверти");
if (Validate(quarter))
{
    string coords = FindCoordinates(quarter);
    Console.WriteLine(coords);
}

string FindCoordinates(int quarterNumber)
{
    if (quarterNumber == 1)
    {
        return "X > 0; Y > 0";
    }
    if (quarterNumber == 2)
    {
        return "X < 0; Y > 0";
    }
    if (quarterNumber == 3)
    {
        return "X < 0; Y < 0";
    }
    else
    {
        return "X > 0; Y < 0";
    }
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Validate(int number)
{
    if (number < 1 || number > 4)
    {
        Console.WriteLine("Такой четверти нет.");
        return false;
    }
    return true;
}