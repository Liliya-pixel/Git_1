// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

partial class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 4 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int y = a.GetLength(0);
        int x = a.GetLength(1);

        int[] sort =  int[x * y];

        int counter = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
                {
                sort[counter] = a[i, j];
                counter++;

            }

        }
        Array.Sort(sort);
        counter = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                a[i, j] = sort[counter];
                counter++;

                Console.Write(a[i, j] + "");
            }
            

        }
    }


}


