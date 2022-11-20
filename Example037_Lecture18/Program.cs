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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 1, 15);
ShowArray(myArray);

void InverseArray(int[] array)
{
    int[] inverseArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        inverseArray[i] = array[array.Length - 1 - i];
        Console.Write($"{inverseArray[i]} ");
    }
    Console.WriteLine();
}
InverseArray(myArray);