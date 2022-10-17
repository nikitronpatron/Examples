// WWA - work with array

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10, 50);
        index++;
    }
}

void PrintArray(int[] numbers)
{
    int count = numbers.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(numbers[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);