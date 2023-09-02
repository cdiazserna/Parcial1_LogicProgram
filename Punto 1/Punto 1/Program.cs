// See https://aka.ms/new-console-template for more information

class Punto_1
{

    static void Main()
    {
        double x, a, b, c;

        Random rand = new Random();

        a = rand.Next(10,18);
        b = rand.Next(10, 18);
        c = rand.Next(10, 18);

        x = Math.Sqrt(Math.Pow(Math.Pow((3 * a + 4 * b), 3),2)*c/Math.Pow((2*c+a),2));

        Console.WriteLine($"Valor de a: {a}");
        Console.WriteLine($"Valor de b: {b}");
        Console.WriteLine($"Valor de c: {c}");
        Console.WriteLine($"El resultado final es de {x}");


    }
}