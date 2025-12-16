namespace KT11_1;

class Program
{
    static void Swap<T>(ref T x, ref T y) where T: struct
    {
        T temp = x;
        x = y;
        y = temp;
    }

    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Swap(ref a, ref b);

        Console.WriteLine($"a = {a}, b = {b}");

        double x = 1.5;
        double y = 3.7;

        Swap(ref x, ref y);

        Console.WriteLine($"x = {x}, y = {y}");

        bool flag1 = true;
        bool flag2 = false;

        Swap(ref flag1, ref flag2);

        Console.WriteLine($"flag1 = {flag1}, flag2 = {flag2}");
    }
}

