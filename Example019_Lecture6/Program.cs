

int GetQuarterFromCoordinate (int userX, int userY)
{
    int quarter = 0;

    if (userX > 0 && userY > 0)
        quarter = 1;
    if (userX > 0 && userY < 0)
        quarter = 4;
    if (userX < 0 && userY < 0)
        quarter = 3;
    if (userX < 0 && userY > 0)
        quarter = 2;

    return quarter;
}

Console.WriteLine("Enter coordinates: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());
int quarter = GetQuarterFromCoordinate(userX, userY);
if (quarter != 0)
{ 
    Console.WriteLine($"You are in ({userX}, {userY}), in {quarter} quarter");  
}
else
{
    Console.WriteLine("Error");
}
