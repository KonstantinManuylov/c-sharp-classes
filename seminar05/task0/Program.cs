// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int SumSign(int[] array, bool positive = true)
{
    int sign = -1;
    if (positive)
    {
        sign = 1;
    }

    int sum = 0;
    foreach (int item in array)
    {
        if ((item * sign) > 0)
        {
            sum += item;
        }
    }

    return sum;
}

int length = 12;
int minVal = -9;
int maxVal = 9;
int[] array = CreateArray(length, minVal, maxVal);
PrintArray(array);
int sumPositive = SumSign(array);
int sumNegative = SumSign(array, false);
System.Console.WriteLine($"Сумма положительных элементов {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных элементов {sumNegative}");