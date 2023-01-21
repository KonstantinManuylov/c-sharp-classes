// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя). 
Console.Write("Введите число > "); 
string? strValue = Console.ReadLine(); 
int value; value = Convert.ToInt32(strValue); 
int result = value * value; 
System.Console.WriteLine($"Квадрат числа {value} равен {result}"); 
System.Console.WriteLine("Квадрат числа " + value + " равен " + result);