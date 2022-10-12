int a = 1;
int b = 1;
int c = 2;
int d = 4;
int e = 7;
int f = 5;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
if(f > max) max = f;

Console.WriteLine("max = " + max);