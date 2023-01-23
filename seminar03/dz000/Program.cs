// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int numbers = InputData("Введите число");
Console.Write(numbers + " ");

int InputData(string message)
{
    Console.WriteLine(message + " > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}