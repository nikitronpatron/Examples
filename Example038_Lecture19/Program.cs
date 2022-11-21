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

int[] myArray = CreateRandomArray(3, 1, 15);
ShowArray(myArray);

void CheckSidesTriangle(int[] array)
{
    int i = 0;
    if(array[i] < array[i + 1] + array[i + 2] && 
        array[i + 1] < array[i] + array[i + 2] &&
        array[i + 2] < array[i] + array[i + 1])
    {
        Console.WriteLine("It`s a triangle");
    }
    else
    {
        Console.WriteLine("It isn`t a triangle");
    }
}

CheckSidesTriangle(myArray);