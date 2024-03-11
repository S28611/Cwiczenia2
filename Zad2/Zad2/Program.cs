// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void  Main(String[] args)
    {
        Console.WriteLine("Modtyfikacja 2");
        int num = 10;
        if (num == 10)
        {
            Console.WriteLine("Num = 10");
        }
    }

    public static int Srednia(int[] tab)
    {
        int res = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            res += tab[i];
        }

        res = res / tab.Length;

        return res;
    }
}

