// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rnd = new Random();
int number = rnd.Next(10, 100);

int[] numbers = splitNumbers(number);
int max = maxNum(numbers);

Console.WriteLine(number);
Console.WriteLine(max);

int[] splitNumbers(int num)
{
    int[] pairNumbers = new int [2];
    int num1 = num / 10;
    int num2 = num % 10;
    pairNumbers[0] = num1;
    pairNumbers[1] = num2;
    return pairNumbers;
}

int maxNum(int[] nums)
{
    int max = nums[0];
    if (nums[1] > max)
    {
        max = nums[1];
    }
    return max;
}