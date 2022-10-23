string GetCoordinatesFromQuarter(int userQuarter)
{   
    string coordinates = "";

    switch (userQuarter)
    {
        case 1:
            //Console.WriteLine("X belongs from zero to infinity and Y belongs from zero to infinity");
            coordinates = "X belongs from zero to infinity and Y belongs from zero to infinity";
            break;
        case 2:
            //Console.WriteLine("X belongs from zero to minus infinity and Y belongs from zero to infinity");
            coordinates = "X belongs from zero to minus infinity and Y belongs from zero to infinity";
            break;
        case 3:
            //Console.WriteLine("X belongs from zero to minus infinity and Y belongs from zero to minus infinity");
            coordinates = "X belongs from zero to minus infinity and Y belongs from zero to minus infinity";
            break;
        case 4:
            //Console.WriteLine("X belongs from zero to infinity and Y belongs from zero to minus infinity");
            coordinates = "X belongs from zero to infinity and Y belongs from zero to minus infinity";
            break;
    }
    
    return coordinates;
}

Console.WriteLine("Enter a quarter ");
int userQuarter = Convert.ToInt32(Console.ReadLine());
string coordinates = GetCoordinatesFromQuarter(userQuarter);
if (userQuarter > 0 && userQuarter < 5)
{
    Console.Write($"In {userQuarter} quarter {coordinates}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error");
    Console.ResetColor();
}
