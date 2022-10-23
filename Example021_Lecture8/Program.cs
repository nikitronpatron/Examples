void SquareIt (int number)
{
    for (int i = 1; i < number; i++)
    {
        int square = i * i;
        Console.Write($"{square}, ");
    }
    if (number > 0)
    {
        int squareLast = number * number;
        Console.WriteLine($"{squareLast}.");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareIt(number);