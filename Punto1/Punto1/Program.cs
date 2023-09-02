public class Punto1
{
    static void Main(string[] args)
    {
        double X, A, B, C;


        Random random1 = new Random();
        A = random1.Next(1, 9);
        Random random2 = new Random();
        B = random2.Next(1, 9);
        Random random3 = new Random(); 
        C = random3.Next(1, 9);
        X = Math.Sqrt((Math.Pow(Math.Pow(3 * A + 4 * B, 3), 2)*C) / Math.Pow(2*C + A, 2));
        Console.Write("El valor de x es: " + X);

 

    }








}
