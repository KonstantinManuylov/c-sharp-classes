// сумма от 1 до N

int number = InputNumber("Введите число > ");
int result = SumNumber(number);
Console.WriteLine(result);

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int SumGaussNumbers(int number)
{
    return (number+1)*number/2;
}

int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}