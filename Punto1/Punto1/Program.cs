public class Punto1
{
    static void Main(string[] args)
    {
        //declaración variables
        double a, b, c, solucionDenominador, solucionNumerador, x;

        //instancia clase ramdon o datos de entrada
        Random random = new Random();

        a = random.Next(0, 8);
        b = random.Next(0, 8);
        c = random.Next(0, 8);


        //proceso

        solucionNumerador = (3 * a + 4 * b);
        solucionNumerador = Math.Pow(solucionNumerador, 3);
        solucionNumerador = Math.Pow(solucionNumerador, 2);
        solucionNumerador = solucionNumerador * c;

        solucionDenominador = (2 * c) + a;
        solucionDenominador = Math.Pow(solucionDenominador, 2);

        x = Math.Sqrt(solucionNumerador/solucionDenominador);

        //salida
    }


}
