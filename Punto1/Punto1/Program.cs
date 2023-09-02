public class Parcial1
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int min = 1;  // Límite inferior del rango
        int max = 10; // Límite superior del rango (max - min = 9, que es menor que 8)

        int a = random.Next(min, max + 1);
        int b = random.Next(min, max + 1);
        int c = random.Next(min, max + 1);

        double x = Math.Sqrt(Math.Pow(3 * a + 4 * b, 3) / (2 * c * Math.Pow(2 * c + a, 2)));

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"c: {c}");
        Console.WriteLine($"x: {x}");
    }
}
