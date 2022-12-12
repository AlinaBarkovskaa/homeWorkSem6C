 string[] SubMas(string[] ar, int index)
 {
    int newMasLength = ar.Length -1;
    string[] newArray = new string[newMasLength];
    for (int i = 0; i < ar.Length; i++)
    {
        if (i != index)
        {
            if (i > index)
            {
                newArray[i - 1] = ar[i];
            }
            else
                newArray[i] = ar[i];
        }

    }
    return newArray;
}
void Print(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(' ' + newArray[i]);
    }
    Console.WriteLine();
}
void Permutation(string[] mas, int t, string[] keys)
{
    if (mas.Length > 1)
    {
        string[] newMas = SubMas(mas, t);
        keys[keys.Length - mas.Length] = mas[t];
        Permutation(newMas, 0, keys);
        if (mas.Length > t + 1)
        {
            Permutation(mas, t + 1, keys);
        }
    }
    else
    {
        keys[keys.Length - mas.Length] = mas[t].ToString();
        Print(keys);
    }
}
Console.Clear();
string[] n = { "A", "B", "C" };
Permutation(n, 0, new string[n.Length]);
