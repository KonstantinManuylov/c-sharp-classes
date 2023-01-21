// подсчитать количество максимальных элементов в массиве.

int[] numsArray = {5, 4, 9, 6, 3, 4, 9, 8, 7, 4, 6, 1, 6, 9};
int maxNumber = FindMax(numsArray);
int valueMaxNums = CountMax(numsArray, maxNumber);
Console.WriteLine($"В заданном массиве максимальное значение {maxNumber}, в количестве {valueMaxNums}");

int CountMax(int[] array, int maxNum)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNum == array[i])
        {
            count ++;
        }
    }
    return count;
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}