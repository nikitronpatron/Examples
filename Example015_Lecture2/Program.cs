int number = new Random().Next(100, 999);
Console.WriteLine(number);

int one = number % 10;
///int ten = number / 10;
int hundred = number / 100;

Console.WriteLine($"{hundred}{one}");