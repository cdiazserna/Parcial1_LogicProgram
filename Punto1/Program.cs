﻿//Punto1: Calcular la expreseión matemática

using System.Security.Cryptography;

public class CalculoExpresion
{
    static void Main(string[] args)
    {

        //Declaración de variables
        double randomNumberA, randomNumberB, randomNumberC, X;

        //Clase Random
        Random random = new Random();
        randomNumberA = random.Next(1, 8);
        randomNumberB = random.Next(1, 8);
        randomNumberC = random.Next(1, 8);

        //Cálculo
        X = (Math.Sqrt((Math.Pow(Math.Pow((3 * randomNumberA) + (4 * randomNumberB), 3), 2) * randomNumberC))) / (Math.Pow ((2 * randomNumberC) + randomNumberA, 2));

        


        
    }
}
