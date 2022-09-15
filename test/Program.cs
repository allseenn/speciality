string[] FillStringArray()
{
    string[] array = new string[0];
    var line = "0";
    for (int i = 0; line != string.Empty; i++)
    {
        Console.Write($"Give {i + 1} string, or enter empty to exit: ");
        line = Console.ReadLine();
        if (!string.IsNullOrEmpty(line)) 
        {
         Array.Resize(ref array, i + 1);
         array[i] = line;
        }
    }
    return array;
}
string[] ParseArray(string[] array, int num)
{
    string[] parsedArray = new string[0];
    int parsedIndex = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= num && !string.IsNullOrEmpty(array[i]))
        {   
            Array.Resize(ref parsedArray, parsedIndex + 1);
            parsedArray[parsedIndex] = array[i];
            parsedIndex++;
        }
    }
    return parsedArray;
}
Console.WriteLine("To fill strings array.\nGive any number of strings seperated by ENTER!");
string[] arr = FillStringArray();
Console.Write("\n[\"" + String.Join("\", \"", arr) + "\"] -> ");
Console.WriteLine("[\"" + String.Join("\", \"", ParseArray(arr, 3)) + "\"]");