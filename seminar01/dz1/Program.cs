// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int firstNumber = InputData("первое");
int secondNumber = InputData("второе");
int thirdNumber = InputData("третье");

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine($"Максимальное значение: число {firstNumber}.");
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine($"Максимальное значение: число {secondNumber}.");
}
else Console.WriteLine($"Максимальное значение: число {thirdNumber}.");

int InputData(string text)
{
    Console.WriteLine($"Введите {text} число > ");
    return Convert.ToInt32(Console.ReadLine());
}
