﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese nombre del empleado");
        string nombre = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese el cargo del empleado");
        string cargo = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la cantidad de horas trabajadas");
        double horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la cantidad de horas trabajadas");
        double vhora = double.Parse(Console.ReadLine());

        Console.WriteLine("Los números comprendidos entre " + numero1 + " y " + numero2 + " son:");

        if (numero1 <= numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = numero1; i >= numero2; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

