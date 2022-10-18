int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

if (first % second == 0)
{
    Console.WriteLine($"Число {second} кратно числу {first}");
}
else
{
    int rest = first % second;
    Console.WriteLine($"Число {second} не кратно числу {first}, остаток {rest}");
}