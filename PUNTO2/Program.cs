// Punto 2: Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado. 
//Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora.
//Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class PUNTO2
{
    static void Main(string[] arg)
    {

        //datos de entrada
        int Empleado, Cargo, Horas, ValorHora, Salud, Pension, Embargo, SalarioNeto, SalarioTotal;

        Console.WriteLine("Ingresa el Nombre del Empleado");
        Empleado = PublicKey (Console.WriteLine());

        Console.WriteLine("Ingresa el Cargo"());
        Cargo = PublicKey(Console.WriteLine());

        Console.WriteLine("Ingresa las Horas Laboradas");
        Horas = PublicKey(Console.WriteLine());

        Console.WriteLine("Ingresa las Horas Laboradas");
        ValorHora = PublicKey(Console.WriteLine());

        //Proceso
        SalarioNeto = Horas * ValorHora;

        Salud = SalarioNeto * 0,04;

        Pension = SalarioNeto * 0,04;

        Embargo = (SalarioNeto - Salud - Pension) / 4;

        SalarioTotal = SalarioNeto - Salud - Pension - Embargo;


        //Salida
        Console.WriteLine("El Nombre del Empleado Es: " + Empleado);
        Console.WriteLine("El Cargo del Empleado es: " + Cargo);
        Console.WriteLine("El Salario Neto es:" + SalarioNeto);
        Console.WriteLine("El Salario Total es:" + SalarioTotal);





    }




}
