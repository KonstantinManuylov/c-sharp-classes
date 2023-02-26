string TruePrint(string[] array)
{
    string res = string.Empty;
    int size = array.Length;
    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i],3} ";
    }
    res += "]";
    return res;
}