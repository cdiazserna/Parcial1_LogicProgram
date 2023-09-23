using System;

namespace parcial2
{
    static void Main(string[] args)
    {
        //D. Variable
        int rangoMinimo = 1;
        int rangoMaximo = 100;
        int numeroAleatorio = Random.Next(rangoMinimo, rangoMaximo + 1);
        int intentos = 0;
        bool adivinado = false;

        Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");

        Console.WriteLine($"Estoy pensando en un número entre {rangoMinimo} y {rangoMaximo}. ¿Puedes adivinar cuál es?");

        while (adivinado)
        {
           Console.Write("Introduce tu suposición: ");
                string entrada = Console.ReadLine();

               