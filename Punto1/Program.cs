
using System.ComponentModel.DataAnnotations;

public class Punto1
{
    static void Main(string[] args)


    {
        Random random = new Random();

        double randomNumberA, randomNumberB, randomNumberC, a, b, c, x;
        randomNumberA = random.Next(1, 8);
        randomNumberB = random.Next(2, 8);
        randomNumberC = random.Next(3, 8);

        a = randomNumberA;
        b = randomNumberB;
        c = randomNumberC;

        x = (Math.Sqrt(((Math.Pow(Math.Pow((3 * a) + (4 * b), 3), 2) * c) / (Math.Pow(((2 * c) + a), 2)))));

        Console.WriteLine("El valor de la variable x es: " + x);

    }
}
