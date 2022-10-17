int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 34;
int c1 = 32;
int a2 = 45;
int b2 = 12;
int c2 = 45;
int a3 = 23;
int b3 = 56;
int c3 = 74;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);