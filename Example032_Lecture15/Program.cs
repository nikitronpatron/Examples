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

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
int ourValue = Convert.ToInt32(Console.ReadLine());
FoundNumber(ourValue);

void FoundNumber(int value)
{
    bool foundNum = false;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] == value)
        {
            foundNum = true;
        }
    }
    Console.WriteLine(foundNum ? "Yes" : "No");
}