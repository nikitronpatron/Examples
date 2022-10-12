Console.Write("Enter your name: ");
string UserName = Console.ReadLine();

if(UserName.ToLower() == "katya" || UserName.ToLower() == "ekaterina")
{
    Console.WriteLine("Hello, " + UserName + "! I love you!");
}
else
{
    Console.WriteLine("Hi, " + UserName);
}