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

int[] myArray = CreateRandomArray(123, 1, 150);
ShowArray(myArray);
int arrayCount = FoundNumbers(myArray);
Console.WriteLine(arrayCount);

int FoundNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] >= 10 && myArray[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
    