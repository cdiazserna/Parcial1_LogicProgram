// realizar punto 1

public class Punto1
{
    private static int randomNumber;

    static void Main(string[] args)
    {
        Random random = new();

        double a, b, c;

        Console.Write("ingrese el valor de a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de b:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de c:");
        c = Convert.ToDouble(Console.ReadLine());

        // Calcular el valor de x
        double x = Math.Sqrt(Math.Pow(3 * a + 4 * b, 3) * Math.Pow(2 * c, 2 * (2 * c + a)));
        



    }
}
