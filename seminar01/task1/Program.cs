// Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли второе число квадратом первого. 
//a = 5; b = 25 -> да a = 2 b = 10 -> нет a = 9; b = -3 -> нет a = -3 b = 9 -> да 

Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber * firstNumber == secondNumber)
    {
        Console.WriteLine($"Первое число {firstNumber} является квадратом второго числа {secondNumber}");
    }
else
    {
        Console.WriteLine($"Первое число {firstNumber} не является квадратом второго числа {secondNumber}");
    }