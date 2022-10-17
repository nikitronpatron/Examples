// на входе - число, на выходе - квадрат
Console.WriteLine("Enter a number: ");

int number = Convert.ToInt32(Console.ReadLine());

int sqr = number * number;

Console.WriteLine($"The square of the {number} is equal {sqr}");