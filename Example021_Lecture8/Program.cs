void SquareIt (int number)
{
    for (int i = 1; i <= number; i++)
    {
        int square = i * i;
        Console.Write($"{square}    ");
    }
}

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareIt(number);