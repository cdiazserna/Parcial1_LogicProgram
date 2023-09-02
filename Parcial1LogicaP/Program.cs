

public class parcial1Logicap
{
    static void Main(string[] args)
    {
        double a, b, c, x;


        Random randon = new Random();
        
        a = randon.Next(1,10);
        b = randon.Next(1,10);
        c = randon.Next(1,10);

        x = Math.Sqrt(Math.Pow(Math.Pow(3 * a + 4 * b, 3), 2) * c / Math.Pow(2 * c + a, 2));
         
        Console.Write("x es igual a: " + x);
        Console.Write("\n");
    }









}