double FindInterval (double aX, double bX, double aY, double bY)
{
    double interval = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
    return interval;
}
Console.WriteLine("Enter coordinates of the point A: ");
double aX = Convert.ToDouble(Console.ReadLine());
double aY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinates of the point B: ");
double bX = Convert.ToDouble(Console.ReadLine());
double bY = Convert.ToDouble(Console.ReadLine());
double interval = FindInterval(aX, bX, aY, bY);
Console.WriteLine($"interval between points equal {interval}");