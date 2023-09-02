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
        solucionNumerador = Math.Pow(solucionNumerador, 3);
        solucionNumerador = Math.Pow(solucionNumerador, 2);
        solucionNumerador = solucionNumerador * c;

        solucionDenominador = (2 * c) + a;
        solucionDenominador = Math.Pow(solucionDenominador, 2);


        x = solucionNumerador / solucionDenominador;
        x = Math.Sqrt(x);

        //salida

        Console.WriteLine("Al resolver la expresión matematica el resultado es: " + x);

    }


}
