// See https://aka.ms/new-console-template for more information

class Punto_1
{

    static void Main()
    {
        double x, a, b, c,randomNumber;

        Random rand = new Random();

        randomNumber = rand.Next(10,18);

        Console.WriteLine(randomNumber);
    }
}