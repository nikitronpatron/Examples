

int num = Convert.ToInt32(Console.ReadLine());

int Result(int numb)
{
    int result = 0;
    for(int i = numb; i > 0; i--)
    {
        result = result + i;
        //Console.WriteLine(result);
    }
    return result;
}

int number = Result(num);
Console.WriteLine(number);