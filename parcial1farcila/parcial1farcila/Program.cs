using System;

namespace parcial1farcila
{
    class Program
    {
        static void Main(string[] args)

        {
            //declaracion de variables
            double A, B, C;
            {
                // Generacion de la instancia
                Random random = new Random();
                A = random.Next(4, 12);
                B = random.Next(4, 12);
                C = random.Next(4, 12);
                //Calculos (Proceso)
                double X1 = Math.Pow(3, (3 * A + 4 * B));
                double X2 = Math.Pow(2, X1 * C);
                double X3 = Math.Pow(2, 2 * C + A);
                double X = Math.Sqrt(X2 / X3);
                Console.Write($"El valor de X es:{X}");


            }
        }
    }
}
