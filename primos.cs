
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("por favor ingrese un numero hasta donde le gustaria ver los numeros primos");
int k = Convert.ToInt32(Console.ReadLine());

int s = 2;
int o = 1;
int j = 0;

while (s <= k)
{
    while (o <= s)
    {
        if (s % o == 0)
        {
            j++;
        }
        o++;
    }

    if (j == 2)
    {
        Console.WriteLine(s);
    }
    s++;

    o = 1;

    j = 0;
}
