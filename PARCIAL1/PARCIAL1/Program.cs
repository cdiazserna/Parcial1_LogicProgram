using System;

namespace PARCIAL1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir en pantalla
            Console.Write("Ingrese nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Cargo del empleado: ");
            string cargo = Console.ReadLine();

            Console.Write("Horas trabajadas por el empleado: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            Console.Write("Valor de la hora: ");
            double valorHora = double.Parse(Console.ReadLine());

          
            //Calcular deducciones
            double salarioNeto = (int)(horasTrabajadas * valorHora);

            double salud = salarioNeto * 0.04;

            double pension = salarioNeto * 0.04;

            double embargo = salarioNeto / 4;

            double salarioTotal = salarioNeto - salud - pension - embargo;

            //Mostrar en pantalla
            Console.WriteLine("nombre del empleado: " + nombre);

            Console.WriteLine("Cargo del empleado: " + cargo);

            Console.WriteLine("Salario neto (sin deducciones): " + salarioNeto);

            Console.WriteLine("Salario total: " + salarioTotal);
            
        }
    }
}
