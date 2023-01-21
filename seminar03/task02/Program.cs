// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double dotX1 = InputInt("Введите точку X1");
double dotY1 = InputInt("Введите точку Y1");
double dotX2 = InputInt("Введите точку X2");
double dotY2 = InputInt("Введите точку Y2");

double lengthBetwPoints = findLength(dotX1, dotX2, dotY1, dotY2);
Console.WriteLine($"Расстояние между точками = {lengthBetwPoints:F2}");

double InputInt(string message)
{
    Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double findLength(double xOne, double xTwo, double yOne, double yTwo)
{
    
    double catet1 = Math.Pow(xOne - xTwo, 2);
    double catet2 = Math.Pow(yOne - yTwo, 2);
    double gipotenusa = Math.Sqrt(catet1 + catet2);
    return gipotenusa;
}