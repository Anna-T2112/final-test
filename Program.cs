string[] GetArray()
{
    Console.WriteLine("Введите количество элементов массива:");
    int n = int.Parse(Console.ReadLine());
    string[] result = new string[n];
    for (var i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите элемент {i}:") ;
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] GetOutArray(string[] inArray)
{
    string outString = string.Empty;
    for(var i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
            outString += $"{inArray[i]};";
    }
    outString = outString.TrimEnd(';');
    return outString.Split(';');
}

void ShowArray(string[] inArray)
{
    Console.Write("[");
    for (var i = 0; i < inArray.Length; i++)
        if (i != (inArray.Length - 1))
            Console.Write($"{inArray[i]},");
        else
            Console.WriteLine($"{inArray[i]}]");
}


var inArray = GetArray();
var outArray = GetOutArray(inArray);
ShowArray(outArray);
