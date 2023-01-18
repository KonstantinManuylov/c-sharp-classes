// Напишите программу, которая принимает на вход
// числа и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int firstNumber = InputInt("первое");
int secondNumber = InputInt("второе");
int thirdNumber = InputInt("третье");

bool check = CheckNumber(firstNumber, secondNumber, thirdNumber);
Console.WriteLine(check);

bool CheckNumber(int first, int second, int third)
{
    if (first % second == 0 && first % third == 0)
    {
        return true;
    }
    else return false;
}

int InputInt(string message)
{
    Console.WriteLine($"Введите {message} число > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}