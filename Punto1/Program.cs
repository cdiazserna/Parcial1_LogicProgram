﻿// Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión matemáticay me permita encontrar el valor de la variable "𝒙":

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
            int randomNumber = random.Next(min, max);
            int a = randomNumber;
            randomNumber = random.Next(min, max);
            int b = randomNumber;
            randomNumber = random.Next(min, max);
            int c = randomNumber;

            // calcular el valor de x utilisando la expresion matematica
            double x = Math.Sqrt(Math.Pow(3 * a + 4 * b, 3) / Math.Pow(2 * c + a, 2));

            //imprimir el valos de x
            Console.WriteLine("el valor de x es: " + x);

        }
    }
}
