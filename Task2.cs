class Task2
{
    public static void Main(string[] args)
    {
        int M = 3;
        int N = 4;
        Console.WriteLine(Akkerman(M, N));
    }
    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
           return n+1;
        }
        else if (n == 0)
        {
           return Akkerman(m - 1, 1);
        }
        else
        {
           return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}