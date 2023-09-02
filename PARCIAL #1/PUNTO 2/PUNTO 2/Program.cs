using System;

class Program
{
    static void Main()
       
    {
        double salarioneto, deduccionsaludpension, embargo, salariototal,totaldeducciones;

        Console.WriteLine("Por favor, ingrese nombre del empleado:");
        string nombre = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese el cargo del empleado:");
        string cargo = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la cantidad de horas trabajadas:");
        double horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese el valor de la hora trabajada:");
        double vhora = double.Parse(Console.ReadLine());

        salarioneto = horas * vhora;
        deduccionsaludpension=salarioneto*0.08;
        embargo = salarioneto * 0.25;
        totaldeducciones = deduccionsaludpension + embargo;
        salariototal = salarioneto - totaldeducciones;

        Console.WriteLine("Nombre empleado:" + nombre);
        Console.WriteLine("El cargo del empleado es:" + cargo);
        Console.WriteLine("El salario total del empleado es:" + salarioneto );
        Console.WriteLine("El salario con deducciones del empleado es:" + salariototal);

        



    }
}

