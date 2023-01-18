// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int number = InputInt($"Введите число от 1 до 7");
string day = CheckDay(number, "Рабочий день", "Выходной");
Console.WriteLine(day);

string CheckDay(int num, string workDay, string hollyday)
{
    if (num <= 5)
    {
        return workDay;
    }
    else
    {
        return hollyday;
    }    
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    if (result < 1 || result > 7)
    {
        Console.WriteLine("Такого дня нет.");
        return InputInt(message);
    }
    return result;
}