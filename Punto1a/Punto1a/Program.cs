
public class Punto1
{
    static void Main(string[] args)
    {
        double X, A, B, C;

        Random random = new Random();
        A = random.Next(1, 9);
        B = random.Next(1, 9);
        C = random.Next(1, 9);

        Console.Write("El valor de A es: " + A);
        Console.Write("El valor de B es: " + B);
        Console.Write("El valor de C es: " + C);

        X = Math.Sqrt((Math.Pow(Math.Pow(3 * A + 4 * B, 3), 2) * C) / Math.Pow(2 * C + A, 2));
        Console.Write("El valor de X es: " +  X);
    }
}