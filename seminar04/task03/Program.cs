// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = InputInt("Введите число");
int[] newArray = FillArray(number);
PrintArray(newArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] FillArray(int size)
{
    Random rnd = new Random();
    int[] newArray = new int[size];
    for (int i = 0; i <= newArray.Length; i++)
    {
        newArray[i] = rnd.Next(0, 2);
    }
    return newArray;
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}