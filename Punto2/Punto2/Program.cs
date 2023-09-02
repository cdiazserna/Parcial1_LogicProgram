using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Desarrolle un algoritmo de C # que me permita calcular la nómina del mes de un empleado. Debemios
            //pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y el valor de la hora

            //Declaramos los tipos de variables

            String nombreEmpleado, cargoEmpleado;
            double horasTrabajadas; 
            decimal valorHora;

            //realizamos el proceso para calcular el salario

            Console.WriteLine("Ingrese por favor su nombre ");
            nombreEmpleado = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Ingrese por favor su cargo ");
            cargoEmpleado = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Indique por favor las horas trabajadas ");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Indique por favor el valor de su hora de trabajo ");
            valorHora = Convert.ToDecimal(Console.ReadLine());





        }
    }
}
