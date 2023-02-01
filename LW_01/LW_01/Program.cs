class Program
{
    static void Main(string[] args)
    {
        Console.Write("а) Введите число s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("   Теперь введите число k: ");
        int k = int.Parse(Console.ReadLine());
        int d = s + 1;
        s = d;
        k = 2 * s;
        Console.WriteLine($"   После изменения s имеет значение {s}, а k имеет значение {k}.\n");
        Console.WriteLine("\n\n");
        Console.Write("б) Введите число s: ");
        s = int.Parse(Console.ReadLine());
        Console.Write("   Теперь введите число k: ");
        k = int.Parse(Console.ReadLine());
        d = k - 5;
        k = 2 * d;
        s = k - 100;
        Console.WriteLine($"   После изменения s имеет значение {s}, а k имеет значение {k}.");
    }
}