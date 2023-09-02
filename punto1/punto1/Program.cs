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

            a = random.Next(2, 10);

            b = random.Next(3, 11);

            c = random.Next(1, 8);

            //Realizamos el calculo para encontrar la variable x

            x = (double)Math.Sqrt((Math.Pow(2, Math.Pow(3, (3*a)+(4*b)))*c) / Math.Pow(2,(2*c)+a));
        

            

         




        }
    }
}
