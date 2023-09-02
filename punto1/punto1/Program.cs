using System;

namespace punto1
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            //Realice un programa en C# donde se tenga la posibilidad de evaluar una ecuación matemática y permita encontrar 
            //el valor de la variable

            //Defino primeramente las variables
            int a, b, c;
            double x;

            // Realizamos el proceso

            //Asignamos el valor de las variables

            Random random = new Random();

            a = (int)random.Next(10,18 );

            b = (int)random.Next(3, 11);

            c = (int)random.Next(1, 8);

            //Realizamos el calculo para encontrar la variable x

            x = (double) Math.Sqrt( Math.Pow(Math.Pow(3 * a + 4 * b, 3), 2)*c / Math.Pow ((2 * c) + a, 2));

            Console.WriteLine("Los números escogidos para hacer el programa son: " + a + " " + b + " y " + c);
            Console.WriteLine("y el valor de nuestra variable x es: " + x);









        }
    }
}
