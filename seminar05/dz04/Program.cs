// перед вами строка, "Например вот такая строка" 
// надо реверснуть строки на выходе "строка такая вот Например"

string text = "Например вот такая строка";
string[] textArray = TextToArray(text);
PrintReversedArray(textArray);
string[] reversedArray = Reverse(textArray);
PrintArray(reversedArray);

string[] TextToArray(string text)
{
    string[] result = text.Split(" ");
    return result;
}

// Вариант просто распечатки строкового массива в обратную сторону.

void PrintReversedArray(string[] array) 
{
    Console.WriteLine($"Метод распечатки массива циклом в обратную сторону: ");
    for (int i = array.Length -1; i >= 0; i--)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    Console.WriteLine($"Метод реверса массива кортежами: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Вариант реверса массива кортежами, спасибо семинару :)

string[] Reverse(string[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap(array, i, array.Length - 1 - i);
    }
    return array;
}

void Swap(string[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}