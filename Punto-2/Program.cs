using System;

namespace Punto_2

    //: Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado.
    //Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora
    //Se debe descontar de su salario el 4% correspondientes a salud, el 4% correspondientes a pensión y
    //¼ parte por un embargo bancarios que recibió dicho empleado
    //Mostrar por pantalla el nombre del empleado, su cargo, salario neto (antes de deducciones) 
    // y salario final (después de deducciones).

{
    // 1 clase y metodo
    public class Punto2
    {
        static void Main(string[] args)
        {
            // 2 declaracion de varibles

            string nombre, cargo;
            double salario, nomina, horas, valorHora, embargo, nominaTotal;

            //  3 pedir datos por pantalla

            Console.WriteLine("Digite el nombre del empleado: ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Digite el cargo del empleado: ");
            cargo = Console.ReadLine();

            Console.WriteLine("Digite el salario del empleado: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite las horas trabajadas del empleado: ");
            horas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor de la hora del empleado: ");
            valorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor del embargo del empleado: ");
            embargo = Convert.ToDouble(Console.ReadLine());

            
        }
    }
}
