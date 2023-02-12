// Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void RecursionEvenNums(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    if (start % 2 != 0)
    {
        start++;
        Console.Write(start + " ");
        RecursionEvenNums(start + 2, finish);
    }
    else
    {
        Console.Write(start + " ");
        RecursionEvenNums(start + 2, finish);
    }
}

int firstNum = Prompt("Введите начальное число");
int secondNum = Prompt("Введите конечное число");
RecursionEvenNums(firstNum, secondNum);