﻿using System.Timers;

public class Punto2
{
    static void Main(string[] args)
    {
        //declaración variables
        string empleado, cargo;
        int horasTrabajadas;
        decimal valorHora, pagoCompleto, pagoDeducciones, pagoDescuentoSaludPension;

        //datos de entrada
        Console.WriteLine("Ingrese el nombre del empleado: ");
        empleado = Console.ReadLine();

        Console.WriteLine("Ingrese el cargo del empleado: ");
        cargo = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la hora: ");
        valorHora = decimal.Parse(Console.ReadLine());


        //proceso
        pagoCompleto = horasTrabajadas * valorHora;//calculo del sueldo total
        pagoDescuentoSaludPension = pagoCompleto * 8/100 - pagoCompleto;
        pagoDeducciones = pagoDescuentoSaludPension * 25 / 100 - pagoDescuentoSaludPension;

        //datos de salida

        Console.WriteLine("El empleado: " + empleado + " con cargo " + cargo);
        Console.WriteLine("Trabajo " + horasTrabajadas + " horas y cada una con un valor de " + valorHora + "$ c/u");
        Console.WriteLine("El total neto a pagar es: " + pagoCompleto + "$");
        Console.WriteLine("El total mas deduciones y embargo es: " + pagoDeducciones + "$");

    }

}