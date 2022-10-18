int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

if (first == second * second ||
    second == first * first)
{
    Console.WriteLine($"{first}, {second} -> yes");
}
else
{
    Console.WriteLine($"{first}, {second} -> no");
}