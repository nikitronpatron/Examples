
//Вид 1
void Method1()
{
    Console.WriteLine("My name is");
}
//Method1();// вызов метода

//Вид 2
void Method2(string message)
{
    Console.WriteLine(message);
}
//Method2(message : "Text message"); // : - какому аргументту какое значение мы хотим указать

void Method21(string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i++;
    }
}
//Method21(message :"Да я жоский", count : 5); // при такой записи не обязательно соблюдать очередь аргументов

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;// как я понял типа пустая строка
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// string message = Method4(3, "I love my mom ");
// Console.WriteLine(message);