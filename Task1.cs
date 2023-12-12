class Task1
{
    public static void Main(string[] args)
    {
        int M = 3;
        int N = 14;
        PrintNaturalNumbers(M, N);
    }
    static void PrintNaturalNumbers(int x, int y)
    {
        if (x < y)
        {
            Console.WriteLine(x);
            x++;
            PrintNaturalNumbers(x, y);
        } 
        else if (y < x) {
            Console.WriteLine(y);
            y++;
            PrintNaturalNumbers(x, y);
        } else Console.WriteLine(x);
    }
}