// Напишите программу вычисления модуля числа.
	// 2 -> 2
	// -3 -> 3
	// -7 -> 7

Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    {
        Console.WriteLine($"{number * -1}");
    }
else Console.WriteLine($"{number}");