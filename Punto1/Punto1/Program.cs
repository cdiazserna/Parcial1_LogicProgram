﻿using System;

//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión matemática
//y me permita encontrar el valor el
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
            c = random.Next(1,50);

            //proceso

            x = (3 * a + 4 * b);

            x = x * x * x;

            x = (x * x) * c;

            x = x / (2 * c + a) * (2 * c + a);

            x = Math.Sqrt(x);





            Console.WriteLine("La respuesta es: " + x);
        }
    }
}