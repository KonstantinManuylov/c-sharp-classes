// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double numberInput = InputData("Введите число");
Console.Write($"{numberInput} -> ");
for (double i = 1; i <= numberInput; i++)
{
    Console.Write($"{FindSquare(i)} ");
}

double FindSquare(double num)
{
    return Math.Pow(num, 3);
}

double InputData(string message)
{
    Console.WriteLine(message + " > ");
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}