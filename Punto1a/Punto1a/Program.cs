
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
       
    }
}