// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

if (Validate(k1, k2))
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.WriteLine($"Прямые пересекаются в точке {x} {y}");
}

double InputData(string msg)
{
    Console.WriteLine($"Введите координату точки {msg} > ");
    return Convert.ToDouble(Console.ReadLine());
}

bool Validate(double k1, double k2)
{
    if (k1 == k2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

double CalculationXPoint(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double CalculationYPoint(double x, double k1, double b1)
{
    return k1 * x + b1;
}

double b1 = InputData("b1");
double k1 = InputData("k1");
double b2 = InputData("b2");
double k2 = InputData("k2");

double x = CalculationXPoint(b1, k1, b2, k2);
double y = CalculationYPoint(x, k1, b1);