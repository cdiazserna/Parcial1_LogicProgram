using System;

//Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado.
//Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y el valor de la hora.

//Se debe descontar de su salario el 4% correspondientes a salud, el 4% correspondientes a pensión y 1/4 parte por un
//embargo bancario que recibió dicho empleado

//Mostrar por pantalla el nombre del empleado, su cargo, salario neto (antes de deducciones)
//y salario final (despues de deducciones).


namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables

            string nombreEmpleado, cargo;
            double horasTrabajadas, valorHora;

            //Asignar valor a las variables o pedir data

            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombreEmpleado = (Console.ReadLine());

            Console.WriteLine("Ingrese el cargo del empleado: ");
            cargo = (Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del empleado: ");
            horasTrabajadas = (Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hora: ");
            valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Hello World!");
        }
    }
}
