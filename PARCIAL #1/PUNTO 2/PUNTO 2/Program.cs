using System;

class Program
{
    static void Main()
       
    {
        double salarioneto, deduccionsaludpension, embargo, salariototal;

        Console.WriteLine("Por favor, ingrese nombre del empleado:");
        string nombre = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese el cargo del empleado:");
        string cargo = (Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la cantidad de horas trabajadas:");
        double horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese el valor de la hora trabajada:");
        double vhora = double.Parse(Console.ReadLine());

        salarioneto = horas * vhora;
        deduccionsaludpension=salarioneto*0.92;
        embargo = salarioneto * 0.75;
        salariototal = salarioneto - deduccionsaludpension - embargo;

        Console.WriteLine("salario neto " + salarioneto + " y deducciones " + deduccionsaludpension + " son:");



    }
}

