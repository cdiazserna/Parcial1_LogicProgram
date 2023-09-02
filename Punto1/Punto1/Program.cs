using System;

//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión matemática y me permita encontrar el valor e
//decimal la variable x

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar variables
            double a, b, c, x;

            //Asignación de números aleatorios

            Random random = new Random();

            a = random.Next(2,10);
            b = random.Next(2,10);
            c = random.Next(2,10);

            //proceso

            x = (3 * a + 4 * b);

            x = x * x * x;

            x = (x * x) * c;

            x = X





            Console.WriteLine("Hello World!");
        }
    }
}
