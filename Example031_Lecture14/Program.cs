int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void ShowArrayNegative(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
ShowArrayNegative(myArray);

