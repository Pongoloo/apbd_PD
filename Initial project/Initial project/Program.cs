// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("mod 1");
Console.WriteLine("mod2");
Console.WriteLine("mod3");

static double average(int[] tab)
{
    double result = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        result += tab[i];
    }

    result /= tab.Length;
    return result;
}
