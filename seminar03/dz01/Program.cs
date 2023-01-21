// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
/* A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double x1 = InputData("X1");
double x2 = InputData("X2");
double x3 = InputData("X3");
double y1 = InputData("Y1");
double y2 = InputData("Y2");
double y3 = InputData("Y3");

double findLengthResult = FindLength(x1, x2, x3, y1, y2, y3);
Console.WriteLine($"Расстояние между точками = {findLengthResult:F2}");

double FindLength(double x1, double x2, double x3, double y1, double y2, double y3)
{
    double katet1 = Math.Pow(x1 - y1, 2);
    double katet2 = Math.Pow(x2 - y2, 2);
    double katet3 = Math.Pow(x3 - y3, 2);
    return Math.Sqrt(katet1 + katet2 + katet3);
}

double InputData(string message)
{
    Console.WriteLine($"Введите координату точки {message} > ");
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}