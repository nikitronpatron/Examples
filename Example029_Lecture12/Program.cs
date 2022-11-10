int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}] ");