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

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sumPos = 0;
int sumNeg = 0;

for(int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >= 0)
    {
        sumPos += myArray[i];
    }
    else
    {
        sumNeg += myArray[i];
    }
}

System.Console.WriteLine($"positive = {sumPos}, negative = {sumNeg}");