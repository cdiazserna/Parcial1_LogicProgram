public class Punto1
{
    static void Main(string[] args)
    {
        //declaración variables
        double a, b, c, solucionDenominador, solucionNumerador, x;

        //instancia clase ramdon o datos de entrada
        Random random = new Random();

        a = random.Next(1, 8);
        b = random.Next(1, 8);
        c = random.Next(1, 8);


        //proceso

        solucionNumerador = (3 * a + 4 * b);
        Console.WriteLine(solucionNumerador);
        solucionNumerador = Math.Pow(solucionNumerador, 3);
        Console.WriteLine(solucionNumerador);
        solucionNumerador = Math.Pow(solucionNumerador, 2);
        Console.WriteLine(solucionNumerador);
        solucionNumerador = solucionNumerador * c;
        Console.WriteLine(solucionNumerador);

        solucionDenominador = (2 * c) + a;
        Console.WriteLine(solucionDenominador);
        solucionDenominador = Math.Pow(solucionDenominador, 2);
        Console.WriteLine(solucionDenominador);


        x = solucionNumerador / solucionDenominador;
        Console.WriteLine(x);
        x = Math.Sqrt(x);

        //salida

        Console.WriteLine(x);
    }


}
