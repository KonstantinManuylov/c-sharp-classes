// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

double number = InputData("Введите число 1");
double number2 = InputData("Введите число 2");

double resultDivide = FindDivide(number, number2);
Console.WriteLine($"Целочислительное деление = {resultDivide}");

double resultDivideLeft = FindLeft(number, number2);
Console.WriteLine($"Деление по остатку = {resultDivideLeft}");

/* if (number < 100 && number > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
    Console.WriteLine(FindSecond(number));
}

int FindSecond(int num)
{
    num = 100;
    num = 10;
    return num;
} */

double InputData(string message)
{
    Console.WriteLine(message + " > ");
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double FindDivide(double num1, double num2)
{
    return num1 / num2;
}

double FindLeft(double num1, double num2)
{
    return num1 % num2;
}