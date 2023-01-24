// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number = InputInt("Введите число");
int powNumber = InputInt("Введите степень");
int searchedPowNumber = FindPowNumber(number, powNumber);
Console.WriteLine($"{number} в сепени {powNumber} = {searchedPowNumber}");

int FindPowNumber(int num, int pow)
{
    int baseNumber = num;
    for (int i = 1; i < pow; i++)
    {
        num *= baseNumber;
    }
    return num;
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}