public class Punto1
{
    static void Main(string[] args)
    {
        //declaración variables
        double a, b, c, x;

        //instancia clase ramdon o datos de entrada
        Random random = new Random();

        a = random.Next(0, 8);
        b = random.Next(0, 8);
        c = random.Next(0, 8);


        //proceso

        x = (3 * a + 4 * b);
        x = Math.Pow(x, 3);
        x = Math.Sqrt(x);

        //salida
    }


}
