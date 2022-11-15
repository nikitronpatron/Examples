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

for (int i = 0; i < myArray.Length/2; i++)
{
    System.Console.WriteLine($"{myArray[i] * myArray[myArray.Length-i-1]} ");
}
if(myArray.Length % 2 != 0)
{
    System.Console.WriteLine($"{myArray[myArray.Length/2]} ");
}