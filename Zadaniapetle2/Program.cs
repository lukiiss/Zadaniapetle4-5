using System;

Console.WriteLine("");
Console.WriteLine("Zadanie 4");
Console.WriteLine("");

Console.WriteLine("Podaj liczbe całkowitą większą od 0: ");
string insert = Console.ReadLine();
int answer = int.Parse(insert);
Console.WriteLine(answer);
int b = 1;
int a = 1;
int c = 0;
Console.WriteLine("===================");
do
{
    Console.Write(a + " ");
    c++;
    if (c == b)
    {
        Console.WriteLine();
        c = 0;
        b++;
    }
    a++;
}
while(a <= answer);

Console.WriteLine("");
Console.WriteLine("Zadanie 5");
Console.WriteLine("");

static int TrzeciaPotega(int i)
{
    int a = i * i * i;
    return a;
}
int n = 1;
while(n <= 20)
{
    Console.WriteLine(TrzeciaPotega(n));
    n++;
}

