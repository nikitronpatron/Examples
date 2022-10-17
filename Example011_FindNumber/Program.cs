int[] array = {53, 345, 564, 3242, 25, 6554, 435, 1, 25};

int length = array.Length;
int find = 25;
int index = 0;

while (index < length)
{
    // if (array[index] != 25) 
    // {
    //     index++;
    // }
    // else
    // {
    //     Console.WriteLine(index);
    //     index++;
    // }
    if(array[index] == 25)
    {
        Console.WriteLine(index);
        break; // Выведет только один, первый найденый индекс, из всех вохможных и прирвется
    }
    index++;
}