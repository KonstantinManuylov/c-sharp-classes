// развернуть строчку (например: "Пользователь ввёл строку" -> "укортс лёвв ьлетавозьлоП")

string input = "Пользователь ввёл строку";
string reverseWords = ReverseArray(input);
Console.WriteLine(reverseWords);

string ReverseArray(string originalString)
{
    char[] reversedCharArray = new char[originalString.Length];
    for (int i = originalString.Length - 1; i > -1; i--)
        reversedCharArray[originalString.Length - i - 1] = originalString[i];
    return new string(reversedCharArray);
}
