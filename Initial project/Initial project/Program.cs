// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("mod 1");
Console.WriteLine("mod2");
Console.WriteLine("mod3");

static int Max(int[] tab)
{
    int result = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (result < tab[i])
        {
            result = tab[i];
        }
    }

    return result;
}
static double average(int[] tab)
{
    double conflict = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        conflict += tab[i];
    }

    conflict /= tab.Length;
    return conflict;

}
