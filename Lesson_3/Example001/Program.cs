// Группы методов 
// 1,2 ничего не вовращают, 3,4 возвращают
// Вид 1

void Method()
{
    Console.WriteLine("Автор...");
}
Method();


// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сооющения");

//////////

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);


// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4
string Method4(int count, string text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text + " ";
    }
    return result;
}

string res = Method4(3, "hello");
Console.WriteLine(res);