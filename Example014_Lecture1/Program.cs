int number = new Random().Next(10, 99);

int one = number % 10;
int ten = number / 10;

Console.WriteLine(number);

if (one > ten)
{
    Console.WriteLine(one);
}
else
{
    Console.WriteLine(ten);
}