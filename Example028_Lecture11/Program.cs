
int numb = Convert.ToInt32(Console.ReadLine());

int LengthNumb(int number)
{
    int length = 0;
    while(number > 0)
    {
        length++;
        number = number / 10;
    }
    return length;
}

int num = LengthNumb(numb);
Console.WriteLine(num);