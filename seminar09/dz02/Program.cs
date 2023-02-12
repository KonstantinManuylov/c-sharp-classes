// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunc(m - 1, 1);
    }
    else
    {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }

}

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = Prompt("Введите первое число - m");
int secondNum = Prompt("Введите второе число - n");
int result = AckermanFunc(firstNum, secondNum);
Console.WriteLine($"Результат функции Аккермана при переменных m = {firstNum} и n = {secondNum}: {result}");