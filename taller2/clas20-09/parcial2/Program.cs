﻿using System;
using System.Diagnostics.Metrics;

namespace parcial2
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        //D. Variable
        int rangoMinimo = 1;
        int rangoMaximo = 100;
        int numeroAleatorio = Random.Next(rangoMinimo, rangoMaximo + 1);
        int intentos = 0;
        int participante =0;
        bool adivinado = false;

        Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");
 
        Console.WriteLine("participante #2 ingrese su numero");
        Console.WriteLine("participante #3 ingrese su numero");
        Console.WriteLine("participante #4 ingrese su numero");
        Console.WriteLine($"Estoy pensando en un número entre {rangoMinimo} y {rangoMaximo}. ¿Puedes adivinar cuál es?");

        while (adivinado)
        {
           Console.Write("Introduce tu suposición: ");
                string entrada = Console.ReadLine(participante);

            if (participante == 2)
                numeroAleatorio = intentos Random.Next(0, 50);

            if (participante == 3)
                numeroAleatorio = intentos Random .Next(0, 100);

            if (participante == 4)
                numeroAleatorio = intentos Random.Next(0, 200);


            if (int.TryParse(entrada, out int suposicion))
            {
                intentos++;

                if (suposicion == numeroAleatorio)
                {
                 Console.WriteLine($"¡Felicitaciones! Adivinaste el número en {intentos} intentos.");
                   true adivinado = adivinado;
                        }
                else if (suposicion < numeroAleatorio)
                {
                 Console.WriteLine("El número que estoy pensando es mayor. ¡Sigue intentando!");
                
                   }
                else
                  {
                    Console.WriteLine("El número que estoy pensando es menor. ¡Sigue intentando!");                          
                else
                {
                 Console.WriteLine("Por favor, ingresa un número válido.");
                 Console.WriteLine("¡Gracias por jugar!");
        }
   













    }



}

               