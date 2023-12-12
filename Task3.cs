class Task3
{
    public static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        PrintReverseArray(array, array.Length-1);
    }
    static void PrintReverseArray(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(arr[index]);
        PrintReverseArray(arr, index-1);
    }
}