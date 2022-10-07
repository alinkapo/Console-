static int i = 0;
static char array[] = new char[30];
static void Main(string[] args)
{ 
for (i = 0; i < 30; i++)
{
    char a = Console.ReadKey().KeyChar;
    AddChar(a);
}
static void AddChar(char a)
{
    int stop = 0;
    for (int i = 0; i < 30; i++)
    {
        if (array[i] == a && stop == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Такая буква есть в массиве");
            stop++;
        }
    }
}
   if (stop == 0)
{
    Console.WriteLine("");
    Console.WriteLine("Такой буквы нет в массиве");
}

static bool CheckChar(char s)
{
    int stop = 0;
    for (int i = 0; i < 30; i++)

        if (array[i] == s && stop == 0)
        {
            b = true;
            stop++;
        }
    if (stop == 0)
    {
        return b;
    }
    b = false;
    stop++;

    return b;
}