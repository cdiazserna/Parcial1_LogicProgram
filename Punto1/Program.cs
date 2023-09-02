using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random =new Random();
            int min = 1; // valor minimo permitido
            int max = 0; // valor maximo permitido

            // Generar valores aleatorios para a, b y c en el rango [min, max]
            int a = random.Next(min, max);
            int b = random.Next(min, max);
            int c = random.Next(min, max);
        }
    }
}
